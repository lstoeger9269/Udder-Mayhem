using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingItem : MonoBehaviour
{
    public GameObject healPrefab;
    public GameObject Player;
    public float healAmount;
    private System.Random rand = new System.Random();

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

    IEnumerator Respawn (Collider collision, int time)
    {
        yield return new WaitForSeconds (time);
        collision.gameObject.SetActive(true);

    }

    

    //when bacon touches player
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Bacon"))
        {
            StartCoroutine(Respawn(collision,5));
            collision.GetComponent<PlayerStats>().Heal(healAmount);
            collision.gameObject.SetActive(false);

        }
    }


}
