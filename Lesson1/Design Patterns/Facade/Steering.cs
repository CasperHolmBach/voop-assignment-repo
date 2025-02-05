using Facade.Interfaces;

namespace Facade;

public class Steering : ISteering
{
    public void TurnLeft() { Console.WriteLine("Turning left."); }
    public void TurnRight() { Console.WriteLine("Turning right."); }
}