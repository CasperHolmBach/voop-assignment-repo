// See https://aka.ms/new-console-template for more information

using Facade;

var car = new CarFacade();


car.Start();
car.Accelerate();
car.Steer("left");
car.Stop();