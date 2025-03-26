namespace Circular_Buffer;

public class Consumer
{
    private readonly CircularBuffer _buffer;

    public Consumer(CircularBuffer buffer, int number) {
        _buffer = buffer;
        var t = new Thread(Consume)
        {
            Name = "Consumer_" + number
        };
        t.Start();
    }

    private void Consume() {
        while(true) {
            _buffer.Get();
            try
            {
                Thread.Sleep( Random.Shared.Next(5) * 200);
            }
            catch (ThreadInterruptedException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}