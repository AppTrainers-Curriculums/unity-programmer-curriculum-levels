using UnityEngine;

// Anything the player can shoot: enemy ships and meteors. It flies down the
// screen (swaying and spinning, if you like), takes hits, and explodes. Every
// enemy counts itself while it's alive.
[RequireComponent(typeof(Rigidbody2D))]
public class Enemy : MonoBehaviour
{
    [SerializeField] string enemyName = "Scout";
    [SerializeField] int maxHealth = 1;
    [SerializeField] int points = 100;
    [SerializeField] float fallSpeed = 2.5f;
    [SerializeField] float swayWidth = 0f;        // 0 flies straight down
    [SerializeField] float swaySpeed = 2f;
    [SerializeField] float spinSpeed = 0f;        // degrees per second: meteors spin
    [SerializeField] GameObject[] powerUpPrefabs;
    [SerializeField] float powerUpChance = 0.12f;

    public static int AliveCount { get; private set; }

    Rigidbody2D body;
    ShooterGame game;
    int health;
    float startX;
    float age = 0f;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        health = maxHealth;
        startX = transform.position.x;
    }

    void OnEnable()
    {
        AliveCount++;
    }

    void OnDisable()
    {
        AliveCount--;
    }

    public static void ResetCount()
    {
        AliveCount = 0;
    }

    public void SetGame(ShooterGame shooterGame)
    {
        game = shooterGame;
    }

    void FixedUpdate()
    {
        age += Time.deltaTime;
        float x = startX + Mathf.Sin(age * swaySpeed) * swayWidth;
        float y = body.position.y - fallSpeed * Time.deltaTime;
        body.MovePosition(new Vector2(x, y));
        body.MoveRotation(body.rotation + spinSpeed * Time.deltaTime);

        if (y < -6.5f)
        {
            Destroy(gameObject);    // it flew off the bottom of the screen
        }
    }

    public void TakeDamage(int damage)
    {
        if (health <= 0)
        {
            return;    // already exploding
        }

        health -= damage;
        if (health <= 0)
        {
            Explode();
        }
    }

    void Explode()
    {
        game.EnemyDestroyed(enemyName, points, transform.position);

        if (powerUpPrefabs.Length > 0 && Random.value < powerUpChance)
        {
            GameObject prefab = powerUpPrefabs[Random.Range(0, powerUpPrefabs.Length)];
            Instantiate(prefab, transform.position, Quaternion.identity, transform.parent);
        }
        Destroy(gameObject);
    }
}
