using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBehaviour : MonoBehaviour
{
    // How fast will the power up will fall
    public float speed;

    // How much time, in seconds, before the power up destroys itself (if it hits nothing and escapes the play area)
    public float destroyAfter = 2f;

    // Start is called before the first frame update
    void Start()
    {
        // Call the DestroyPowerUp function (note its written as string, this is how Invoke takes its parameter)
        // after a specific amount of time (seconds) set by the destroyAfter variable
        Invoke("DestroyPowerUp", destroyAfter);
    }

    // Update is called once per frame
    void Update()
    {
        // As soon as the power up is instantiated in the game scene, transform.Translate will start
        // moving it up one unit, multiplied by the speed and Time.deltaTime for cpu optimisation
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    void DestroyPowerUp()
    {
        // Destroy the game object this script is on (the power up game object)
        Destroy(gameObject);

    }
}