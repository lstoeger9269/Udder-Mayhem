using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipScript : MonoBehaviour
{
    public Transform PlayerTransform;
    public GameObject Gun;
    public Camera Camera;
    public float range = 2f;
    public float open = 100f;

    // Start is called before the first frame update
    void Start()
    {
        Gun.GetComponent<Rigidbody>().isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            EquipObject();
            
        }
        else if (Input.GetKeyDown("e"))
        {
            UnequipObject();
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
        PlayerTransform.DetachChildren();
        Gun.transform.eulerAngles = new Vector3(Gun.transform.eulerAngles.x, Gun.transform.eulerAngles.y, Gun.transform.eulerAngles.z - 45);
        Gun.GetComponent<Rigidbody>().isKinematic = false;
    }
}