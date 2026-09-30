using UnityEngine;

// An invisible floor below the screen: every block that reaches it was missed.
// Attach this to the Floor object.
public class Floor : MonoBehaviour
{
    [SerializeField] GameManager gameManager;

    // Runs when a block's trigger collider touches the floor
    void OnTriggerEnter2D(Collider2D other)
    {
        gameManager.BlockMissed(other.tag);
        Destroy(other.gameObject);
    }
}
