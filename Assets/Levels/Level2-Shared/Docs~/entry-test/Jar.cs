using UnityEngine;
using UnityEngine.InputSystem;

// Model answer for the Level 2 entry test practical task.
// Moves the jar with the keyboard, and catches whatever it touches.
public class Jar : MonoBehaviour
{
    [SerializeField] FireflyGame game;
    [SerializeField] float speed = 8f;      // units per second
    [SerializeField] float maxX = 8f;       // how far left and right the jar can go
    [SerializeField] float maxY = 4.5f;     // how far up and down

    void Update()
    {
        float x = 0f;
        float y = 0f;

        if (Keyboard.current.leftArrowKey.isPressed || Keyboard.current.aKey.isPressed)
        {
            x = -1f;
        }
        if (Keyboard.current.rightArrowKey.isPressed || Keyboard.current.dKey.isPressed)
        {
            x = 1f;
        }
        if (Keyboard.current.downArrowKey.isPressed || Keyboard.current.sKey.isPressed)
        {
            y = -1f;
        }
        if (Keyboard.current.upArrowKey.isPressed || Keyboard.current.wKey.isPressed)
        {
            y = 1f;
        }

        transform.Translate(x * speed * Time.deltaTime, y * speed * Time.deltaTime, 0f);

        // Keep the jar on screen
        if (transform.position.x < -maxX)
        {
            transform.position = new Vector3(-maxX, transform.position.y, 0f);
        }
        if (transform.position.x > maxX)
        {
            transform.position = new Vector3(maxX, transform.position.y, 0f);
        }
        if (transform.position.y < -maxY)
        {
            transform.position = new Vector3(transform.position.x, -maxY, 0f);
        }
        if (transform.position.y > maxY)
        {
            transform.position = new Vector3(transform.position.x, maxY, 0f);
        }
    }

    // Runs when an insect's trigger collider touches the jar
    void OnTriggerEnter2D(Collider2D other)
    {
        game.Caught(other.tag);
        Destroy(other.gameObject);
    }
}
