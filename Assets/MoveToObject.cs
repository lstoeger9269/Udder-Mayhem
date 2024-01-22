using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToObject : MonoBehaviour
{
    public GameObject FollowingObject;
    public GameObject OtherObject;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        FollowingObject.transform.position = Vector3.MoveTowards(FollowingObject.transform.position, OtherObject.transform.position, speed);
    }
}
