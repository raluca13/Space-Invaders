using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// This script controls the behaviour of each single Alien enemy
public class EnemyBehaviour : MonoBehaviour
{
    public int hp = 120;
    public Sprite enemy1;
    public Sprite enemy2;
    public Sprite enemy3;
    public float timeLeft = 3.0f;

    private AudioSource mAudioSrc;
    private static int alienCount = 0;
   
    int damage = 30;
 
  
    // Start is called before the first frame update
    void Start()
    {
        alienCount++;
        mAudioSrc = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hp == 90)
        { gameObject.GetComponent<SpriteRenderer>().sprite = enemy1;
         
        }

        if (hp == 60)
        { gameObject.GetComponent<SpriteRenderer>().sprite = enemy2;
         
        }

        if (hp == 30)
        { gameObject.GetComponent<SpriteRenderer>().sprite = enemy3;
         
        }

        timeLeft -= Time.deltaTime;
        if (timeLeft == 0)
        {
            Restart();

        }
    }

    void OnDestroy()
    {
        print(alienCount --);

        if (alienCount == 0 && timeLeft > 0)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }

    void Restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }



    // A function automatically triggerred when another game object with Collider2D component
    // Enters the Collider2D boundaries on this game object
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (hp == 0)
        {
            Destroy(gameObject);
            // print(alienCount++);  
           
        }

       
        // Check the tag on the other game object. If it's the projectile's tag,
        //  destroy both this game object and the projectile
        if (otherCollider.tag == "Projectile")
        {

            hp -= damage;

            // Get the game object, as a whole, that's attached to the Collider2D component
            Destroy(otherCollider.gameObject);
            mAudioSrc.Play();
        } 
        
     

    }

  
}
