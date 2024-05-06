using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyToClone;
    public GameObject enemy;

    
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemies();
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
        Instantiate(enemyToClone, transform.position, transform.rotation);
        Instantiate(enemyToClone, transform.position, transform.rotation);
        Instantiate(enemyToClone, transform.position, transform.rotation);
        Instantiate(enemyToClone, transform.position, transform.rotation);
    }

}
