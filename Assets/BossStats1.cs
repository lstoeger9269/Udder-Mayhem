using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossStats1 : MonoBehaviour
{
    [SerializeField] private float maxHealth;

    private float currentHealth;

    public BossBar bossBar;
    
    private void Start()
    {
        
        currentHealth = maxHealth;

        bossBar.SetSliderMax(maxHealth);
    }
    private void OnTriggerEnter(Collider other)
    {
         if (other.CompareTag("Bullet"))
        {
            other.GetComponent<Enemy>().TakeDamage(10);
        }
    }
    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        bossBar.SetSlider(currentHealth);
    }

    private void Update()
    {
        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        if(currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }

    
}
