using UnityEngine;
using System.Collections;

public class projectile : MonoBehaviour
{

    public int dmg;
    public float Lifetime;
    public bool friendly;
    PlayerMaster player;
    private float timer;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if((collision.tag == "Bullet" || collision.tag == "Enemy" || collision.tag == "Hazzard" )&&  friendly == false) return;  //returs if enemies shoot each other                       
        if (collision.tag == "Player" && friendly == true) return; //returns if players shoot each other

        Destroy(gameObject);
        //substracts player hp in case of collision
        if (collision.tag == "Player" && friendly == false ) {
            collision.GetComponent<PlayerMaster>().curHp -= dmg;   
                  
                     }
        //hurts the enemy 
        if (collision.tag == "Enemy" && friendly == true)
        {
            if (collision.GetComponent<HealthScript>().invulnerableFrame == false)
            {
                collision.GetComponent<HealthScript>().SendMessage("takeDamage", dmg);

            }
            else Destroy(gameObject);         
            
        }
    }

    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= Lifetime)
        {
            Destroy(gameObject);
        }
    }
}
