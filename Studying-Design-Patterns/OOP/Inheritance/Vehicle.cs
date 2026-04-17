using System.Dynamic;

namespace OOP.Inheritance;

public class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Vehicle(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }
    public void Start()
    {
        Console.WriteLine("Vehicle is starting.");

    }
    public void Stop()
    {
        Console.WriteLine("Vehicle is stopping.");
    }

}