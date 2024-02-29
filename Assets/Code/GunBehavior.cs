using UnityEngine;

public class GunBehavior : MonoBehaviour
{
    //Gun stats
    public int damage;
    public float timeBetweenShooting, spread, range, reloadTime, timeBetweenShots;
    public int magazineSize, bulletsPerTap;
    public bool allowButonHold;
    int bulletsLeft, bulletsShot;

    bool shooting, readyToShoot, reloading;

    //Reference
    public Camera Camera;
    public Transform attackPoint;
    public RaycastHit rayHit;
    public LayerMask whatIsEnemy;

    private void Awake()
    {
        bulletsLeft = magazineSize;
        readyToShoot = true;

    }

    private void Update()
    {
        MyInput();
    }

    private void MyInput()
    {
        if (allowButonHold) shooting = Input.GetKey(KeyCode.Mouse0);
        else shooting = Input.GetKeyDown(KeyCode.Mouse0);
        
        if (Input.GetKeyDown(KeyCode.R) && bulletsLeft < magazineSize && !reloading) Reload();


        if (readyToShoot && shooting && reloading && bulletsLeft > 0)
        {
            bulletsShot = bulletsPerTap;
            Shoot();
        }

    }

    private void Shoot()
    {
        readyToShoot = false;

        //Spread
        float x = Random.Range(-spread, spread);
        float y = Random.Range(-spread, spread);

        //Calculate Direction with Spread
        Vector3 direction = Camera.transform.forward + new Vector3(x,y,0);

        //RayCast
        //if (Physics.Raycast(Camera.transform.position, Camera.transform.forward, direction, out rayHit, range, whatIsEnemy))
        //{
            //Debug.Log(rayHit.collider.name);

            //if (rayHit.collider.CompareTag("Enemy"))
            //{
                //rayHit.collider.GetComponent<ShootingAi>().TakeDamage(damage);
            //}
        //}

        bulletsLeft--;
        bulletsShot--;

        Invoke("ResetShot", timeBetweenShooting);

        if(bulletsShot > 0 && bulletsLeft > 0)
        {
            Invoke("Shoot", timeBetweenShots);
        }

    }

    private void ResetShot()
    {
        readyToShoot = true;
    }

    private void Reload() 
    {
        reloading = true;
        Invoke("ReloadFinished", reloadTime);

    }

    private void ReloadFinished()
    {
        bulletsLeft = magazineSize;
        reloading = false;
    }



}
