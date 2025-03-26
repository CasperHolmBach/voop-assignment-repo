namespace Circular_Buffer;

public class PcFixed
{
    public static void Main(string[] args)
    {
        CircularBuffer buffer = new CircularBuffer(5);
        new Producer(buffer, 0);
        new Producer(buffer, 1);

        new Consumer(buffer, 0);
        new Consumer(buffer, 1);
        new Consumer(buffer, 2);
    }  
}