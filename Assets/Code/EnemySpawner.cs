using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyToClone;

    int cow = 0;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemiesStart();
    }

    // Update is called once per frame
    void Update()
    {
        if(cow == 1){
            Instantiate(enemyToClone, transform.position, transform.rotation);
            Instantiate(enemyToClone, transform.position, transform.rotation);
            Instantiate(enemyToClone, transform.position, transform.rotation);
            Instantiate(enemyToClone, transform.position, transform.rotation);
            Instantiate(enemyToClone, transform.position, transform.rotation);
        }
    }

    public void SpawnEnemiesStart(){
        Debug.Log("Enemies summoned");
        Instantiate(enemyToClone, transform.position, transform.rotation);
        Instantiate(enemyToClone, transform.position, transform.rotation);
        Instantiate(enemyToClone, transform.position, transform.rotation);
        Instantiate(enemyToClone, transform.position, transform.rotation);
        Instantiate(enemyToClone, transform.position, transform.rotation);
    }

    public void CowSaved(){
        Debug.Log("CowSaved");
        cow++;
    }
}
