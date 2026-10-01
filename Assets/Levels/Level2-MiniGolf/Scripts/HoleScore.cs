// One line of the scorecard. A plain C# class: not a component, never on a
// GameObject. The game makes one with `new` each time a hole is finished.
public class HoleScore
{
    public int HoleNumber { get; private set; }
    public int Par { get; private set; }
    public int Strokes { get; private set; }

    public HoleScore(int holeNumber, int par, int strokes)
    {
        HoleNumber = holeNumber;
        Par = par;
        Strokes = strokes;
    }

    // Strokes compared with par: -1 is one under par, 2 is two over.
    public int Difference
    {
        get { return Strokes - Par; }
    }

    public string Name
    {
        get { return GolfTerms.NameFor(Strokes, Par); }
    }
}
