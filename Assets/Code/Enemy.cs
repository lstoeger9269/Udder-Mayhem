using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Enemy : MonoBehaviour
{

    public int EnemyHealth = 20;
    public GameObject bestharm;



    public void TakeDamage(int damageAmount)
    {
        EnemyHealth -= damageAmount;

    }

    // Update is called once per frame
    void Update()
    {

        bestharm.active = false;
        
        if (EnemyHealth <= 0)
        {
            if (gameObject.CompareTag("ButcherBoss")){
                gameObject.GetComponent<BossStats1>().TakeDamage(5);
            }
            else{
                Destroy(gameObject);
                bestharm.active = true;
            }
            
        }

    }
}
