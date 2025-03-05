namespace DesignPatterns;

public class MyClass
{
    private static MyClass instance;
    private int _value;

    private MyClass(int value)
    {
        _value = value;
    }

    public static MyClass GetInstance(int value)
    {
        if(instance == null)
        {
            instance = new MyClass(value);
        }

        return instance;
    }

    public void PrintValue()
    {
        Console.WriteLine("Value= "+ _value);
    }
}