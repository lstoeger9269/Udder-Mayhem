using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Follower"))
        {
            other.GetComponent<CowPointIcon>().GainPoint();
        }
    }
}

