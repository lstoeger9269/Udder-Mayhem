using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipKeyScript : MonoBehaviour
{
    public Transform KeyTransform;
    public GameObject Key;
    public GameObject Key2;
    public GameObject Key3;
    public Camera Camera;
    public float pickUpRangeKey;
    public GameObject open;
    public GameObject open2;
    public GameObject open3;
    public bool fun;
    public bool fun2;
    public bool fun3;
    public static bool move;
    public Transform cageTransform;
    public Transform cageTransform2;
    public Transform cageTransform3;
    public float useKeyRange;
    public GameObject cowtext;
    public GameObject clones;
    public int varible;




    


    void Start()
    {
        fun = false;
        fun2 = false;
        fun3 = false;
        move = false;
        cowtext.active = false;
        Key1NotTrue(true);
        //Key2NotTrue(false);
        //Key3NotTrue(false);
        varible = 0;


    }

    void Update()
    {
        Vector3 distanceToPlayer = KeyTransform.position - transform.position;
        
        if (Input.GetKeyDown("k") && distanceToPlayer.magnitude <= pickUpRangeKey && varible == 0){
        
        EquipKey();
        fun = true;
        varible += 1;



        }
        if (Input.GetKeyDown("k") && distanceToPlayer.magnitude <= pickUpRangeKey && Key == null){
        
        EquipKey2();
        fun2 = true;
        

        }
        
        if (Input.GetKeyDown("k") && distanceToPlayer.magnitude <= pickUpRangeKey && Key2 == null){
        
        EquipKey3();
        fun3 = true;
     

        }




        Vector3 keyRange = KeyTransform.position - cageTransform.position;
        Vector3 keyRange2 = KeyTransform.position - cageTransform2.position;
        Vector3 keyRange3 = KeyTransform.position - cageTransform3.position;

        if(Input.GetKeyDown("o") && fun == true && keyRange.magnitude <= useKeyRange){
                open.GetComponent<Animator>().Play("cageanimation");
                move = true;
                Key1NotTrue(false);
                Destroy(Key);
                Key = null;


        }
        
        if(Input.GetKeyDown("o") && fun2 == true && keyRange2.magnitude <= useKeyRange){
                open2.GetComponent<Animator>().Play("cageanimation");
                move = true;
                Destroy(Key2);
                Key2 = null;
        }
        if(Input.GetKeyDown("o") && fun3 == true && keyRange3.magnitude <= useKeyRange){
                open3.GetComponent<Animator>().Play("cageanimation");
                move = true;
                Destroy(Key3);
        }
        
    }

    void EquipKey()
    {
        Key.GetComponent<Rigidbody>().isKinematic = true;
        Key.transform.position = KeyTransform.transform.position;
        Key.transform.rotation = KeyTransform.transform.rotation;
        Key.transform.SetParent(KeyTransform);
        
    }

    void EquipKey2()
    {
        Key2.GetComponent<Rigidbody>().isKinematic = true;
        Key2.transform.position = KeyTransform.transform.position;
        Key2.transform.rotation = KeyTransform.transform.rotation;
        Key2.transform.SetParent(KeyTransform);
        
    }

    void EquipKey3()
    {
        Key3.GetComponent<Rigidbody>().isKinematic = true;
        Key3.transform.position = KeyTransform.transform.position;
        Key3.transform.rotation = KeyTransform.transform.rotation;
        Key3.transform.SetParent(KeyTransform);
        
    }

    public void Key1NotTrue(bool key1){
        if(key1){
        Key.active = true;
        }
        if(!key1){
        Key.active = false;
        }

    }

      public void Key2NotTrue(bool key2){
        if(key2){
        Key2.active = true;
        }
        if(!key2){
        Key2.active = false;
        }

    }  
    public void Key3NotTrue(bool key3){
        if(key3){
        Key3.active = true;
        }
        if(!key3){
        Key3.active = false;
        }

    }







}