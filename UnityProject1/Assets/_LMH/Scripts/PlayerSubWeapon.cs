using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSubWeapon : MonoBehaviour
{
    [SerializeField] private GameObject[] sub;
    private int weaIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            sub[weaIndex].SetActive(true);
            weaIndex++;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            sub[weaIndex].SetActive(true);
            weaIndex++;
        }
        if(weaIndex >sub.Length)
        {
            weaIndex = sub.Length;
        }
    }
}
