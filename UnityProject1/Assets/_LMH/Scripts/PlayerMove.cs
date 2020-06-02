using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    [SerializeField] private float rotSpeed = 45.0f;
    private bool triger;
    private Collider col;
    private Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        col = gameObject.GetComponent<Collider>();
        rigid = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        //transform.Rotate(0, rotSpeed * Time.deltaTime, 0);
    }
    private void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        if (transform.position.x >= 2.3f)
        {
            if(h >0)
            {
                h = 0;
            }
        }
        if (transform.position.x <= -2.3f)
        {
            if (h < 0)
            {
                h = 0;
            }
        }
        if (transform.position.y >= 5.5f)
        {
            if (v > 0)
            {
                v = 0;
            }
        }
        if (transform.position.y <= -3.5f)
        {
            if (v < 0)
            {
                v = 0;
            }
        }
        //Camera.main.
        //transform.Translate(h * speed * Time.deltaTime, v * speed * Time.deltaTime,0);
        Vector3 dir = new Vector3(h, v, 0);
        //dir.Normalize();
        transform.Translate(dir * speed * Time.deltaTime);

        //Vector3 position = transform.position;
        //position.x = Mathf.Clamp(position.x, -2.3f, 2.3f);
        //position.y = Mathf.Clamp(position.y, -3.5f, 5.5f);
        //transform.position = position;


    }
}
