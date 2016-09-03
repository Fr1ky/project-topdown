using UnityEngine;
using System.Collections;

public class TurretScript : MonoBehaviour {

    public int TurretDmg;
    public float ProjectileSpeed;
    public GameObject ProjectilePrefab;
    public Transform projectileSpawn;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        var projectile = (GameObject)Instantiate(ProjectilePrefab, projectileSpawn.position, projectileSpawn.rotation);      
        Rigidbody2D projectile2D = projectile.GetComponent<Rigidbody2D>();
        projectile2D.velocity = projectile.transform.right * 15;

    }
}
