using UnityEngine;
using UnityEngine.InputSystem;

// Slides the player bar left and right, and reports every block it touches.
// Attach this to the Player object.
public class PlayerController : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] float moveSpeed = 10f;   // units per second
    [SerializeField] float edge = 8.3f;       // how far left and right the bar can go

    void Update()
    {
        float direction = 0f;

        if (Keyboard.current.leftArrowKey.isPressed || Keyboard.current.aKey.isPressed)
        {
            direction = -1f;
        }
        if (Keyboard.current.rightArrowKey.isPressed || Keyboard.current.dKey.isPressed)
        {
            direction = 1f;
        }

        transform.Translate(direction * moveSpeed * Time.deltaTime, 0f, 0f);

        // Keep the bar on screen
        if (transform.position.x < -edge)
        {
            transform.position = new Vector3(-edge, transform.position.y, 0f);
        }
        if (transform.position.x > edge)
        {
            transform.position = new Vector3(edge, transform.position.y, 0f);
        }
    }

    // Runs when a block's trigger collider touches the bar
    void OnTriggerEnter2D(Collider2D other)
    {
        gameManager.BlockCaught(other.tag);
        Destroy(other.gameObject);
    }
}
