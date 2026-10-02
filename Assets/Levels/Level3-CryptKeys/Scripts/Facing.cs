using UnityEngine;

// The four ways a character can face. Their numbers are the Animator's
// Direction parameter: 0 down, 1 left, 2 up and 3 right.
public enum Facing { Down, Left, Up, Right }

// Turns a movement into a facing, and a facing into a direction. Every
// character needs them, so they're written once, as static methods.
public static class Facings
{
    // The facing nearest to a movement. A movement exactly between two
    // facings, such as up and to the right, keeps the facing the character
    // already has if it's one of the two, so walking diagonally doesn't flicker.
    public static Facing FromVector(Vector2 move, Facing current)
    {
        if (move.sqrMagnitude < 0.0001f)
        {
            return current;
        }

        float across = Mathf.Abs(move.x);
        float upDown = Mathf.Abs(move.y);
        Facing horizontal = move.x < 0f ? Facing.Left : Facing.Right;
        Facing vertical = move.y < 0f ? Facing.Down : Facing.Up;

        if (Mathf.Abs(across - upDown) < 0.01f && (current == horizontal || current == vertical))
        {
            return current;
        }
        return across > upDown ? horizontal : vertical;
    }

    public static Vector2 ToVector(Facing facing)
    {
        switch (facing)
        {
            case Facing.Left:
                return Vector2.left;
            case Facing.Up:
                return Vector2.up;
            case Facing.Right:
                return Vector2.right;
            default:
                return Vector2.down;
        }
    }
}
