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

    }

    public void SpawnEnemies(){
        Instantiate(enemyToClone, transform.position, transform.rotation);
        Instantiate(enemyToClone, transform.position, transform.rotation);
        Instantiate(enemyToClone, transform.position, transform.rotation);
        Instantiate(enemyToClone, transform.position, transform.rotation);
        Instantiate(enemyToClone, transform.position, transform.rotation);
    }
}
