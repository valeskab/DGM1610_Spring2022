using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public enum Pickuptype {Key, Coins, Medkit};
    public Pickuptype currentPickup;

    public int pickupAmount;
    
    private PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            if(currentPickup == Pickuptype.Key)
            {
                playerController.key = pickupAmount;

                Debug.Log("You have picked up a Golden Key!");
            }
            else if(currentPickup == Pickuptype.Coins)
            {
                playerController.coins += pickupAmount;
                Debug.Log("You have picked up" + pickupAmount + "Coins");
            }
            Destroy(gameObject);
        }
    }

  
}
