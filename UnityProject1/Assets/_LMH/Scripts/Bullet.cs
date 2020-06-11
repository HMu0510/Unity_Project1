using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //플레이어가 발사 버튼을 누르면
    //총알이 생성된 후 위로(발사 방향)만 움직인다

    [SerializeField] float speed = 10.0f;
    public int damage = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    //move out camera's vision destroy bullet
    //private void OnBecameInvisible()
    //{
    //    Destroy(gameObject);
    //}
}
