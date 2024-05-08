using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookAt : MonoBehaviour
{
    public Transform target;
    public float turnSpeed = .01f;
    Quaternion rotGoal;
    Vector3 direction;
    bool looking = false;

    void Update(){
        if(looking){
            direction = (target.position - transform.position).normalized;
            rotGoal = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotGoal, turnSpeed);
        }
    }
    private void OnTriggerStay(Collider collider)
    {
        if (collider.CompareTag("Tree"))
        {
            Debug.Log("Collided with tree");
            looking = true;
        }
    }
}