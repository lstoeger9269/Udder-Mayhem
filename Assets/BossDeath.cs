using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossDeath : MonoBehaviour
{
    [SerializeField] private float maxHealth;

    private float currentHealth;
    public BossBar bossBar;
    private void Start()
    {
        currentHealth = maxHealth;

        bossBar.SetSliderMax(maxHealth);
    }

    void TakeDamage(){
        currentHealth -= 5;
        bossBar.SetSlider(currentHealth);
    }

    // Update is called once per frame
    void Update()
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

        private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bullet"))
        {
            TakeDamage();
        }
    }

    void Die(){
        Debug.Log("boss died");
    }
}
