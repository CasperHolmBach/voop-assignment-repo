namespace Threads;

public class Task2
{
    private Counter cr;

    public Task2(Counter cr)
    {
        this.cr = cr;
    }

    public void DoDecrement()
    {
        for (int i = 0; i < 10; i++)
        {
            cr.DecrementCount();
        }
    }

    public void Run()
    {
        Thread thread = new Thread(DoDecrement);
        thread.Start();
    }
}