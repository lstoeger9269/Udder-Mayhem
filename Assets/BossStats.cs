using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossStats : MonoBehaviour
{
    [SerializeField] private float maxHealth;

    private float currentHealth;

    public BossBar bossBar;

    private void Start()
    {
        currentHealth = maxHealth;

        bossBar.SetSliderMax(maxHealth);
    }

    public void TakeDamage(float amount)
    {
        Debug.Log("heeaw");
        currentHealth -= amount;
        bossBar.SetSlider(currentHealth);
    }

    private void Update()
    {
        //if the player presses the "O" key
        if (Input.GetKeyDown(KeyCode.O))
        {
            TakeDamage(5f);
        }
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void Heal(float amount)
    {
        currentHealth += amount;
        bossBar.SetSlider(currentHealth);
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
