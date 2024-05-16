using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyToClone;
    public GameObject enemy;
    public int spawnVar;
    public GameObject enemyBox;

    
    void Start()
    {

        enemy.active = true;
        SpawnEnemies();
        enemy.active = false;
    }

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
    
    public void OnCollisionEnter(Collision collision){
        if (collision.gameObject.tag == "Enemy"){
            spawnVar--;
    
    }

}
}
