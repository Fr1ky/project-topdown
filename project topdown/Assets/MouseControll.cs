using UnityEngine;
using System.Collections;

public class MouseControll : MonoBehaviour
{
    Vector3 mousePos;
    public Camera _camera;
    Rigidbody2D body2d;
    public GameObject gun;

    // Use this for initialization
    void Start()
    {
        body2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        mousePos = Input.mousePosition;
        mousePos = _camera.ScreenToWorldPoint(mousePos);
        Vector2 pos = mousePos - gameObject.transform.position;

        if (Input.mousePosition.x > (Screen.width / 2))
        {
            gameObject.transform.localScale = new Vector3(1, 1, 1);


            float fi = Mathf.Atan(pos.y / pos.x) * Mathf.Rad2Deg;
            Vector3 rotationVector = new Vector3(0f, 0f, fi);
            gun.transform.rotation = Quaternion.Euler(rotationVector);
        }
        else if (Input.mousePosition.x < (Screen.width / 2))
        {
            gameObject.transform.localScale = new Vector3(-1, 1, 1);

            float fi = Mathf.Atan(pos.y / pos.x) * Mathf.Rad2Deg;
            Vector3 rotationVector = new Vector3(0, 0, fi);
            gun.transform.rotation = Quaternion.Euler(rotationVector);
        }
    }
}