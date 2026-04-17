namespace OOP.Polymorphism;

public class CarPM : VehiclePM
{
    public int NumberOfDoors { get; set; }

    public override void Start()
    {
        Console.WriteLine("Car is starting.");
    }

    public override void Stop()
    {
        Console.WriteLine("Car is stopping.");
    }
}