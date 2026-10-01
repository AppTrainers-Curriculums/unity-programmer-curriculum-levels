using System.Collections.Generic;

// Golf's rules and its names for scores. A static class: there's one set of
// golf rules for the whole game, so nobody needs to make an object of it.
public static class GolfTerms
{
    public const int MaxStrokes = 8;

    static readonly Dictionary<int, string> names = new Dictionary<int, string>
    {
        { -3, "Albatross" },
        { -2, "Eagle" },
        { -1, "Birdie" },
        { 0, "Par" },
        { 1, "Bogey" },
        { 2, "Double Bogey" },
        { 3, "Triple Bogey" },
    };

    public static string NameFor(int strokes, int par)
    {
        if (strokes == 1)
        {
            return "Hole in One";
        }
        if (names.TryGetValue(strokes - par, out string name))
        {
            return name;
        }
        return "+" + (strokes - par);
    }
}
