using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround2 : MonoBehaviour
{
    public float speed = 1.0f;
    public bool boss1;
    public bool boss2;
    public bool boss1Clear;
    public bool boss2Clear;
    // Start is called before the first frame update
    void Start()
    {
        boss1 = false;
        boss2 = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y >= -9.3f && !boss1 && !boss2)
        {
            transform.position +=Vector3.down * speed * Time.deltaTime;
        }
        if (transform.position.y <=0.5f && !boss1 && !boss1Clear)
        {
            boss1 = true;
        }
        if(transform.position.y <=-9.2f && !boss2 && !boss2Clear)
        {
            boss2 = true;
        }
    }
}
