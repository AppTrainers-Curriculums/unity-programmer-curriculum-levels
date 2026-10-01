using UnityEngine;

// One section of the level: its name, where it starts, and the colour of its
// sky. [System.Serializable] lets a plain C# class show in the Inspector, so
// PlatformerGame can keep an array of them there.
[System.Serializable]
public class Section
{
    [SerializeField] string title;
    [SerializeField] float startX;
    [SerializeField] Color skyColour = Color.cyan;

    public string Title
    {
        get { return title; }
    }

    public float StartX
    {
        get { return startX; }
    }

    public Color SkyColour
    {
        get { return skyColour; }
    }
}
