using UnityEngine;
using System.Collections;

public class TurretScript : MonoBehaviour {

    private bool active;
    public bool power;

    public float rotationSpeed;

    public HealthScript hp;
    public enemyShoot shoot;

    // Use this for initialization
    void Start () {
        hp = GetComponent<HealthScript>();
        shoot = GetComponent<enemyShoot>();
           
    }
	
	// Update is called once per frame
	void Update () {
        if (active && power && shoot.isShooting == false)
        {
            shoot.isShooting = true;
            shoot.StartCoroutine(shoot.Shoot());
        }
        active = hp.alive;
        if (power) transform.RotateAround(gameObject.transform.position, Vector3.forward, rotationSpeed * Time.deltaTime);
        else shoot.stopShooting();
                         
        if(!active)
        {
            //Dodaj destroy animacijo!
            Destroy(gameObject);
        }
    }

    void deactive()
    {

    }
}
