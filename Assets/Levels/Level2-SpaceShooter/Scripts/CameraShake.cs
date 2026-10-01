using UnityEngine;

// Shakes the camera for a moment when something explodes. The shake happens in
// LateUpdate, after everything else has moved this frame.
public class CameraShake : MonoBehaviour
{
    [SerializeField] float defaultStrength = 0.1f;

    Vector3 home;
    float timeLeft = 0f;
    float strength;

    void Awake()
    {
        home = transform.position;
    }

    // Two versions (overloads): a normal shake, or one as strong as you ask.
    public void Shake(float seconds)
    {
        Shake(seconds, defaultStrength);
    }

    public void Shake(float seconds, float power)
    {
        timeLeft = seconds;
        strength = power;
    }

    void LateUpdate()
    {
        // While the game is paused (Time.timeScale is 0), time doesn't pass, so
        // the shake would never end: stay still until the game carries on.
        if (timeLeft > 0f && Time.timeScale > 0f)
        {
            timeLeft -= Time.deltaTime;
            Vector3 jolt = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0f);
            transform.position = home + jolt * strength;
        }
        else
        {
            transform.position = home;
        }
    }

    void OnDisable()
    {
        transform.position = home;    // switched off in the settings: stop mid-shake
    }
}
