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
    public int value;

    void Start()
    {

    }


    void OnTriggerEnter(Collider other){

    if(other.CompareTag ("cowbox") && value <= 0){

          Destroy(icon1);
          Destroy(follower);
          value += 1;
      }
    }

    void OnTriggerEnter2(Collider other){


    if(other.CompareTag ("cowbox") && value == 1){

          Destroy(icon2);
          Destroy(follower2);
          value += 1;
    }

    }
    
    void OnTriggerEnter3(Collider other){

    if(other.CompareTag ("cowbox") && value == 2){

          Destroy(icon3);
          Destroy(follower3);
      }
    }   
}    
