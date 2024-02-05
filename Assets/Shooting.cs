using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    private AudioSource source;
    [SerializeField]GameObject bulletPrefab;
    [SerializeField]Transform bulletSpawnpos;
    public float NextTimeToFire = 0;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time >= NextTimeToFire)
        {

            NextTimeToFire = Time.time + 0.5f;
            Instantiate(bulletPrefab,bulletSpawnpos.position,bulletSpawnpos.rotation);
            source.Play();

        }
    }
}
