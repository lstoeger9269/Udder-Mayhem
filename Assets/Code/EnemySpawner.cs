using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyToClone;
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemies();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)){
            SpawnEnemies();
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
