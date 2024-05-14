using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowPointIcon : MonoBehaviour
{
    public GameObject theSpot;
    public GameObject follower;
    public GameObject follower2;
    public GameObject follower3;
    public GameObject icon1;
    public GameObject icon2;
    public GameObject icon3;
    public GameObject blockage;
    public GameObject blockagetext;
    public GameObject enemyspawner;


    public GameObject enemy;



    void Start()
    {
        blockagetext.active = false;
        enemy.active = false;


    } 

    void Update(){
    }
        

    private void OnCollisionEnter(Collision collision){
      if (collision.gameObject.name == "follower"){

        Destroy(follower);
        Destroy (icon1);
        Debug.Log("follower escaped");
        enemy.active = true; 
        enemyspawner.GetComponent<EnemySpawner>().SpawnEnemies();
        enemy.active = false;

      }
    
    
      if (collision.gameObject.name == "follower (2)"){

        Destroy(follower2);
        Destroy (icon2);
        enemy.active = true; 
        enemyspawner.GetComponent<EnemySpawner>().SpawnEnemies();
        enemy.active = false;


      }

      if (collision.gameObject.name == "follower (3)"){

        Destroy(follower3);
        Destroy (icon3);
        Destroy (blockage);
        blockagetext.active = true;
      }



  }


  }   

