namespace OOP.Polymorphism;

public class PlanePM : VehiclePM
{
    public int NumberOfEngines { get; set; }

    public override void Start()
    {
        Console.WriteLine("Plane is starting.");
    }

    public override void Stop()
    {
        Console.WriteLine("Plane is stopping.");
    }

}