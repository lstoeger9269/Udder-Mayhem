using UnityEngine;

public class Gun2 : MonoBehaviour
{
    public int damage = 3;
    public float range = 100f;
    public ParticleSystem muzzleFlash;
    public ParticleSystem BulletImpactStoneEffect;

    public Camera FPSCam;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }


    }
    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(FPSCam.transform.position, FPSCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            muzzleFlash.Play();
            
            if (hit.collider.CompareTag("Enemy"))
            {
                BulletImpactStoneEffect.Play();
                hit.collider.GetComponent<Enemy>().TakeDamage(damage);
            }
        }


    }
}