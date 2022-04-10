using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{
    public string npcConv;

    public int socialClass;

    void Start()
    {
        switch(npcConv)
        {
            case "Hello":
             print("Hello good citizen! May the blessings of the zandar be upon you!");
             break;
            case "Goodbye":
             print("Goodbye! Safe travels to you and to your party!");
             break;
            case "We are being attacked":
             print("You run away in shame, you coward!");
             break;
        }

        switch(socialClass)
        {
            case 5:
            Debug.Log("Hello, Your Magesty!");
            break;
            case 4:
            Debug.Log("Hello Young Princess!");
            break;
            case 3:
            Debug.Log("Good Evening my Lord");
            break;
            case 2:
            Debug.Log("Hello, Mayor!");
            break;
            case 1:
            Debug.Log("May I purchase some of your fine chesses?");
            break;
            case 0:
            Debug.Log("Get away from me your riff raff!");
            break;
            default:
            Debug.Log("I do not talk with stangers!!!!");
            break;
        }
    }
}
