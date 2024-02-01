using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipKeyScript : MonoBehaviour
{
    public Transform KeyTransform;
    public GameObject Key;
    public Camera Camera;
    public float pickUpRangeKey;
    public Animator animatr;


    void Start()
    {
        Key.GetComponent<Rigidbody>().isKinematic = true;
        animatr = GetComponent<Animator>();
    }

    void WhenKeyUse()
    {
        animatr.SetTrigger("onKeyUse");
    }

    void Update()
    {
        Vector3 distanceToPlayer = KeyTransform.position - transform.position;
        
        if (Input.GetKeyDown("k") && distanceToPlayer.magnitude <= pickUpRangeKey){
        
        EquipKey();

            if (Input.GetKeyDown("x"))
                WhenKeyUse();
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