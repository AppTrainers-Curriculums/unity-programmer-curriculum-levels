using UnityEngine;

// Shows one room at a time. When the hero walks into the next room, the
// camera slides there, at a steady speed.
public class RoomCamera : MonoBehaviour
{
    [SerializeField] float slideSpeed = 30f;    // units a second: one room in about a third of a second

    Vector3 goal;

    void Awake()
    {
        goal = transform.position;
    }

    public void MoveTo(Vector2 centre)
    {
        goal = new Vector3(centre.x, centre.y, transform.position.z);
    }

    // Straight there, with no slide: on Restart.
    public void SnapTo(Vector2 centre)
    {
        MoveTo(centre);
        transform.position = goal;
    }

    // LateUpdate runs after every Update, so the hero has already moved.
    void LateUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, goal, slideSpeed * Time.deltaTime);
    }
}
