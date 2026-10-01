using UnityEngine;

// One hole of the course. It lives on the hole's parent object, and knows the
// hole's name, its par, and where the ball starts.
public class Hole : MonoBehaviour
{
    [SerializeField] string holeName = "New Hole";
    [SerializeField] int par = 2;
    [SerializeField] Transform tee;

    public string HoleName
    {
        get { return holeName; }
    }

    public int Par
    {
        get { return par; }
    }

    public Vector3 TeePosition
    {
        get { return tee.position; }
    }
}
