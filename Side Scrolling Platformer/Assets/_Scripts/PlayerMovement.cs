using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int playerSpeed;
    public float playerJump;
    

    public Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //rb.freezeRotation = true; this is how to make his static, but i enjoy him spinning :D
        //frames per second - 
        //playerMove();

        if (rb.position.x < -1)
        {
            rb.velocity = Vector2.right * playerSpeed;
        }
       

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
            Jump();
        }

       // gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX, 0) * playerSpeed;

        //use mathf.clamp 
        //float newX = mathf.clamp(rb.position.x, -1.95f , +1.95f); change -1.95 and 1.95 to variables get rid of magic numbers
        //have newx value , need to reposition ridig body
        //rb.position = new vector2(newX,rb,potition.y);

    }
    /*void playerMove()
    {
        //controls
        moveX = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
        //animation
        // Physics
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);// allows the player to move left and right
    }*/
    void Jump()
    {
        //jumping
        Debug.Log("Jump");
        rb.velocity = Vector2.up * playerJump;


    }
}
