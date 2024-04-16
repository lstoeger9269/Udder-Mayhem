using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawner : MonoBehaviour
{

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
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy){
while (times <= timesLimit){

        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-3f, 7), Random.Range(-3f, 7f), -89), Quaternion.identity);
        newEnemy.active = true;
        times++;
        StartCoroutine(spawnEnemy(interval, enemy));
    }
    
    
    if (times >= 5 && times <= 8){
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-3f, 7), Random.Range(-3f, 7f), -89), Quaternion.identity);
        newEnemy.active = true;
        times++;
        StartCoroutine(spawnEnemy(interval, enemy));


    }

    if (times >= 10 && times <= 13){
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-3f, 7), Random.Range(-3f, 7f), -89), Quaternion.identity);
        newEnemy.active = true;
        times++;
        StartCoroutine(spawnEnemy(interval, enemy));


    }

}
}