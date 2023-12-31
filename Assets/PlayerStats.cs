using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private float maxHealth;

    private float currentHealth;

    public HealthBar healthBar;

    private void Start()
    {
        currentHealth = maxHealth;

        healthBar.SetSliderMax(maxHealth);
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        healthBar.SetSlider(currentHealth);
    }

    private void Update()
    {
        //if the player presses the "K" key
        if (Input.GetKeyDown(KeyCode.K))
        {
            TakeDamage(20f);
        }
        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        if(currentHealth <= 0)
        {
            Die();
        }
    }

    public void Heal(float amount)
    {
        currentHealth += amount;
        healthBar.SetSlider(currentHealth);
    }

    private void Die()
    {
        Debug.Log("You died!");
    }

}
