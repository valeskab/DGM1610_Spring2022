using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{
    public string npcConv;

    public int socialClass;

    public int characterClass;

    public int itemCondition;

    public string npcShopKeeper;

    public int dayOfWeek;

    public string playerName = "Jun";

    public int zodiacSign;

    public int gameDifficulty;

    public string npcBlacksmith;

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

        switch(characterClass)
        {
            case 4:
            Debug.Log("You are now a Bard");
            break;
            case 3:
            Debug.Log("You are now a Warrior");
            break;
            case 2:
            Debug.Log("You are now a Paladin");
            break;
            case 1:
            Debug.Log("You are now a Healer Mage");
            break;
            case 0:
            Debug.Log("You are now a Mage");
            break;
            default:
            Debug.Log("Please choose which class you would like to be");
            break;
        }

        switch(itemCondition)
        {
            case 4:
            Debug.Log("Excellent");
            break;
            case 3:
            Debug.Log("Good");
            break;
            case 2:
            Debug.Log("Fair");
            break;
            case 1:
            Debug.Log("Poor");
            break;
            case 0:
            Debug.Log("Unusable");
            break;
        }
        switch(npcShopKeeper)
        {
            case "Hello":
             print("Welcome, how can I help you");
             break;
            case "Potions":
             print("Take a look at our fine collection of potions with the best price tag in town");
             break;
            case "Goodbye":
             print("Thank you, come again");
             break;
            case "Leaves the shop without buying anything":
             print("You'll regret this!");
             break;
        }
        
        switch(dayOfWeek)
        {
            case 6:
            Debug.Log("Today is Saturday!");
            break;
            case 5:
            Debug.Log("Today is Friday!");
            break;
            case 4:
            Debug.Log("Today is Thursday!");
            break;
            case 3:
            Debug.Log("Today is Wednesday!");
            break;
            case 2:
            Debug.Log("Today is Tuesday!");
            break;
            case 1:
            Debug.Log("Today is Monday!");
            break;
            case 0:
            Debug.Log("Today is Sunday!");
            break;
        }
        switch(playerName)
        {
            case "Jun":
             print("I've heard a lot about you, Its good to see you");
             break;
            case "Bob":
             print("Who the heck are you!?");
             break;
            case "Goodbye":
             print("Take care");
             break;
            default:
             print("What's your name?");
             break;
        }
        switch(zodiacSign)
        {
            case 11:
            Debug.Log("You are a Sagittarius");
            break;
            case 10:
            Debug.Log("You are a Scorpio");
            break;
            case 9:
            Debug.Log("You are a Libra");
            break;
            case 8:
            Debug.Log("You are a Virgo");
            break;
            case 7:
            Debug.Log("You are a Leo");
            break;
            case 6:
            Debug.Log("You are a Cancer");
            break;
            case 5:
            Debug.Log("You are a Gemini");
            break;
            case 4:
            Debug.Log("You are a Taurus");
            break;
            case 3:
            Debug.Log("You are a Aries");
            break;
            case 2:
            Debug.Log("You are a Pisces");
            break;
            case 1:
            Debug.Log("You are a Aquarius");
            break;
            case 0:
            Debug.Log("You are a Capricorn");
            break;
            default:
            Debug.Log("Which is your zodiac sign?");
            break;
        }
        
        switch(gameDifficulty)
        {
            case 3:
            Debug.Log("You are an Expert Player");
            break;
            case 2:
            Debug.Log("You are an Advanced Player");
            break;
            case 1:
            Debug.Log("You are a Intermediate Player");
            break;
            case 0:
            Debug.Log("You are a Begginer player");
            break;
            default:
            Debug.Log("Please choose your difficulty");
            break;
        }

        switch(npcBlacksmith)
        {
            case "Forge":
             print("Let me show you our latest weapon upgrades");
             break;
            case "Purchase Weapons":
             print("These fine beauties will help you slay those monsters out in the wild");
             break;
             case "Purchase Equipment":
             print("Let me show you what we've got available");
             break;
            default:
             print("Traveler! How can I help you?");
             break;
        }
    }
}
