using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    [Header("PlayerStats")]
    public float speed;
    public float jumpHeight;
    private Rigidbody2D rb;

    [Header("GroundCheck")]
    private bool isGrounded;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private float moveVelocity;

    // Start is called before the first frame update
    void Start()
    {
        isGrounded = true;
        rb = GetComponent<Rigidbody2D>(); //Loading the rigidbody
    }

    void Update() // I was having problems jumping with fixed update, once I put everything back into update my jump became smooth so im leaving it here.
    {
        //Ground check sensor, This is going to make the radius go in a circle to check if the player is touching the ground.
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround); 
        
        // Non-stick Player
        moveVelocity = 0f;

        if(Input.GetKey(KeyCode.D))
        {
            moveVelocity = speed;
        }

        if(Input.GetKey(KeyCode.A))
        {
            moveVelocity = -speed;
        }

        // Move player left and right
        rb.velocity = new Vector2(moveVelocity, rb.velocity.y);

        //Get key down only registers it once, get key would only go down permanently
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }

    public void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
    }
}
