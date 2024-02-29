using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipKeyScript : MonoBehaviour
{
    public Transform KeyTransform;
    public GameObject Key;
    public Camera Camera;
    public float pickUpRangeKey;
    public GameObject open;
    public GameObject open2;
    public GameObject open3;
    public bool fun;
    public static bool move;
    public Transform cageTransform;
    public Transform cageTransform2;
    public Transform cageTransform3;
    public float useKeyRange;

    


    void Start()
    {
        Key.GetComponent<Rigidbody>().isKinematic = true;
        fun = false;
        move = false;
    }

    void Update()
    {
        Vector3 distanceToPlayer = KeyTransform.position - transform.position;
        
        if (Input.GetKeyDown("k") && distanceToPlayer.magnitude <= pickUpRangeKey){
        
        EquipKey();
        fun = true;

        }
        
        Vector3 keyRange = KeyTransform.position - cageTransform.position;
        Vector3 keyRange2 = KeyTransform.position - cageTransform2.position;
        Vector3 keyRange3 = KeyTransform.position - cageTransform3.position;

        if(Input.GetKeyDown("o") && fun == true && keyRange.magnitude <= useKeyRange){
                open.GetComponent<Animator>().Play("cageanimation");
                move = true;
        }
        
        if(Input.GetKeyDown("o") && fun == true && keyRange2.magnitude <= useKeyRange){
                open2.GetComponent<Animator>().Play("cageanimation");
                move = true;
        }
        if(Input.GetKeyDown("o") && fun == true && keyRange3.magnitude <= useKeyRange){
                open3.GetComponent<Animator>().Play("cageanimation");
                move = true;
        }
        
    }

    void EquipKey()
    {
        Key.GetComponent<Rigidbody>().isKinematic = true;
        Key.transform.position = KeyTransform.transform.position;
        Key.transform.rotation = KeyTransform.transform.rotation;
        Key.transform.SetParent(KeyTransform);
        
  
    }
}