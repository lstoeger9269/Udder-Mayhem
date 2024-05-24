using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    private AudioSource source;
    [SerializeField]GameObject bulletPrefab;
    [SerializeField]Transform bulletSpawnpos;
    [SerializeField]GameObject BulletIcon;
    [SerializeField]GameObject BulletIcon1;
    [SerializeField]GameObject BulletIcon2;
    [SerializeField]GameObject BulletIcon3;
    [SerializeField]GameObject BulletIcon4;
    public float NextTimeToFire = 0;
    public ParticleSystem muzzleFlash;
    public float ammo;
    public bool reloading;
    

    // Start is called before the first frame update
    void Start()
    {
        reloading = false;
        source = GetComponent<AudioSource>();
        ammo = 5;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ammo > 0 )
        {
            if (Input.GetButtonDown("Fire1") && Time.time >= NextTimeToFire && Equip2.holdingGun == true && reloading == false)
            {
                
                if (ammo == 5)
                {
                    BulletIcon4.active = false;
                }
                if (ammo == 4)
                {
                    BulletIcon3.active = false;
                }
                if (ammo == 3)
                {
                    BulletIcon2.active = false;
                }
                if (ammo == 2)
                {
                    BulletIcon1.active = false;
                }
                if (ammo == 1)
                {
                    BulletIcon.active = false;
                }
                
                NextTimeToFire = Time.time + 0.5f;
                muzzleFlash.Play();
                Instantiate(bulletPrefab,bulletSpawnpos.position,bulletSpawnpos.rotation);
                source.Play();
                print(ammo);
                ammo--;
                
            

            }
        }
        else if (ammo == 0 && reloading == false)
        {

            StartCoroutine (Reload());
            
            
        }
        
    }

    public IEnumerator Reload()
    {

        reloading = true;
        yield return new WaitForSeconds(3);
        BulletIcon.active = true;
        BulletIcon1.active = true;
        BulletIcon2.active = true;
        BulletIcon3.active = true;
        BulletIcon4.active = true;
        ammo = 5;
        reloading = false;
        

    }
}
