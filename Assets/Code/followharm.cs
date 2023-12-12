using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followharm : MonoBehaviour
{
    public GameObject FollowingObject;
    public GameObject OtherObject;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetKeyDown("f")){
            Update1();
        }
    }

    // Update is called once per frame
    void Update1()
    {
        FollowingObject.transform.position = Vector3.MoveTowards(FollowingObject.transform.position, OtherObject.transform.position, speed);
    }
}
