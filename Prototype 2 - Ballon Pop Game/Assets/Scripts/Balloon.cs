using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int scoreToGive = 100; // Score give for popped balloon.
    public int clicksToPop = 3; // How many clicks before balloon pops.
    public float scaleToIncrease = 0.10f; //Scale increase each time the ballon is clicked.
    public ScoreManager scoreManager; // A variable to reference the ScoreManager

    // Start is called before the first frame update
    void Start()
    {
        //Reference ScoreManager Component
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    void OnMouseDown()
    {
        //Reduce clicks by one
        clicksToPop -= 1;
        //Increase
        transform.localScale += Vector3.one * scaleToIncrease;

        if(clicksToPop == 0)
        {
            scoreManager.IncreaseScoreText(scoreToGive);
            Destroy(gameObject);
        }
    }
}
