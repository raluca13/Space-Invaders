using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public GameObject creditScreen; 

    public void GetToMenuButton()
    {
        SceneManager.LoadScene(0);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void OpenCredit()
    {
        creditScreen.SetActive(true);
    }

    public void CloseCredit()
    {
        creditScreen.SetActive(false);
    }
}