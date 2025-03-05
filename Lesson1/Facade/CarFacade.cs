namespace Facade;

public class CarFacade
{
    private IBrakes _brakes;
    private IEngine _engine;
    private ISteering _steering;

    public CarFacade(IBrakes brakes, IEngine engine, ISteering steering)
    {
        _brakes = brakes;
        _engine = engine;
        _steering = steering;
    }
    
    //Call methods
}