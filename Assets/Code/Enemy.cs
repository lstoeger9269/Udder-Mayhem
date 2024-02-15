using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Enemy : MonoBehaviour
{

    public int EnemyHealth = 20;
    public GameObject harmonicadrop;


    public void TakeDamage(int damageAmount)
    {
        EnemyHealth -= damageAmount;

    }

    // Update is called once per frame
    void Update()
    {
        harmonicadrop.SetActive(false);

        
        if (EnemyHealth <= 0)
        {
            Destroy(gameObject);
            harmonicadrop.SetActive(true);
        }

    }
}
