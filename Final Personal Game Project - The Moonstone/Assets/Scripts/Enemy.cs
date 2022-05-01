using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
 
public class Enemy : MonoBehaviour 
{ 
        [Header("Enemy Health")] 
    public int health = 1; 
 
    [Header("Enemy Attack")] 
 
    public float attackRange; 
    public int damage; 
    public float attackRate; 
    private float lastAttackTime; 
    public PlayerController player;
 
 
    // Update is called once per frame 
    void Update() 
    { 
        if(Time.time - lastAttackTime >= attackRate && Vector2.Distance(transform.position, player.transform.position) < attackRange) 
        { 
            Attack(); 
        } 
    } 
 
    public void TakeDamage (int damage) 
    { 
        health -= damage; 
 
        if(health <= 0)
        { 
            Die(); 
        } 
 
    } 
    void Attack() 
    { 
        lastAttackTime = Time.time; 
        player.TakeDamage(damage); 
    } 
    void Die() 
    { 
        Destroy(gameObject); 
    } 
}