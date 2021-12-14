using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeLeft = 3.0f;
    public Text startText; 
    public Scene loadedlevel;

    void Start()
    {
        

    }
    void Update()
    {
        timeLeft -= Time.deltaTime;
        startText.text = "Time: " + (timeLeft).ToString("0");
        if (timeLeft < 0) 
        {
            Restart();
          
     }

     
    }


    void Restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}