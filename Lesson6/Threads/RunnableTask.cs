namespace Threads;

public class RunnableTask
{
    private string threadName;
    private int sum;
    
    public RunnableTask(string threadName)
    {
        this.threadName = threadName;
        sum = 0;
    }

    private void Loop()
    {
        for (int i = 0; i < 10; i++)
        {
            sum += i;
            Console.WriteLine($"Thread {threadName} - Current Value: {sum}");
            Thread.Sleep(100);
        }
        
        Console.WriteLine($"Thread {threadName} - Sum: {sum}");
    }

    public void Run()
    {
        Thread thread = new Thread(Loop);
        thread.Start();
    }
}