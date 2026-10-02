using UnityEngine;

// One room of the crypt: its name, the point the camera looks at, and
// whether the king waits there. [System.Serializable] lets a plain C# class
// show in the Inspector, so CryptGame can keep an array of them.
[System.Serializable]
public class Room
{
    [SerializeField] string title;
    [SerializeField] Vector2 centre;
    [SerializeField] bool hasBoss;

    public string Title
    {
        get { return title; }
    }

    public Vector2 Centre
    {
        get { return centre; }
    }

    public bool HasBoss
    {
        get { return hasBoss; }
    }
}
