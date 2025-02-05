namespace DesignPatterns;

public class MyClass

{
    private static MyClass _instance;
    private int _value;


    // Private constructor to prevent external instantiation
    private MyClass(int value)
    {
        _value = value;
    }
    
    // Public static method to provide access to the single instance
    public static MyClass GetInstance(int value)
    {
        if (_instance == null)
        {
            _instance = new MyClass(value);
        }
        return _instance;
    }
    
    public void PrintValue()
    {
        Console.WriteLine("Value= " + _value);
    }

}