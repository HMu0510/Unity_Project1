//using System; 이싀끠있으면 랜덤함수 사용 불가 생성 오류 버그
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] GameObject enemyFactory1;
    [SerializeField] GameObject enemyFactory2;
    [SerializeField] GameObject[] spawnPoint;
    public float spawnTime = 1.0f;
    public float currentTime = 0.0f;


    // Update is called once per frame
    void Update()
    {
        SpawnEnemy();
    }

    private void SpawnEnemy()
    {
        GameObject enemy;   
        currentTime += Time.deltaTime;
        if(currentTime > spawnTime)
        {
            int ran = Random.Range(0, 2);
            if(ran ==1)
            {
                enemy = Instantiate(enemyFactory1);
                enemy.transform.position = spawnPoint[Random.Range(0, spawnPoint.Length)].transform.position;
                //enemy.transform.position = spawnPoint[Random.Range(0, 4)].transform.position;
                enemy.transform.position = transform.GetChild(Random.Range(0, spawnPoint.Length)).transform.position;

            }
            else
            {
                enemy = Instantiate(enemyFactory2);
                enemy.transform.position = spawnPoint[Random.Range(0, spawnPoint.Length)].transform.position;
                //enemy.transform.position = spawnPoint[Random.Range(0, 4)].transform.position;
                enemy.transform.position = transform.GetChild(Random.Range(0, spawnPoint.Length)).transform.position;
            }

            currentTime = 0.0f;
            spawnTime = Random.Range(0.5f, 2.0f);
        }
    }
}
