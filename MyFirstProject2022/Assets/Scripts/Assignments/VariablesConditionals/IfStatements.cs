using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    // public string lightColor;

    public string weather;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(lightColor == "Red")
        {
            Debug.Log("The light is "+ lightColor +" STOP!!");
        }
        else if(lightColor == "Yellow")
        {
            Debug.Log("The light is "+ lightColor +" start to Stop or Clear the intersection!");
        }
        else if(lightColor == "Green")
        {
            Debug.Log("The light is "+ lightColor +" GOOOOO!");
        }
        else
        {
            Debug.Log("Wrong color!");
        }
        */

        if(weather == Rain)
        {
            Debug.Log("The weather is bad, you should wear a coat!");
        }
    }
}
