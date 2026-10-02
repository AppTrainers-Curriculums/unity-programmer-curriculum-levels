using UnityEngine;

// Draws a circle on the ground with a Line Renderer: a tower's range, while
// its menu is open. The points go round the circle with Cos and Sin.
[RequireComponent(typeof(LineRenderer))]
public class RangeRing : MonoBehaviour
{
    [SerializeField] int points = 64;
    [SerializeField] float height = 0.05f;      // just above the ground, so it isn't hidden in it

    LineRenderer line;

    void Awake()
    {
        line = GetComponent<LineRenderer>();
        line.loop = true;
        line.positionCount = points;
        Hide();
    }

    public void Show(Vector3 centre, float radius)
    {
        for (int i = 0; i < points; i++)
        {
            float angle = i * 2f * Mathf.PI / points;
            Vector3 offset = new Vector3(Mathf.Cos(angle) * radius, height, Mathf.Sin(angle) * radius);
            line.SetPosition(i, centre + offset);
        }
        line.enabled = true;
    }

    public void Hide()
    {
        line.enabled = false;
    }
}
