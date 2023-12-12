using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipHarmScript : MonoBehaviour
{
    public Transform PlayerTransform;
    public Transform PlayerTransform2;
    public GameObject Harm;
    public Camera Camera;
    public float range = 2f;
    public float open = 100f;
    public AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        Harm.GetComponent<Rigidbody>().isKinematic = true;
        source = GetComponent<AudioSource>();
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
        source.Play();
    }

    void UnequipHarm()
    {
        Harm.transform.position = PlayerTransform2.transform.position;
        Harm.transform.rotation = PlayerTransform2.transform.rotation;
        Harm.transform.SetParent(PlayerTransform2);
        source.Stop();
    }

}