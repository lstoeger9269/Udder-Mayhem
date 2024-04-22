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


    [SerializeField]
    public GameObject enemy;

    //[SerializeField]
    public float enemyInterval = 4f;
    public int times;
    public int timesLimit = 2;


    void Start()
    {
        blockagetext.active = false;
        StartCoroutine(spawnEnemy(enemyInterval,enemy));
        enemy.active = false;
    } 
        

    private void OnCollisionEnter(Collision collision){
      if (collision.gameObject.name == "follower"){

        Destroy(follower);
        Destroy (icon1);
        StartCoroutine(spawnEnemy2(enemyInterval,enemy));



      }
    
    
      if (collision.gameObject.name == "follower (2)"){

        Destroy(follower2);
        Destroy (icon2);
        StartCoroutine(spawnEnemy3(enemyInterval,enemy));


      }

      if (collision.gameObject.name == "follower (3)"){

        Destroy(follower3);
        Destroy (icon3);
        Destroy (blockage);
        blockagetext.active = true;
      }



  }

//time could be pointless, play with that
public IEnumerator spawnEnemy(float enemyInterval, GameObject enemy){

      while (times <= timesLimit){

        yield return new WaitForSeconds(enemyInterval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-3f, 7), Random.Range(-3f, 7f), -89), Quaternion.identity);
        times++;
        newEnemy.active = true;
        StartCoroutine(spawnEnemy(enemyInterval, enemy));
              
      }


    } 
public IEnumerator spawnEnemy2(float enemyInterval, GameObject enemy){

        if (times >= 5 && times <= 8 ){
          yield return new WaitForSeconds(enemyInterval);
          GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-3f, 7), Random.Range(-3f, 7f), -89), Quaternion.identity);
          times++;
          StartCoroutine(spawnEnemy(enemyInterval, enemy));
      }


    }
      
public IEnumerator spawnEnemy3(float enemyInterval, GameObject enemy){

        if (times >= 10 && times <= 13){
          yield return new WaitForSeconds(enemyInterval);
          GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-3f, 7), Random.Range(-3f, 7f), -89), Quaternion.identity);
          newEnemy.active = true;
          times++;
          StartCoroutine(spawnEnemy(enemyInterval, enemy));
        }


    }

        }   

