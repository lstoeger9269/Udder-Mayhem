using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class NewFollowing : MonoBehaviour
{
    public int speed;
    public GameObject player;
 
    void Update()
    {
        Vector3 localPosition = player.transform.position - transform.position;
        localPosition = localPosition.normalized; // The normalized direction in LOCAL space
        transform.position = Vector3.MoveTowards( transform.position, player.transform.position, speed * Time.deltaTime );
        transform.LookAt( player.transform.position, Vector3.up );
    }
}