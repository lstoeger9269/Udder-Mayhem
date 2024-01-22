using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipHarmScript : MonoBehaviour
{
    public Transform HarmTransform;
    public Transform PlayerTransform2;
    public GameObject Harm;
    public Camera Camera;
    private AudioSource sound;
    public float pickUpRange;


    void Start()
    {
        Harm.GetComponent<Rigidbody>().isKinematic = true;
        sound = GetComponent<AudioSource>();
        //Vector3 distanceToPlayer = HarmTransform.position - transform.position;

    }

    void Update()
    {
        Vector3 distanceToPlayer = HarmTransform.position - transform.position;
        
        if (Input.GetKeyDown("g") && distanceToPlayer.magnitude <= pickUpRange) 
        
        EquipHarm();
    
        else if (Input.GetKeyDown("e")){
            UnequipHarm();
        }

    }

    void EquipHarm()
    {
        Harm.GetComponent<Rigidbody>().isKinematic = true;
        Harm.transform.position = HarmTransform.transform.position;
        Harm.transform.rotation = HarmTransform.transform.rotation;
        Harm.transform.SetParent(HarmTransform);
        sound.Play();
    }

    void UnequipHarm()
    {
        Harm.transform.position = PlayerTransform2.transform.position;
        Harm.transform.rotation = PlayerTransform2.transform.rotation;
        Harm.transform.SetParent(PlayerTransform2);
        sound.Stop();
    }

}