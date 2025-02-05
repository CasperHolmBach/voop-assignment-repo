namespace Facade.Interfaces;

public class CarFacade: IBrakes, IEngine, ISteering
{
    private IBrakes brakes;
    private IEngine engine;
    private ISteering steering;

    public CarFacade()
    {
        brakes = new Brakes();
        engine = new Engine();
        steering = new Steering();
    }
    
    public void Apply()
    {
        brakes.Apply();
    }

    public void Release()
    {
        brakes.Release();
    }

    public void Start()
    {
        engine.Start();
    }

    public void Stop()
    {
        engine.Stop();
    }

    public void Accelerate()
    {
        engine.Accelerate();
    }

    public void Decelerate()
    {
        engine.Decelerate();
    }

    public void TurnLeft()
    {
        steering.TurnLeft();
    }

    public void TurnRight()
    {
        steering.TurnRight();
    }
}