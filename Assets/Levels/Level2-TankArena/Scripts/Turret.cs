using UnityEngine;

// A tank's turret. The barrel turns towards a point, a little at a time, and
// fires shells from its tip, no faster than it can reload. The player's tank
// and the enemy tanks all use it.
public class Turret : MonoBehaviour
{
    [SerializeField] Transform barrel;
    [SerializeField] Transform muzzle;
    [SerializeField] GameObject shellPrefab;
    [SerializeField] float turnSpeed = 180f;      // degrees per second
    [SerializeField] float reloadTime = 0.5f;     // seconds between two shots
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip shotSound;

    float nextShotTime = 0f;

    public bool IsLoaded
    {
        get { return Time.time >= nextShotTime; }
    }

    // Turns the barrel a step towards the point. Call it every frame.
    public void AimAt(Vector2 point)
    {
        Vector2 direction = point - (Vector2)barrel.position;
        float wanted = Vector2.SignedAngle(Vector2.up, direction);
        float step = turnSpeed * Time.deltaTime;
        float angle = Mathf.MoveTowardsAngle(barrel.eulerAngles.z, wanted, step);
        barrel.rotation = Quaternion.Euler(0f, 0f, angle);
    }

    // Is the barrel pointing at the point, give or take a few degrees?
    public bool IsAimedAt(Vector2 point, float degrees)
    {
        Vector2 direction = point - (Vector2)barrel.position;
        return Vector2.Angle(barrel.up, direction) <= degrees;
    }

    // Fires a shell, if the turret has reloaded. Returns whether it fired.
    public bool Fire()
    {
        if (!IsLoaded)
        {
            return false;
        }

        Instantiate(shellPrefab, muzzle.position, barrel.rotation);
        audioSource.PlayOneShot(shotSound);
        nextShotTime = Time.time + reloadTime;
        return true;
    }
}
