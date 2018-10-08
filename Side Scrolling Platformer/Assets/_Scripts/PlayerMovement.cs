using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    public int playerSpeed = 10;
    public int playerJump = 1250;
    private float moveX = 0;


    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //frames per second - 
        playerMove();

        //use mathf.clamp 
        //float newX = mathf.clamp(rb.position.x, -1.95f , +1.95f); change -1.95 and 1.95 to variables get rid of magic numbers
        //have newx value , need to reposition ridig body
        //rb.position = new vector2(newX,rb,potition.y);

    }
    void playerMove()
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
    }
    void Jump()
    {
        //jumping
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJump);


    }
}
