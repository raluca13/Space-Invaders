using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonscript : MonoBehaviour
{
    public void skipLevelScene()
    {
        //When the function above is called go to the main scene
        SceneManager.LoadScene("spaceinv");
    }
}