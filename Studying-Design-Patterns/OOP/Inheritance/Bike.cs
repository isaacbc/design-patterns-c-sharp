namespace OOP.Inheritance;

public class Bike : Vehicle
{
    public int NumberOfWheels { get; set; }

    public Bike(string brand, string model, int year, int numberOfWheels) : base(brand, model, year)
    {
        NumberOfWheels = numberOfWheels;
    }
}