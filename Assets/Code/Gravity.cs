using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    float gravity = 5;
    Rigidbody rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        rig.AddForce(Vector3.down*gravity, ForceMode.Force);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
