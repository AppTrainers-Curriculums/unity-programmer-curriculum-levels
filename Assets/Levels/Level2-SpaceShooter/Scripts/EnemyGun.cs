using UnityEngine;

// Lets an enemy ship shoot, but only when it can see the player: a raycast
// looks straight down from the gun for anything on the Player layer.
public class EnemyGun : MonoBehaviour
{
    [SerializeField] GameObject laserPrefab;
    [SerializeField] Transform muzzle;
    [SerializeField] LayerMask playerMask;
    [SerializeField] float range = 12f;
    [SerializeField] float cooldown = 1.2f;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip shootSound;

    float nextShotTime = 0f;

    void Update()
    {
        if (Time.time < nextShotTime)
        {
            return;
        }

        Debug.DrawRay(muzzle.position, Vector2.down * range, Color.red);
        RaycastHit2D hit = Physics2D.Raycast(muzzle.position, Vector2.down, range, playerMask);
        if (hit.collider != null)
        {
            // Turned 180°, the laser's "up" points down the screen.
            Instantiate(laserPrefab, muzzle.position, Quaternion.Euler(0f, 0f, 180f));
            audioSource.PlayOneShot(shootSound);
            nextShotTime = Time.time + cooldown;
        }
    }
}
