namespace French_Mountains;

public class MountainComparer : IComparer<Mountain>
{
    public int Compare(Mountain? x, Mountain? y)
    {
        if (string.Compare(x.Range, y.Range, StringComparison.Ordinal) < 0)
        {
            return -1;
        }

        if (string.Compare(x.Range, y.Range, StringComparison.Ordinal) > 0)
        {
            return 1;
        }

        else
        {
            return x.CompareTo(y);
        }
    }
}