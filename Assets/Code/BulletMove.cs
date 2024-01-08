using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{

    public float life = 3;
    Rigidbody rb;
    [SerializeField]float bulletspeed;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        rb.velocity=transform.forward*bulletspeed;

    }
    
    void Awake()
    {
        Destroy(gameObject, life);
    }
    

    private void OnCollisionEnter( Collision collision ) 
    {
        
        if (collision.transform.tag == "Enemy")
        {

            collision.gameObject.GetComponent<Enemy>().TakeDamage(5);
            Destroy(gameObject);

        }
        
        
    }
    
}
