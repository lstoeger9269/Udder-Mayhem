using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetection : MonoBehaviour
{

    static public bool found = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Cow")
        {
            found = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        found = false;
    }
    
}
