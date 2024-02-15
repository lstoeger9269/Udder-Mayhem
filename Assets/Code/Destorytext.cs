using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destorytext : MonoBehaviour
{

    [SerializeField] private float secondstodestroy = 1f;
    public float pickUpRange;
    public GameObject text1;
    public GameObject text2;
    public Transform player;

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 distanceToPlayer = player.position - text1.position || text2.position;

        if (Input.GetKeyDown("g") && distanceToPlayer.magnitude <= pickUpRange ){
            Destroy(text1, secondstodestroy);
        }

        else if(Input.GetKeyDown("f") && distanceToPlayer.magnitude <= pickUpRange){
            Destroy(text2, secondstodestroy);
        }
    }
}
