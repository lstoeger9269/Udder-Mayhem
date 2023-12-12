using UnityEngine;

public class BulletMove : MonoBehaviour
{

    Rigidbody rb;
    [SerializeField]float bulletspeed;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        rb.velocity=transform.forward*bulletspeed;
    }

    void OnCollisionEnter(Collision col)
    {
        Destroy(gameObject);
    }
    
}
