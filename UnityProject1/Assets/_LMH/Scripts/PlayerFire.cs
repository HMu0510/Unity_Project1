using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    [SerializeField] private GameObject bulletFactory;      //bullet prefab
    [SerializeField] private GameObject firePosition;
    LineRenderer lr;
    
    private Vector3 lrPos0;
    private Vector3 lrPos1;
    private Vector3 dest;
    private bool lrSet;
    private bool bosshit;
    RaycastHit colli;
    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>();
        lr.enabled = false;
        lrSet = false;
        bosshit = false;



        //gameObj use SetActive, component use enabled
    }

    // Update is called once per frame
    void Update()
    {
        Fire();
        FireRay();
        
    }

    private void Fire()
    {
        //default mouse 0  left ctrl
        if(Input.GetButtonDown("Fire1"))
        {
            //bulletFactory make infinity bullet
            //Instantiate() function prefab file to gameobject

            GameObject bullet = Instantiate(bulletFactory);
            //bullet object position(start position -> player position)
            bullet.transform.position = firePosition.transform.position;
        }
    }
    private void FireRay()
    {
        if (Input.GetButtonDown("Fire2") && !lr.enabled)
        {
            lr.enabled = true;
            lrPos0 = firePosition.transform.position;
            lrPos1 = firePosition.transform.position;
            lr.SetPosition(0, lrPos0);
            lr.SetPosition(1, lrPos1);

            //if(Physics.Raycast(ray,out hitInfo))
            //{
            //    //lr.SetPosition(1, hitInfo.point);
            //}
            //{
            //    //no collision object. set endPoint
            //}
            Ray ray = new Ray(transform.position, Vector3.up);
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo))
            {
                if (hitInfo.collider.name == "Boss")
                {
                    dest = hitInfo.point;
                    bosshit = true;
                    colli = hitInfo;
                    
                }
                else if (hitInfo.collider.name.Contains("Enemy"))
                {
                    dest = hitInfo.point;
                    colli = hitInfo;
 
                }
                else
                {
                    dest = transform.position + Vector3.up * 10;

                }

            }
            else
            {
                dest = transform.position + Vector3.up * 10;
            }
        }
        if(lr.enabled)
        {

            if(!lrSet)
            {
                lrPos1 += Vector3.up * 40 * Time.deltaTime;
                lr.SetPosition(1, lrPos1);
                if (lr.GetPosition(1).y > dest.y)
                {
                    if(!bosshit)
                    {
                        Destroy(colli.collider.gameObject);
                        lrSet = false;
                        lr.enabled = false;
                    }
                    else
                    {

                    }
                    lrSet = true;
                }
            }
            else
            {
                lrPos0 += Vector3.up * 20 * Time.deltaTime;
                lr.SetPosition(0, lrPos0);
                if (lrPos0.y > lr.GetPosition(1).y)
                {
                    lrSet = false;
                    lr.enabled = false;
                    bosshit = false;
                }
            }
        }
    }
}
