using UnityEngine;

// This script handles controlling the player movement
public class PlayerController2 : MonoBehaviour
{
    // A reference to the Sprite Renderer componenet, holding the player image
    public SpriteRenderer playerImage;

    public float moveSpeed = 5f;

    // Reference to the main camera that we see the game world through
    private Camera mainCamera;

    // Half the width of the player's character image
    private float playerHalfWidth;
    private float playerHalfHeight;

    // The game screen's right and left edges, used to block the player from going outside screen boundaries
    private float rightScreenEdge;
    private float leftScreenEdge;
    private float upScreenEdge;
    private float downScreenEdge;

    private float maxPosX;
    private float minPosX;
    private float maxPosY;
    private float minPosY;

    // Start is called before the first frame update
    void Start()
    {
        // Get the main camera reference from the Camera class
        mainCamera = Camera.main;

       
        playerHalfWidth = playerImage.bounds.size.x * 0.5f;
        playerHalfHeight = playerImage.bounds.size.y * -6f;
    
        rightScreenEdge = mainCamera.ScreenToWorldPoint(new Vector2(mainCamera.pixelWidth, 0)).x;
        upScreenEdge = mainCamera.ScreenToWorldPoint(new Vector2(mainCamera.pixelHeight, 0)).y;
        
        leftScreenEdge = mainCamera.ScreenToWorldPoint(Vector2.zero).x;
        downScreenEdge = mainCamera.ScreenToWorldPoint(Vector2.zero).y;

       
        maxPosX = rightScreenEdge - playerHalfWidth;
        minPosX = leftScreenEdge + playerHalfWidth;
        maxPosY = upScreenEdge - playerHalfHeight;
        minPosY = downScreenEdge + playerHalfHeight;
    }

    // Update is called once per frame
    void Update()
    {
        float inputHl = Input.GetAxis("Horizontal");
        float inputVl = Input.GetAxis("Vertical");
       
        Vector2 currentPos = gameObject.transform.position;

   
        if ((inputHl > 0) && (currentPos.x <= maxPosX))
        {
          
            Vector2 newPos = currentPos + Vector2.right;

            
            gameObject.transform.position = Vector2.MoveTowards(currentPos, newPos, moveSpeed * Time.deltaTime);
        }
       
        else if (inputHl < 0 && (currentPos.x >= minPosX))
        {
            Vector2 newPos = currentPos + Vector2.left;

            gameObject.transform.position = Vector2.MoveTowards(currentPos, newPos, moveSpeed * Time.deltaTime);
        }

        if ((inputVl > 0) && (currentPos.y <= maxPosY))
        {
           
            Vector2 newPos = currentPos + Vector2.up;

           
            gameObject.transform.position = Vector2.MoveTowards(currentPos, newPos, moveSpeed * Time.deltaTime);
        }
        
        else if (inputVl < 0 && (currentPos.y >= minPosY))
        {
            Vector2 newPos = currentPos + Vector2.down;

            gameObject.transform.position = Vector2.MoveTowards(currentPos, newPos, moveSpeed * Time.deltaTime);
        }
    }
}