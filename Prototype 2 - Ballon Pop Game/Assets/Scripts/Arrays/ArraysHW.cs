using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysHW : MonoBehaviour
{
    //Arrays Homework (10 Arrays)
     public string[] friendNames = {"Bob", "Jessica", "Jody", "Arthur", "Randall", "Todd", "Becky"};
    public int[] numbers = {23,34,56,67,78,97,45,10};
    public string[] makeupBag = {"Mirror", "Lipstick", "Mascara", "Blush", "Foundation", "Concealer", "Brushes", "Powder", "Eyeliner", "Eyeshadow"}; 
    public string[] gameConsoles = {"GameCube", "DreamCast", "GameBoy", "NintendoDS", "PlayStation", "xBox", "PSP"};
    public string[] farmAnimals = {"Cow", "Horse", "Pig", "Sheep", "Chicken", "Turkey", "Goat"};
    public string[] inventory = {"Health Kit", "Shotgun Ammo", "Granade", "Shield"};
    public int[] playerId = {358, 764, 555, 530, 927, 214};
    public string[] favoriteGames = {"Pokemon", "Fire Emblem", "Final Fantasy", "Valorant", "Apex Legends"};
    public string[] destinations = {"Peru", "United States", "Japan", "Mexico", "Croatia"};
    public string[] colors = {"Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet"};
    // Start is called before the first frame update
    void Start()
    {
        /*
        Debug.Log("Former friend"+ friendNames[0]);
        Debug.Log(friendNames[3]+"Says Hi as he walks to class");
        friendNames[0] = "Veronica";
        Debug.Log("New friend"+ friendNames[0]);
        
        Debug.Log("The next destination is"+ destinations[2]);

        Debug.Log("My favorite color is" + colors[5]);
        

        foreach(int numbers in numbers)
        {
            print(numbers);
        }
        */
        
        foreach(string favoriteGames in favoriteGames)
        {
            print(favoriteGames);
        }
    }
}
