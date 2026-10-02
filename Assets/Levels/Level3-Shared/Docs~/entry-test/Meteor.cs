using UnityEngine;

// The three sizes of meteor. Each one has its own prefab.
public enum MeteorSize
{
    Small,
    Medium,
    Large
}

// Model answer for the Level 3 entry test practical task.
// One meteor: it flies in a straight line at a point on the city, and tells
// the game when it lands.
public class Meteor : MonoBehaviour
{
    [SerializeField] MeteorSize size = MeteorSize.Small;
    [SerializeField] float speed = 3f;      // units per second, at speed setting 1

    MeteorGame game;
    Vector3 target;
    Vector3 direction;

    // Other scripts can read the size, but not change it
    public MeteorSize Size
    {
        get { return size; }
    }

    // The game calls this as soon as it makes the meteor
    public void Launch(MeteorGame owner, Vector3 landingPoint)
    {
        game = owner;
        target = landingPoint;
        direction = (target - transform.position).normalized;
    }

    void Update()
    {
        transform.position += direction * speed * game.SpeedSetting * Time.deltaTime;

        // It has reached the top edge of the city
        if (transform.position.y <= target.y)
        {
            game.Landed(this);
        }
    }
}
