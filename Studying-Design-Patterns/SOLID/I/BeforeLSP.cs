namespace SOLID.I.BeforeLSP;
public interface IShape
{
    double Area();
    double Volume();
}

public class Circle : IShape
{
    public double Radius { get; set; }

    public double Area()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    public double Volume()
    {
        // Violation: Forced to implement a method that doesn't apply
        throw new InvalidOperationException("Volume is not applicable for 2D shapes.");
    }
}

public class Sphere : IShape
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