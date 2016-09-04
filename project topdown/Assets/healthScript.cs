using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {

    public int Health;
    public int maxhealth;
    public bool alive;
    public bool invulnerableFrame = false;

   SpriteRenderer sprt;

	// Use this for initialization
	void Start () {
        sprt = GetComponent<SpriteRenderer>();
	}

    void Update()
    {
        if(Health <= 0)
        {
            alive = false;
        }
    }

    void takeDamage(int dmg)
    {
        invulnerableFrame = true;
        Health -= dmg;

        StartCoroutine(dmgFlash());

        }            
    IEnumerator dmgFlash()
    {
        sprt.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        sprt.color = Color.white;
        yield return new WaitForSeconds(0.1f);
        sprt.color = Color.red;
        yield return new WaitForSeconds(0.05f);
        sprt.color = Color.white;
        yield return new WaitForSeconds(0.05f);
        sprt.color = Color.red;
        yield return new WaitForSeconds(0.05f);
        sprt.color = Color.white;
        invulnerableFrame = false;
    }


     }
