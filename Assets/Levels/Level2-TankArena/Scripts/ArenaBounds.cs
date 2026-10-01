using UnityEngine;

// The size of the arena, for every script that needs it. A static class: there's
// only one arena, so nobody needs to make an object to ask about it.
public static class ArenaBounds
{
    public const float HalfWidth = 12f;     // the ground goes from x = -12 to 12...
    public const float HalfHeight = 8f;     // ...and from y = -8 to 8
    const float Margin = 2f;                // keeps random points away from the walls

    // A random point inside the arena, not too close to its edge.
    public static Vector2 RandomPoint()
    {
        float x = Random.Range(-HalfWidth + Margin, HalfWidth - Margin);
        float y = Random.Range(-HalfHeight + Margin, HalfHeight - Margin);
        return new Vector2(x, y);
    }
}
