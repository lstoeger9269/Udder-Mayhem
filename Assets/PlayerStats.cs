using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public GameObject Camera;
    public GameObject DeathCam;

    bool dead = false;

    Animator anim;
    [SerializeField] private float maxHealth;

    private float currentHealth;

    public HealthBar healthBar;
    

    public void Start()
    {
        currentHealth = maxHealth;

        healthBar.SetSliderMax(maxHealth);

        anim=gameObject.GetComponent<Animator>();
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        healthBar.SetSlider(currentHealth);
    }

    public void Update()
    {
        //if the player presses the "K" key
        if (Input.GetKeyDown(KeyCode.K))
        {
            TakeDamage(5f);
        }
        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        if(currentHealth <= 0)
        {
            
            Die();
            Debug.Log("player died");
            dead = true;
        }
    }

    public void Heal(float amount)
    {
        currentHealth += amount;
        healthBar.SetSlider(currentHealth);
    }

    public void Die()
    {
        if(dead = true){
            //GetComponent<Emote>().Dead();
        //Emote.Dead();
        }
        Camera.SetActive(false);
        DeathCam.SetActive(true);
    }
}

