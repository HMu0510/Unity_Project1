using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossManager : MonoBehaviour
{
    [SerializeField] GameObject boss1;
    [SerializeField] GameObject boss2;
    private bool create = false;
    public BackGround2 bg;
    public BossMummy mummy;
    public BossPumkin pumkin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MakeBoss();
        BossDie();
    }
    void MakeBoss()
    {
        if(bg.boss1 &&!create)
        {
            boss1.SetActive(true);
            create = true;
            bg.boss1 = false;
            
        }
        else if(bg.boss2 && !create)
        {
            boss2.SetActive(true);
            bg.boss2 = true;
        }

    }
    private void BossDie()
    {
        if(boss1.gameObject.activeSelf)
        {
            if(mummy.hp <= 0)
            {
                boss1.SetActive(false);
                bg.boss1 = false;
                bg.boss1Clear = true;
                create = false;
            }
        }
    }
}
