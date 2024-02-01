using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject cagedoor;
    private Animator anim;
    public Animation closed;
    public Animation open;
    private bool Isopen;
    void Start()
    {
        anim = GetComponent<Animator>();
        Isopen = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Isopen == false && (Input.GetKey(KeyCode.X)))
        {
            anim.SetTrigger("OpenDoor");
            Isopen = false;
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "democow")
        {
            Isopen = true;
        }
    }
}
