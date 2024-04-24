using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMoveBoss : MonoBehaviour
{

    public float life = 3;
    public float TakeDamage;
    Rigidbody rb;
    [SerializeField]float bulletspeed;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        rb.velocity=transform.forward*bulletspeed;

    }
    
    
    

    private void OnCollisionEnter( Collision collision ) 
    {
        
        if (collision.transform.tag == "ButcherBoss")
        {

            collision.gameObject.GetComponent<Enemy>().TakeDamage(5);
            Destroy(gameObject);

        }
        
        
    }
    
}