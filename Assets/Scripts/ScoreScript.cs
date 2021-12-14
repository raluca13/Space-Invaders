using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreScript : MonoBehaviour
{
    //Creating variable with 0 value.
    public static int scoreValue = 0;

    //Text score variable to connect it with scoretext gameobject.
    Text score;

    
    void Start()
    {
        score = GetComponent<Text>();
    }

    
    void Update()
    {
        score.text = "Score: " + scoreValue;
    }
}
