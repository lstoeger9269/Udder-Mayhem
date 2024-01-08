using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingItem : MonoBehaviour
{
    public GameObject healPrefab;

    public float healAmount;

    int spawnnum = 0;
    int spawnnum2 = 2;

    void Start()
    {

    }

    void Update()
    {
        if(spawnnum2 == spawnnum + 2)
        {
            Spawn();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerStats>().Heal(healAmount);
            Destroy(gameObject);
            spawnnum += 1;
            spawnnum2 += 2;
        }
    }

    private void Spawn()
    {
        Instantiate(healPrefab, transform.position, Quaternion.identity);
        spawnnum += 1;
    }
}
