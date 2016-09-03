using UnityEngine;
using System.Collections;

public class testShoot : MonoBehaviour {

    public GameObject ProjectilePrefab;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Fire1") > 0)
        {
            var projectile = (GameObject)Instantiate(ProjectilePrefab, gameObject.transform);
            Rigidbody2D projectile2D = projectile.GetComponent<Rigidbody2D>();
            projectile2D.velocity = projectile.transform.right * 20;
            projectile2D.GetComponent<projectile>().dmg = 2;
            projectile2D.GetComponent<projectile>().friendly = true;
        }
    }
	
}
