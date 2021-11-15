using System.Collections;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject[] enemies;
    public float minPosX;
    public float maxPosX;
    public float moveDistance;
    public float timeStep;
    private bool isMovingRight = true;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("MoveEnemies", timeStep, timeStep);
    }

    void MoveEnemies()
    {
        if (isMovingRight)
        {
            float newPositionX = transform.position.x + moveDistance;
            transform.position = new Vector2(newPositionX, transform.position.y);
            
            if (newPositionX >= maxPosX)
            {
                isMovingRight = false;
            }
        } 
        else
        {
            float newPositionX = transform.position.x - moveDistance;
            transform.position = new Vector2(newPositionX, transform.position.y);

            if (newPositionX <= minPosX)
            {
                isMovingRight = true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}