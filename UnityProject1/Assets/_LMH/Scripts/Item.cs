using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] GameObject sub1;
    [SerializeField] GameObject sub2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if(!sub1.gameObject.activeSelf)
            {
                sub1.gameObject.SetActive(true);
            }
            else if(!sub2.gameObject.activeSelf)
            {
                sub2.gameObject.SetActive(true);
            }
            gameObject.SetActive(false);
        }
    }
}
