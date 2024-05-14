using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyToClone;
    public GameObject enemy;
    public int spawnVar;

    
    // Start is called before the first frame update
    void Start()
    {

        enemy.active = true;
        SpawnEnemies();
        enemy.active = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)){
            enemy.active = true;
            SpawnEnemies();
            enemy.active = false;

        }
    
    }

    public void SpawnEnemies(){
        Debug.Log("Enemies summoned");
        Instantiate(enemyToClone, transform.position, transform.rotation);
        spawnVar++;
        Instantiate(enemyToClone, transform.position, transform.rotation);
        spawnVar++;
        Instantiate(enemyToClone, transform.position, transform.rotation);
        spawnVar++;
        Instantiate(enemyToClone, transform.position, transform.rotation);
        spawnVar++;
        Instantiate(enemyToClone, transform.position, transform.rotation);
        spawnVar++;
    }

}
