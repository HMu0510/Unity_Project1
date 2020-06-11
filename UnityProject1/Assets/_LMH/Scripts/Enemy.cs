using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject fxFactory;

    //falling down
    //collision (e <-> p, e<->bullet)

    public float speed = 10.0f;
    private Vector3 move;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move = Vector3.down * speed;
        transform.position += move * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            //게임종료(메인메뉴 Or 죽었다는 UI 출력)
        }
        else if(collision.gameObject.name == "SubWeapon")
        {
            collision.gameObject.SetActive(false);
          
        }
        else
        {
            ScoreBoard.instance.AddScore();
            Destroy(collision.gameObject);
        }
        Destroy(gameObject);
        ShowEffect();

    }
    private void ShowEffect()
    {
        GameObject fx = Instantiate(fxFactory);
        fx.transform.position = transform.position;
        Destroy(fx, 0.5f);
    }
}
