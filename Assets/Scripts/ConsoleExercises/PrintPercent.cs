using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintPercent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Exercise 5:
        const int MAXSCORE = 100;
        int score = 60;
        float percent =  score / (float)MAXSCORE;
        Debug.Log(percent);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
