using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equip2 : MonoBehaviour
{
    public Transform PlayerTransform;
    public Transform GunHolster;
    public GameObject Gun;
    public Camera Camera;
    public float pickUpRange2;
    public static bool holdingGun = false;
    

    // Start is called before the first frame update
    void Start()
    {
        Gun.GetComponent<Rigidbody>().isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 distanceToPlayer = PlayerTransform.position - transform.position;

        if (Input.GetKeyDown("f") && distanceToPlayer.magnitude <= pickUpRange2)
        {
            EquipObject();
            holdingGun = true;
            
        }
        else if (Input.GetKeyDown("e"))
        {
            UnequipObject();
            holdingGun = false;
        }
        
    }

    

    

    void EquipObject()
    {
        Gun.GetComponent<Rigidbody>().isKinematic = true;
        Gun.transform.position = PlayerTransform.transform.position;
        Gun.transform.rotation = PlayerTransform.transform.rotation;
        Gun.transform.SetParent(PlayerTransform);
    }

    void UnequipObject()
    {
        Gun.transform.position = GunHolster.transform.position;
        Gun.transform.rotation = GunHolster.transform.rotation;
        Gun.transform.SetParent(GunHolster);
    }
}