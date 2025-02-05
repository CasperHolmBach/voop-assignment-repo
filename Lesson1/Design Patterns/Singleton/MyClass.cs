namespace DesignPatterns;

public class MyClass
{
    private static MyClass? _instance;
    private int _value;

    private MyClass(int value)
    {
        _value = value;
    }

    public static MyClass getInstance(int value)
    {
        if (_instance == null)
        {
            _instance = new MyClass(value);
        }
        return _instance;
    }

    public void PrintValue()
    {
        Console.WriteLine("Value= "+ _value);
    }
}