using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    [SerializeField] private GameObject item;
    public BackGround2 bg;
    private float speed;
    private int hp = 3;
    // Start is called before the first frame update
    void Start()
    {
        speed = bg.speed;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
        if(hp <=0)
        {
            item.SetActive(true);
            item.transform.position = transform.position;
            Destroy(gameObject);
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name.Contains("Bullet"))
        {
            hp--;
        }
    }
}
