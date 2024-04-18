using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawner : MonoBehaviour
{
    public bool destroyOrNo;
    [SerializeField]
    private GameObject enemy;

    [SerializeField]
    private float enemyInterval = 4f;
    public int times;
    private int timesLimit = 2;


    void Start()
    {
        StartCoroutine(spawnEnemy(enemyInterval,enemy));
        enemy.active = false;

        if (other.CompareTag("follower")){
            other.GetComponent<CowPointIcon>().destroying(destroyOrNo);
        }


    }
    private IEnumerator spawnEnemy(float interval, GameObject enemy){

    void EnemySpawn1(){
        while (times<=timesLimit){

        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-3f, 7), Random.Range(-3f, 7f), -89), Quaternion.identity);
        times++;
        StartCoroutine(spawnEnemy(interval, enemy));
        }
    }
        void EnemySpawn2(){
        while (times<=timesLimit){
    if (times >= 5 && times <= 8 ){
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-3f, 7), Random.Range(-3f, 7f), -89), Quaternion.identity);
        times++;
        StartCoroutine(spawnEnemy(interval, enemy));
    }
    }
        }
        void EnemySpawn3(){
        while (times<=timesLimit){
           if (times >= 10 && times <= 13){
          yield return new WaitForSeconds(interval);
          GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-3f, 7), Random.Range(-3f, 7f), -89), Quaternion.identity);
          newEnemy.active = true;
          times++;
          StartCoroutine(spawnEnemy(interval, enemy));
        }
    }

        }   
    }
}

  