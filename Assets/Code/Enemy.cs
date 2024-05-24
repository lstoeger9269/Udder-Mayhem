using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Enemy : MonoBehaviour
{

    public int EnemyHealth = 20;
    public GameObject bestharm;
    public GameObject enemyguy;
    public GameObject winScreen;
    public GameObject text;


    Animator anim;

    Rigidbody rb;


    void Start(){
        rb = GetComponent<Rigidbody>();
        winScreen.active = false;
        text.active = false;
    }

    public void TakeDamage(int damageAmount)
    {
        EnemyHealth -= damageAmount;
        anim = gameObject.GetComponent<Animator>();

    }

    // Update is called once per frame
    public void Update()
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
                winScreen.active = true;
                text.active = true;

            }
            
        }

    

    }
}
