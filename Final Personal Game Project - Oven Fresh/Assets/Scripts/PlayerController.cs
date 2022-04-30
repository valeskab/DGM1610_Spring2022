using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
     [Header ("Player Health")]
    public int curHP;
    public int maxHP;

    public HealthBar healthBar;
    
    [Header ("Player Combat")]

    public int damage; // Damage ammount dealt to enemy
    public float attackRange; // Range at which the player can attack
    public float attackRate;
    private float lastAttackTime;
    public LayerMask enemyLayer;
     private Vector2 direction;


    [Header("PlayerStats")]
    public float speed;
    public float jumpHeight;
    private Rigidbody2D rb;

     [Header("Inventory")]
    public int key;
    public int coins;

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

    void Update()
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

    
    void Attack()
    {
        lastAttackTime = Time.time;
        // Raycast using the enemyLayer

        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, attackRange, enemyLayer);

        if(hit.collider != null)
        {
            hit.collider.GetComponent<Enemy>()?.TakeDamage(damage);
        }

    }
    public void TakeDamage(int damage)
    {
        curHP -= damage;
        //Updates the health bar using current Health
        healthBar.SetHealth(curHP);

        if(curHP <= 0)
        {
            Die();
        }

    }
     void Die()
        {
            Debug.Log("Player has been defeated!");
        }
}