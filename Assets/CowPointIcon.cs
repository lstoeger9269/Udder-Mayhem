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


    void Start()
    {

    }
  

    void OnTriggerEnter(Collider other){

    if(other.CompareTag ("cowbox")){


          Destroy(icon1);
          Destroy(follower);
          
      }
    

    //void OnTriggerEnter2(Collider other2){


    else if(other.CompareTag ("cowbox")){

          Destroy(icon2);
          Destroy(follower2);

      }

    //}
    
   // void OnTriggerEnter3(Collider other3){

    else if(other.CompareTag ("cowbox")){

          Destroy(icon3);
          Destroy(follower3);
      }
    //}
}
}