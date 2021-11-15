using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public SpriteRenderer playerImage;
    public float moveSpeed = 5;

    private Camera mainCamera;
    private float playerHalfWidth;
    private float rightScreenEdge;
    private float leftScreenEdge;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        playerHalfWidth = playerImage.bounds.size.x * 0.5f;
        rightScreenEdge = mainCamera.ScreenToWorldPoint(new Vector2(mainCamera.pixelWidth, 0)).x;
        leftScreenEdge = mainCamera.ScreenToWorldPoint(Vector2.zero).x;
    }

    // Update is called once per frame
    void Update()
    {
        float inputHl = Input.GetAxis("Horizontal");
        Vector2 currentPosition = transform.position;

        //float maxPosX = rightScreenEdge - playerHalfWidth;    // TO SHOW REFACTORING OF BELOW, THEN MOVE IT TO START AS CALCULATED VALUE IS STATIC
        if (inputHl > 0 && currentPosition.x < (rightScreenEdge - playerHalfWidth))
        {
            Vector2 newPosition = currentPosition + Vector2.right;

            transform.position = Vector2.MoveTowards(currentPosition, newPosition, moveSpeed * Time.deltaTime);
        }

        if (inputHl < 0 && currentPosition.x > (leftScreenEdge + playerHalfWidth))
        {
            Vector2 newPosition = currentPosition + Vector2.left;

            transform.position = Vector2.MoveTowards(currentPosition, newPosition, moveSpeed * Time.deltaTime);
        }
    }
}
