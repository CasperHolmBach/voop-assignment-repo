namespace Circular_Buffer;

public class Producer
{
    private readonly CircularBuffer _buffer;
    private readonly int _initVal;

    public Producer(CircularBuffer buffer, int number) {
        _buffer = buffer;
        _initVal = number*100;
        var t = new Thread(Produce)
        {
            Name = "Producer_" + number
        };
        t.Start();
    }

    private void Produce() {
        int i = _initVal;
        while(true) {
            _buffer.Put(i++);
            try {
                Thread.Sleep( Random.Shared.Next(5) * 100);
            } catch (ThreadInterruptedException ex) {
                Console.WriteLine(ex);
            }
        }
    }

}