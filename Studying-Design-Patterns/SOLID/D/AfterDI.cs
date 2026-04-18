namespace SOLID.D.AfterDI;

// The Abstraction
public interface IEngine
{
    void Start();
}

// Low-level implementation
public class GasEngine : IEngine
{
    public void Start()
    {
        Console.WriteLine("Gas engine started");
    }
}

// Another low-level implementation
public class ElectricEngine : IEngine
{
    public void Start()
    {
        Console.WriteLine("Electric engine humming... started");
    }
}

// High-level module depending on abstraction
public class Car
{
    private readonly IEngine _engine;

    // Dependency is injected via the constructor
    public Car(IEngine engine)
    {
        _engine = engine;
    }

    public void Start()
    {
        _engine.Start();
        Console.WriteLine("Car started");
    }
}

// Program execution
public class Program
{
    public static void Main()
    {
        // We can easily swap implementations here
        var gasCar = new Car(new GasEngine());
        gasCar.Start();

        var electricCar = new Car(new ElectricEngine());
        electricCar.Start();
    }
}