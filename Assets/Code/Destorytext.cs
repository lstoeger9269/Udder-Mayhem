using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destorytext : MonoBehaviour
{

    [SerializeField] private float secondstodestroy = 1f;


    void Start()
    {
        
    }

    void Update()
    {

        if (Input.GetKeyDown("g")){
            Destroy(gameObject);
        }

        else if(Input.GetKeyDown("f")){
            Destroy(gameObject);
        }
    }
}
