using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    public GameObject projectilePrefab;

    private bool isShooting; 

    public AudioSource audio;
    public AudioClip collectSFX;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       if (isShooting == false)
        {
            Shoot();
        }
    }

    // A function automatically triggerred when another game object with Collider2D component
    // Enters the Collider2D boundaries on this game object
    //private void OnTriggerEnter2D(Collider2D otherCollider)
    //{
        // Check the tag on the other game object. If it's the powerUp's tag,
        //  set powerUpCollected boolean on true and destroy the powerUp 
    //    if (otherCollider.tag == "PowerUp")
    //    {
    //        powerUpCollected = true;
    //        audio.PlayOneShot(collectSFX);

    //        //Expects an IEnumerator and starts a coroutine (timed process). 
    //        StartCoroutine(TimerForPowerUp());

    //        // Get the game object, as a whole, that's attached to the Collider2D component
    //        Destroy(otherCollider.gameObject);
    //    }
    //}

    private void Shoot()
    {
        // Set shooting boolean to true, so that enemy is not shooting all the time
        isShooting = true; 

        //Generates a random time after which the enemy will shot
        int randomTime = Random.Range(1, 5);

        //Starts the timer that will trigger the shooting.  
        StartCoroutine(TimerForShooting(randomTime));

    }

    //Sets a timer after which the enemy will shoot based on the pTime variable.  
    private IEnumerator TimerForShooting(int pTime)
    {
        yield return new WaitForSeconds(pTime);

        // Create an instance of the GameObject referenced by the projectilePrefab variable
        // When the instance is created, position at the same location where the enemy currently is (by copying their transform.position),
        // and don't rotate the instance at all - let it keep its "identity" rotation
       
        Instantiate(projectilePrefab, gameObject.transform.position, Quaternion.identity);
        //audio.Play();

        isShooting = false;
    }
}