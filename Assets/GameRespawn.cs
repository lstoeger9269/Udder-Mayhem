using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRespawn : MonoBehaviour
{
    public float PlayerHealth = GameObject.GetComponent<PlayerStats>(currentHealth);
    string currentSceneName = SceneManager.GetActiveScene().name;
    
    // Update is called once per frame
    void FixedUpdate()
    {
        if(PlayerHealth <= 0){
            SceneManager.LoadScene(currentSceneName);
        }
    }
}
