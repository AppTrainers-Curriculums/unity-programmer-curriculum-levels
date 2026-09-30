using UnityEngine;

// Drops a random block from above the screen, a little faster each time.
// Attach this to the Spawner object.
public class Spawner : MonoBehaviour
{
    [SerializeField] GameManager gameManager;

    // The blocks it can drop. Put a prefab in twice to drop it twice as often.
    [SerializeField] GameObject[] blockPrefabs;

    [SerializeField] float startDelay = 1.2f;      // seconds between blocks when a game starts
    [SerializeField] float shortestDelay = 0.45f;  // the fastest it will ever get
    [SerializeField] float speedUp = 0.02f;        // seconds cut from the delay after each block
    [SerializeField] float spawnWidth = 8.5f;      // blocks appear between -spawnWidth and +spawnWidth
    [SerializeField] float spawnHeight = 7f;       // just above the top of the screen

    float delay;
    float timer = 0f;

    void Update()
    {
        if (!gameManager.IsPlaying())
        {
            return;
        }

        timer += Time.deltaTime;

        if (timer >= delay)
        {
            timer = 0f;
            DropBlock();

            // Speed up a little, but never past the shortest delay
            if (delay > shortestDelay)
            {
                delay -= speedUp;
            }
        }
    }

    // Drops one random block at a random x position
    void DropBlock()
    {
        int index = Random.Range(0, blockPrefabs.Length);
        float x = Random.Range(-spawnWidth, spawnWidth);
        Vector3 position = new Vector3(x, spawnHeight, 0f);

        // The last argument makes the new block a child of this Spawner
        Instantiate(blockPrefabs[index], position, Quaternion.identity, transform);
    }

    // Gets ready for a new game: no blocks, and back to the starting speed
    public void Restart()
    {
        ClearBlocks();
        delay = startDelay;
        timer = 0f;
    }

    // Removes every block still falling (they are all children of this Spawner)
    public void ClearBlocks()
    {
        foreach (Transform block in transform)
        {
            Destroy(block.gameObject);
        }
    }
}
