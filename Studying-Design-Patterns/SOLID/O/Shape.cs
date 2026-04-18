
public abstract class Shape
{
    public abstract double CalculateArea();
}

public class Circle : Shape
{
    public double Radius { get; init; }
    public override double CalculateArea() => Math.PI * Math.Pow(Radius, 2);
}

public class Rectangle : Shape
{
    public double Length { get; init; }
    public double Width { get; init; }

    public override double CalculateArea() => Length * Width;

}

//Adding a triangle requires NO changes to the code above
public class Triangle : Shape
{
    public double Base { get; init; }
    public double Height { get; init; }
    public override double CalculateArea() => 0.5 * Base * Height;
}