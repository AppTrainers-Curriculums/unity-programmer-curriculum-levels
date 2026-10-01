using UnityEngine;

// Slides the tiled space background down the screen, for ever, so the ship
// seems to fly forwards.
public class ScrollingBackground : MonoBehaviour
{
    [SerializeField] float speed = 1f;            // units per second
    [SerializeField] float tileHeight = 2.56f;    // the height of one tile of the background

    float startY;

    void Start()
    {
        startY = transform.position.y;
    }

    void Update()
    {
        // Mathf.Repeat counts up to tileHeight, then starts again from 0.
        // One tile lower looks exactly the same, so the jump back can't be seen.
        float offset = Mathf.Repeat(Time.time * speed, tileHeight);
        transform.position = new Vector3(transform.position.x, startY - offset, transform.position.z);
    }
}
