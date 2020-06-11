using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubWeapon : MonoBehaviour
{
    [SerializeField] private GameObject bulletFactory;      //bullet prefab
    [SerializeField] private GameObject firePosition;
    //private bool shoot;
    private float count = 0;
    // Start is called before the first frame update
    void Start()
    {
        //shoot = true;
        //InvokeRepeating("Fire", 0, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 45 * Time.deltaTime, 0);
        if(++count % 60 == 0)
        {
            Fire();
        }
        
    }


    private void Fire()
    {
        //default mouse 0  left ctrl
        //if (Input.GetButtonDown("Fire1"))
        //{
        //bulletFactory make infinity bullet
        //Instantiate() function prefab file to gameobject

            GameObject bullet = Instantiate(bulletFactory);
            //bullet object position(start position -> player position)
            bullet.transform.position = firePosition.transform.position;
        //}

    }
}
