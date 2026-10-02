using UnityEngine;

// The road, as the skeletons see it: a list of points, one at the middle of
// each road tile, from the ruins to the gate. A skeleton walks to the first
// point, then the next, and so on.
public class WaypointPath : MonoBehaviour
{
    [SerializeField] Transform[] waypoints;

    public int Count
    {
        get { return waypoints.Length; }
    }

    public Vector3 GetPoint(int index)
    {
        return waypoints[index].position;
    }

    // Gizmos draw only in the Scene view: the road as a red line, a ball at
    // every point. Handy for checking the points are in order.
    void OnDrawGizmos()
    {
        if (waypoints == null)
        {
            return;
        }
        Gizmos.color = Color.red;
        for (int i = 0; i < waypoints.Length; i++)
        {
            if (waypoints[i] == null)
            {
                continue;
            }
            Gizmos.DrawSphere(waypoints[i].position, 0.15f);
            if (i > 0 && waypoints[i - 1] != null)
            {
                Gizmos.DrawLine(waypoints[i - 1].position, waypoints[i].position);
            }
        }
    }
}
