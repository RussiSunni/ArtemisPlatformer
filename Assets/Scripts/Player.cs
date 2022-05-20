using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    //Movement
    public float speed;
    public float jump;
    private bool isJumping = false;

    //Grounded Vars
    bool grounded = true;

    void Update()
    {
        //Left Right Movement
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector2(transform.position.x - 0.03f, transform.position.y);
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector2(transform.position.x + 0.03f, transform.position.y);
        }
       
        else
        {
            transform.position = new Vector2(transform.position.x, transform.position.y);
        }


        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) && !isJumping)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 15f), ForceMode2D.Impulse);
            isJumping = true;
        }



    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground") // GameObject is a type, gameObject is the property
        {
            isJumping = false;
        }
    }
}