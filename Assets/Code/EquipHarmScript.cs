using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipHarmScript : MonoBehaviour
{
    public Transform PlayerTransform;
    public GameObject Harm;
    public Camera Camera;
    public float range = 2f;
    public float open = 100f;

    // Start is called before the first frame update
    void Start()
    {
        Harm.GetComponent<Rigidbody>().isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            EquipHarm();
    

        }
        else if (Input.GetKeyDown("e")){
            UnequipHarm();
        }
    }

    void EquipHarm()
    {
        Harm.GetComponent<Rigidbody>().isKinematic = true;
        Harm.transform.position = PlayerTransform.transform.position;
        Harm.transform.rotation = PlayerTransform.transform.rotation;
        Harm.transform.SetParent(PlayerTransform);
    }

    void UnequipHarm()
    {
        PlayerTransform.DetachChildren();
        Harm.transform.eulerAngles = new Vector3(Harm.transform.eulerAngles.x, Harm.transform.eulerAngles.y, Harm.transform.eulerAngles.z - 45);
        Harm.GetComponent<Rigidbody>().isKinematic = false;
    }

}