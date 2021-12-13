using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script controls the behaviour of each single Alien enemy
public class EnemyBehaviour : MonoBehaviour
{
    //Enemy number of hits needed to be destroyed
    public int numberOfHits = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	// A function automatically triggerred when another game object with Collider2D component
	// Enters the Collider2D boundaries on this game object
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
		// Check the tag on the other game object. If it's the projectile's tag,
		//  destroy both this game object and the projectile
        if (otherCollider.tag == "Projectile")
        {
            numberOfHits--;
            if (numberOfHits == 0)
            {
                Destroy(gameObject);

               
            }
            
            // Get the game object, as a whole, that's attached to the Collider2D component
            Destroy(otherCollider.gameObject);
        }
    }
}
