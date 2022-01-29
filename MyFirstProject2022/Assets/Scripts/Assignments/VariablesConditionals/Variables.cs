using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    // Public = Global Variables
public int money; //Whole number value 2, 14, 57, -92, -101
public float change = 0.75f; // Floating point number or decimal 3.15, 105.34, -299.87
public bool isDay = true; //Booleans are true or false
public string loginName = "Bob2345"; // String are alpha numeric text contained it quotation marks

//Homework

public int health;
public float lives = 10f;
public float speed;



    // Start is called before the first frame update
    void Start()
    {
        money = 125;
        Debug.Log("Money in account = "+ money);

    }

    // Update is called once per frame
    void Update()
    {
        if(loginName == "Bob2345")
        {
            print("You have logged in");
        }
        else
        {
            Debug.Log("Invalid Login name");
        }
         if(change <= 1.00f)
        {
        print("You do not have enough money!");
        }
        else if(change > 1.01f)
        {
            Debug.Log("You have made a purchase");
        }
        if(isDay == true)
        {
            print("It is Day!");
        }
        else if(isDay == false)
        {
            Debug.Log("It is night time");
        }
    }
}
