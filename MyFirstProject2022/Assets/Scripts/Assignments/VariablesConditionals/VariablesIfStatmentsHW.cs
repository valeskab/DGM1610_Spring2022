using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesIfStatmentsHW : MonoBehaviour
{

//Homework

public int health;
public float lives = 10f;
public float speed = 100;
public string favFood = "Sushi";
public bool youArehappy = true;

    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        Debug.Log("Health = "+ health);

    }

    // Update is called once per frame
    void Update()
    {
        if (favFood == "Sushi")
        {
            print ("Yum!");
        }
        if (youArehappy == true)
        {
            print("You are happy!!!");
        }
    }   

}
