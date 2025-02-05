using Facade.Interfaces;

namespace Facade;


    public class Engine : IEngine
    {
        public void Start() { Console.WriteLine("Engine started."); }
        public void Stop() { Console.WriteLine("Engine stopped."); }
        public void Accelerate() { Console.WriteLine("Engine Accelerated."); }
        public void Decelerate() { Console.WriteLine("Engine Decelerated."); 
        }
    }
