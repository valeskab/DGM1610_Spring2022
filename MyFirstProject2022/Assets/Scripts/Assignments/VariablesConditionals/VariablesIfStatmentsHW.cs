using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesIfStatmentsHW : MonoBehaviour
{

//Homework

public int health;
public int score;
public float speed = 2.5f;
public string favFood = "Sushi";
public bool youArehappy = true;

    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        Debug.Log("Health = "+ health);

        score = 10;
        Debug.Log("Score =" + score);


    }

    // Update is called once per frame
    void Update()
    {
        if (favFood == "Sushi")
        {
            Debug.Log("Yum!");
        }
        if (youArehappy == true)
        {
            Debug.Log("You are happy!!!");
        }
        else if(youArehappy == false)
        {
            Debug.Log("You are sad, feel better soon!");
        }
    }   

}
