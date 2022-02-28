using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] balloonPrefabs;
    public float startDelay = 0.5f;
    public float spawnInterval = 1.5f;

    //public int ballonIndex;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBallon", startDelay, spawnInterval);
    }

    void SpawnRandomBalloon()
    {
        // Get a random position on the x-axis
        Vector3 spawnPos = new Vector3(Random.Range(-5,5),10,0);
        // Pick a random ballon from the balloon array
        int ballonIndex = Random.Range(0,balloonPrefabs.Length);
        // Spawn random ballon at spawn position
        Instantiate(balloonPrefabs[ballonIndex], spawnPos, balloonPrefabs[ballonIndex].transform.rotation);
    }
}
