namespace SOLID.I.AfterLSP;

// Fine-grained interfaces
public interface IShape2D
{
    double Area();
}

public interface IShape3D
{
    double Area();
    double Volume();
}

public class Circle : IShape2D
{
    public double Radius { get; set; }

    public double Area()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
    // No Volume method required here!
}

public class Sphere : IShape3D
{
    public double Radius { get; set; }

    public double Area()
    {
        return 4 * Math.PI * Math.Pow(Radius, 2);
    }

    public double Volume()
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
    }
}

// Program Execution
public class Program
{
    public static void Main()
    {
        Circle myCircle = new Circle { Radius = 10 };
        Console.WriteLine($"Circle Area: {myCircle.Area()}");
        
        // myCircle.Volume(); // This would now cause a compile-time error, preventing bugs!
    }
}