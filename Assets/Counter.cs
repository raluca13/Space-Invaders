using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Counter : MonoBehaviour
{
    public int alienCount;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (alienCount == 5)
        {
            SceneManager.LoadScene("SpaceShooter");
        }
    }

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (otherCollider.tag == "Alien")
           {
            print(alienCount ++); 
            }

            AddScore();
    }


    void AddScore()
    {
        print(alienCount++);
    }

}



