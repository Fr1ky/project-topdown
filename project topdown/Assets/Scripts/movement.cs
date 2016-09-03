using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {


    Rigidbody2D body2d;
    public float movementSpeed;

    public bool inpit;
    public Transform groundCheck; //where do i look for ground
    public float groundCheckRadius; //how far around the groundcheck do i look for ground
    public LayerMask whatIsHazard; // what is ground


	// Use this for initialization
	void Start () {
        body2d = GetComponent<Rigidbody2D>();
	}


    void FixedUpdate()
    {

        inpit = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsHazard);
        if (inpit == true)
        {

            Debug.Log("You fell");

        }
    }




    // Update is called once per frame
    void Update () {
       
        movementHandle();

    }
    //handles the movement
    void movementHandle()
    {
        body2d.velocity = new Vector2(Mathf.Lerp(0, Input.GetAxis("Horizontal") * movementSpeed* Time.deltaTime, 0.8f),
                                        Mathf.Lerp(0, Input.GetAxis("Vertical") * movementSpeed*Time.deltaTime, 0.8f));
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(this.groundCheck.transform.position, this.groundCheckRadius);
    }
}
