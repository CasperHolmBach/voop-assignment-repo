namespace Threads;

public class Counter
{
    private int count;

    public Counter()
    {
        count = 0;
    }

    public void IncrementCount()
    {
        count += 2;
    }

    public void DecrementCount()
    {
        count -= 1;
    }

    public int GetCount()
    {
        return count;
    }
}