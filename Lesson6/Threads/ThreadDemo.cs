namespace Threads;

public class ThreadDemo
{
    public static void Main(string[] args)
    {
        RunnableTask a = new RunnableTask("A");
        RunnableTask b = new RunnableTask("B");
        RunnableTask c = new RunnableTask("C");
        
        a.Run();
        b.Run();
        c.Run();
        Thread.Sleep(1000);
        
        Counter counter = new Counter();
        Thread.Sleep(1000);
        Console.WriteLine("The value of counter before running threads is: " + counter.GetCount());
        
        Task1 task1 = new Task1(counter);
        Task2 task2 = new Task2(counter);
        
        task1.Run();
        task2.Run();
        Thread.Sleep(1000);
        
        Console.WriteLine("The value of counter after running threads is: " + counter.GetCount());
    }
}