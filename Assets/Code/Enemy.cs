using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Enemy : MonoBehaviour
{

    public int EnemyHealth = 20;
    public GameObject bestharm;
    public GameObject enemyguy;

    Animator anim;

    Rigidbody rb;


    void Start(){
        rb = GetComponent<Rigidbody>();
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
            if(enemyguy.tag == "Enemy"){
                anim.SetTrigger("isDead");
                bestharm.active = true;
                Destroy(gameObject);
            }
            else{
                Destroy(gameObject);
                bestharm.active = true;
            }


        }

    }
}
