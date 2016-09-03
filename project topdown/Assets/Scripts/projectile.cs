using UnityEngine;
using System.Collections;

public class projectile : MonoBehaviour
{

    public int dmg;
    public float Lifetime;
    public bool friendly;
    PlayerMaster player;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Bullet" || collision.tag == "Turret")
        {
            return;
        }

        Destroy(gameObject);
        if (collision.tag == "Player" && friendly == false ) {
            collision.GetComponent<PlayerMaster>().curHp -= dmg;   
                  
                     }
    }
}
