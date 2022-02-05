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
        if(health <= 0 )
        {
            Debug.Log("Game Over");
        }


        if(score >= 0)
        {
            Debug.Log("Level 1");
        }
        else if (score > 10)
        {
            Debug.Log("Level 2");
        }


        if(speed <= 0.00f)
        {
        print("you have stopped");
        }
        else if(speed > 0.01f)
        {
            Debug.Log("accelerating");
        }


        if (favFood == "Sushi")
        {
            Debug.Log("Yum!");
        }
        else
        {
            Debug.Log("Wrong!");
        }


        if (youArehappy == true)
        {
            Debug.Log("You are happy!!!");
        }
        else
        {
            Debug.Log("You are sad, feel better soon!");
        }
    }   

}
