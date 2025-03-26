namespace Circular_Buffer;

public class CircularBuffer
{
    private int?[] buffer;
    private int size;
    int putIndex = 0;
    int getIndex = 0;

    public CircularBuffer(int size) {
        buffer = new int?[size];
        this.size = size;
    }

    public void Get()
    {
        throw new NotImplementedException("Not implemented yet!");
    }

    public void Put(int n)
    {
        throw new NotImplementedException("Not implemented yet!");
    }
}