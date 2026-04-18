namespace SOLID.L.ImprovedShape;

public abstract class Shape
{
    public abstract double Area { get; }
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public override double Area => Width * Height;
}

public class Square : Shape
{
    public double SideLength { get; set; }

    public override double Area => SideLength * SideLength;
}


public class Main
{
    public void Test()
    {
        Shape rect = new Rectangle { Width = 4, Height = 5 };
        Console.WriteLine($"Area of Rectangle: {rect.Area}"); // 20

        Shape square = new Square{SideLength=5};
        Console.WriteLine($"Area of Square: {square.Area}"); // 25
    }

}