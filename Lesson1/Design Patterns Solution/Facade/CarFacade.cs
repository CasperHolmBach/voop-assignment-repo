namespace Facade;

public class CarFacade
{
    private readonly Engine _engine;
    private readonly Brakes _brakes;
    private readonly Steering _steering;


    public CarFacade()
    {
        _engine = new Engine();
        _brakes = new Brakes();
        _steering = new Steering();
   
    }

    public void Start()
    {
        _engine.Start();
    }

    public void Stop()
    {
        _engine.Decelerate();
        _brakes.Apply();
        _engine.Stop();
    }

    public void Brake()
    {
        _brakes.Apply();
    }
    public void Accelerate()
    {
        _engine.Accelerate();
    }

    public void Decelerate()
    {
        _engine.Decelerate();
    }

    public void Steer(string direction)
    {
        if (direction == "left")
        {
            _steering.TurnLeft();
        }
        else if (direction == "right")
        {
            _steering.TurnRight();
        }
    }
}