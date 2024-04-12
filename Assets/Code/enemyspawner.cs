using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawner : MonoBehaviour
{

    [SerializeField]
    private GameObject enemy;

    [SerializeField]
    private float enemyInterval = 3f;
    private int times = 0;
    private int timesLimit = 3;


    void Start()
    {
        StartCoroutine(spawnEnemy(enemyInterval,enemy));
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy){
while (times <= timesLimit){

        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-3f, 7), Random.Range(-3f, 7f), -89), Quaternion.identity);
        times++;
        StartCoroutine(spawnEnemy(interval, enemy));
    }
    }
}
