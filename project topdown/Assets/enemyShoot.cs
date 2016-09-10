using UnityEngine;
using System.Collections;

public class enemyShoot : MonoBehaviour {

    public int enemyDmg;
    public float ProjectileSpeed;
    public float shootInterval;

    public bool isShooting = false;

    public GameObject ProjectilePrefab;
    public Transform projectileSpawn;

    public void stopShooting()
    {
        Debug.Log("Gets called");
        StopAllCoroutines();
    }

   public IEnumerator Shoot()
    {
        while (isShooting)
        {
            yield return new WaitForSeconds(shootInterval);

            var projectile = (GameObject)Instantiate(ProjectilePrefab, projectileSpawn.position, projectileSpawn.rotation);
            Rigidbody2D projectile2D = projectile.GetComponent<Rigidbody2D>();
            projectile2D.velocity = projectile.transform.right * ProjectileSpeed;
            projectile2D.GetComponent<projectile>().dmg = enemyDmg;
            projectile2D.GetComponent<projectile>().friendly = false;
        }
        

    }
}
