using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{

    public float speed;
    public float stopDistance;
    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectsWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.0istance(transform.position, target.position) > 5)
        {
            transform.position = Vector2.MoveToward(transform.position, speed * Time.deltaTime);
        }
    }
}
