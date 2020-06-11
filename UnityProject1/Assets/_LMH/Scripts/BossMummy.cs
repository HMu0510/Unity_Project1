using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMummy : MonoBehaviour
{
    [SerializeField] private GameObject bulletFactory;      //bullet prefab
    [SerializeField] private GameObject firePosition;
    [SerializeField] private GameObject player;
    public int hp = 100;
    private float count = 0;
    public int bulletMax = 8;
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("Fire", 0, 1.0f);
        //InvokeRepeating("SpreadFire", 2, 3.3f);
    }

    // Update is called once per frame
    void Update()
    {
        count += 60*Time.deltaTime;
        if(count % 2 == 0)
        {
            Fire();
        }
        else if(count % 5 == 0)
        {
            SpreadFire();
        }
        if(hp <=0)
        {
            this.gameObject.SetActive(false);

        }
    }
    private void Fire()
    {
        GameObject bullet = Instantiate(bulletFactory);
        //bullet object position(start position -> player position)
        bullet.transform.position = firePosition.transform.position;
        Vector3 dir = player.transform.position - transform.position;
        dir.Normalize();
        bullet.transform.up = dir;

    }
    private void SpreadFire()
    {
        for (int i = 0; i < bulletMax; i++)
        {
            GameObject bullet = Instantiate(bulletFactory);
            bullet.transform.position = transform.position;
            float angle = 360.0f / bulletMax;
            bullet.transform.eulerAngles = new Vector3(0, 0, i * angle);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name.Contains("Bullet"))
        {
            hp -= 3;
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.name.Contains("SubBullet"))
        {
            hp--;
            Destroy(collision.gameObject);
        }
    }
}
