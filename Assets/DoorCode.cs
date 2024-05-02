using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCode : MonoBehaviour
{
    public GameObject follower;
    public GameObject icon1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "follower"){
            Destroy(follower);
            Destroy (icon1);
            Debug.Log("follower escaped");
            GetComponent<EnemySpawner>().CowSaved();
        }
    }
}
