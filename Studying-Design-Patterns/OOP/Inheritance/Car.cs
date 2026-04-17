namespace OOP.Inheritance;

public class Car : Vehicle
{
    public Car(string brand, string model, int year, int numberOfDoors, int numberOfWheels) : base(brand, model, year)
    {
        NumberOfDoors = numberOfDoors;
        NumberOfWheels = numberOfWheels;
    }
    public int NumberOfDoors { get; set; }
    public int NumberOfWheels { get; set; }
}