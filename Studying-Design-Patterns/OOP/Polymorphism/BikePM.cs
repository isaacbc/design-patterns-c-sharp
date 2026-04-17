namespace OOP.Polymorphism;

public class BikePM : VehiclePM
{
    public int NumberOfWheels { get; set; }

    public override void Start()
    {
        Console.WriteLine("Bike is starting.");
    }

    public override void Stop()
    {
        Console.WriteLine("Bike is stopping.");
    }
}