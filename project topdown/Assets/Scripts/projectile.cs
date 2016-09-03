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
        if((collision.tag == "Bullet" || collision.tag == "Enemy" || collision.tag == "Hazzard" )&&  friendly == false)
        {
            return;
        }

        Destroy(gameObject);
        if (collision.tag == "Player" && friendly == false ) {
            collision.GetComponent<PlayerMaster>().curHp -= dmg;   
                  
                     }

        if (collision.tag == "Enemy" && friendly == true)
        {
            if (collision.GetComponent<HealthScript>().invulnerableFrame == false)
            {
                collision.GetComponent<HealthScript>().SendMessage("takeDamage", dmg);

            }
            else Destroy(gameObject);         
            
        }
    }
}
