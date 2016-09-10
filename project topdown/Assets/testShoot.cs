using UnityEngine;
using System.Collections;

public class testShoot : MonoBehaviour
{

    public GameObject ProjectilePrefab;
    public Transform projectileSpawn;
    public float fireRate;
    public float counter;
    public int wpndmg;

    public int gunType;

    public int projectileSpeed;

   public bool canShoot = false;

    bool direction;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        shootTimer();
        checkDirection();
    

        if (Input.GetAxis("Fire1") > 0 && canShoot)
        {
            if(gunType == 1)
            {
                ShootRifle();
            }
            else if(gunType == 2)
            {
                ShootShotgun();
            }
            else if(gunType == 3)
            {
                beamLaser();
            }
            canShoot = false;
        }
    }

    void ShootRifle()
    {
        float flipRotation = 0;

        if (!direction) flipRotation = 180;


        Quaternion quaterninonRotation = projectileSpawn.rotation;
        quaterninonRotation *= Quaternion.Euler(0, 0, flipRotation);

        var projectile = (GameObject)Instantiate(ProjectilePrefab, projectileSpawn.position, quaterninonRotation);
        Rigidbody2D projectile2D = projectile.GetComponent<Rigidbody2D>();
        projectile2D.velocity = projectile.transform.right * projectileSpeed;
        projectile2D.GetComponent<projectile>().dmg = wpndmg;
        projectile2D.GetComponent<projectile>().friendly = true;
    }

    void ShootShotgun()
    {
        float flipRotation = 0;
        if (!direction) flipRotation = 180;

        float rotation = -30;
        for (int i = 0; i < 3; i++)
        {
            Quaternion quaterninonRotation = projectileSpawn.rotation;
            quaterninonRotation *= Quaternion.Euler(0, 0, rotation + flipRotation);

            var projectile = (GameObject)Instantiate(ProjectilePrefab, projectileSpawn.position, quaterninonRotation);
            Rigidbody2D projectile2D = projectile.GetComponent<Rigidbody2D>();
            projectile2D.velocity = projectile.transform.right * projectileSpeed;
            projectile2D.GetComponent<projectile>().dmg = wpndmg;
            projectile2D.GetComponent<projectile>().friendly = true;

            rotation += 30;            
            
        }
    }

    void beamLaser() //maybe later aligater
    {

    }

    void shootTimer()
    {
        if (canShoot) return;


        float a = 1 / fireRate;
        counter += Time.deltaTime;
        if (counter >= a)
        {
            counter = 0;
            canShoot = true;
        }
    }

    void checkDirection()
    {
        if (gameObject.transform.localScale == new Vector3(1, 1, 1))
        {
            direction = true;
        }
        else direction = false;
    }
}
