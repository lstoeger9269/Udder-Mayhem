using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class FollowScript2 : MonoBehaviour
{
    public int speed;
    public GameObject player;
    public CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
 
    void Update()
    {
        Vector3 localPosition = player.transform.position - transform.position;
        localPosition = localPosition.normalized; // The normalized direction in LOCAL space
        controller.SimpleMove(player.transform.position);
        transform.LookAt( player.transform.position, Vector3.up );
    }
}