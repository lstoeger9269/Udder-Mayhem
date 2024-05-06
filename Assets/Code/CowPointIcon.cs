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
    public int timesLimit = 4;



    void Start()
    {
        blockagetext.active = false;
        //enemy.active = false;


    } 

    void Update(){
    }
        

    private void OnCollisionEnter(Collision collision){
      if (collision.gameObject.name == "follower"){

        Destroy(follower);
        Destroy (icon1);
        StartCoroutine(spawnEnemy(enemyInterval,enemy));
        Debug.Log("follower escaped");
      }
    
    
      if (collision.gameObject.name == "follower (2)"){

        Destroy(follower2);
        Destroy (icon2);
        StartCoroutine(spawnEnemy(enemyInterval,enemy));


      }

      if (collision.gameObject.name == "follower (3)"){

        Destroy(follower3);
        Destroy (icon3);
        Destroy (blockage);
        blockagetext.active = true;
      }



  }

  public IEnumerator spawnEnemy(float enemyInterval, GameObject enemy){

      if (times <= timesLimit){

        yield return new WaitForSeconds(enemyInterval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-3f, 7), Random.Range(-3f, 7f), -89), Quaternion.identity);
        times++;
        newEnemy.active = true;
              
      }


    } 

  }   

