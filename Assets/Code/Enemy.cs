using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    [SerializeField] private UnityEvent onUpdate = null;

    public int EnemyHealth = 20;

    public void TakeDamage(int damageAmount)
    {
        EnemyHealth -= damageAmount;

    }

    // Update is called once per frame
    void Update()
    {
        
        if (EnemyHealth <= 0)
        {
            onUpdate?.Invoke();
            Destroy(gameObject);

        }

    }
}
