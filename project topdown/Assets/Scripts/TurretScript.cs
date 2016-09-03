using UnityEngine;
using System.Collections;

public class TurretScript : MonoBehaviour {

    private bool active;
    public bool power;

    public int TurretDmg;
    public float ProjectileSpeed;
    public float rotationSpeed;
    public float shootInterval;

    public GameObject ProjectilePrefab;
    public Transform projectileSpawn;
    public HealthScript hp;

    // Use this for initialization
    void Start () {
        hp = GetComponent<HealthScript>();        
        StartCoroutine(turretShoot());

    }
	
	// Update is called once per frame
	void Update () {
        active = hp.alive;
        if (power == true)  transform.RotateAround(gameObject.transform.position, Vector3.forward, rotationSpeed * Time.deltaTime); 
        else StopAllCoroutines();
        
        if(active == false)
        {

            //Dodaj destroy animacijo!
            Destroy(gameObject);
        }    
    }

    

    IEnumerator turretShoot()
    {
        while (true) {

        yield return new WaitForSeconds(shootInterval);

        var projectile = (GameObject)Instantiate(ProjectilePrefab, projectileSpawn.position, projectileSpawn.rotation);      
        Rigidbody2D projectile2D = projectile.GetComponent<Rigidbody2D>();
        projectile2D.velocity = projectile.transform.right * ProjectileSpeed;
        projectile2D.GetComponent<projectile>().dmg = TurretDmg;
        projectile2D.GetComponent<projectile>().friendly = false;}

    }

    void deactive()
    {

    }
}
