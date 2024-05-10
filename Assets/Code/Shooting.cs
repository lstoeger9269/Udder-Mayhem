using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    private AudioSource source;
    [SerializeField]GameObject bulletPrefab;
    [SerializeField]Transform bulletSpawnpos;
    public float NextTimeToFire = 0;
    public ParticleSystem muzzleFlash;
    public float ammo;
    

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ammo > 0)
        {
            if (Input.GetButtonDown("Fire1") && Time.time >= NextTimeToFire && Equip2.holdingGun == true)
            {

                ammo--;
                NextTimeToFire = Time.time + 0.5f;
                muzzleFlash.Play();
                Instantiate(bulletPrefab,bulletSpawnpos.position,bulletSpawnpos.rotation);
                source.Play();
            

            }
        }
        else
        {
            Invoke ("Reload", 3);
        }
        
    }

    public void Reload()
    {
        ammo = 7;

    }
}
