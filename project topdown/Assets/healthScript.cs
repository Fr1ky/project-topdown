using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {

    public int Health;
    public int maxhealth;
    public bool alive;

    SpriteRenderer sprt;

	// Use this for initialization
	void Start () {
        sprt = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void takeDamage(int dmg)
    {
        Health -= dmg;
        sprt.color = Color.red;        
        sprt.color = Color.white;

             }
}
