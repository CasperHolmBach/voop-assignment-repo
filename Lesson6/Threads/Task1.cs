namespace Threads;

public class Task1
{
    private Counter cr;

    public Task1(Counter cr)
    {
        this.cr = cr;
    }

    public void DoIncrement()
    {
        for (int i = 0; i < 10; i++)
        {
            cr.IncrementCount();
        }
    }

    public void Run()
    {
        Thread thread = new Thread(DoIncrement);
        thread.Start();
    }
}