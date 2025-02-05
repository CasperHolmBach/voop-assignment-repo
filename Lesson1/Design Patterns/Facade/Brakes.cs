using Facade.Interfaces;

namespace Facade;

public class Brakes : IBrakes
{
    public void Apply() { Console.WriteLine("Brakes applied"); }
    public void Release() { Console.WriteLine("Brakes released"); }
}