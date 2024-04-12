using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followharm : MonoBehaviour
{
    public GameObject FollowingObject;
    public GameObject OtherObject;
    public float speed;
    bool harmonica;
    public float FollowRange;
    public Transform HarmTransform;



    void Start(){
        harmonica = false;
    }

    void Update(){
        
        Vector3 distanceToPlayer = HarmTransform.position - transform.position;

        if (Input.GetKeyDown("g") && distanceToPlayer.magnitude <= FollowRange ){
            harmonica = true;

        }
            
            if (harmonica == true && EquipKeyScript.move == true){
                Follow();
                print("bonk");
            }
            
                if (Input.GetKeyDown("e")){
                    harmonica = false;

                }

    }

    void Follow()
    {    

        FollowingObject.transform.position = Vector3.MoveTowards(FollowingObject.transform.position, OtherObject.transform.position, speed);

    }
}