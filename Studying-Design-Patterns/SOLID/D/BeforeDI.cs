namespace SOLID.D.BeforeDI;

// Low-level module
public class Engine
{
    public void Start()
    {
        Console.WriteLine("Engine started");
    }
}

// High-level module
public class Car
{
    public void Start()
    {
        // Tight coupling: Car creates its own dependency
        Engine _engine = new();
        _engine.Start();
        Console.WriteLine("Car started");
    }
}