using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [SerializeField] GameObject box1;
    [SerializeField] GameObject box2;
    public BackGround2 bg;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(bg.transform.position.y <= 7.6f)
        {
            box2.SetActive(true);
        }
    }
}
