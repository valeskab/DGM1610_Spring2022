using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    //Arrays Class Lesson Sample
    public string[] friendNames = {"Bob", "Jessica", "Jody", "Arthur", "Randall", "Todd", "Becky"};
    public int[] numbers = {23,34,56,67,78,97,45,10};
    //                            { 0, 1, 2, 3, 4, 5, 6}

    // Start is called before the first frame update
    void Start()
    {
        /*
        Debug.Log("Former friend"+ friendNames[0]);
        Debug.Log(friendNames[3]+"Says Hi as he walks to class");
        friendNames[0] = "Veronica";
        Debug.Log("New friend"+ friendNames[0]);
        */
        foreach(int numbers in numbers)
        {
            print(numbers);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
