using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed at which the player will move
    private Rigidbody2D rb; // Store the referenced 2D rigidbody
    Vector2 movement; //Store the players x,y position movement

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal"); // Input for left right movement
        movement.y = Input.GetAxis("Vertical"); // Input for Up Down movement
    }

    // Set number of calls per frame

    void FixedUpdate()
    {
        // Apply physics and move the character
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);

    }
}