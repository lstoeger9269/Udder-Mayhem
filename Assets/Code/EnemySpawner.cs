using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyToClone;
    public GameObject enemy;
    public int spawnVar;
    public bool key1;
    public bool key2;
    public bool key3;
    public GameObject Key;
    public GameObject Key2;
    public GameObject Key3;


    
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
        if (spawnVar == 10){
            Key2ShowUp();
        }
        if(spawnVar == 15){
            Key3ShowUp();
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
    

    public void Key2ShowUp(){
            if(spawnVar == 10){
                key2 = true;
                gameObject.GetComponent<EquipKeyScript>().Key2NotTrue(key2);
        }
        }
    public void Key3ShowUp(){
            if(spawnVar == 15){
                key3 = true;
                gameObject.GetComponent<EquipKeyScript>().Key3NotTrue(key3);

        }
        }

}
