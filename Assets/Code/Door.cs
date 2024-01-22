using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    private Animator anim;

    private bool Isopen = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Isopen == true && (Input.GetKey(KeyCode.X)))
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
