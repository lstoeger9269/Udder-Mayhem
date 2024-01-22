using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingItem : MonoBehaviour
{
    public GameObject healPrefab;

    public float healAmount;

    void Start()
    {
        //Spawn();
    }

    void Update()
    {
    }

    private void Spawn()
    {
        Instantiate(healPrefab, transform.position, Quaternion.identity);
    }

    //when bacon touches player
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerStats>().Heal(healAmount);
            Destroy(gameObject);

        }
    }


}
