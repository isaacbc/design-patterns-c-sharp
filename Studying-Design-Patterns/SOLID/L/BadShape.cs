
namespace SOLID.L.BadShape;

public abstract class Shape
{
    public abstract double Area { get; }
}

public class Rectangle : Shape
{
    public virtual double Width { get; set; }
    public virtual double Height { get; set; }

    public override double Area => Width * Height;
}

public class Square : Rectangle
{
    public override double Width
    {
        get => base.Width;
        set { base.Width = value; base.Height = value; }
    }

    public override double Height
    {
        get => base.Height;
        set { base.Height = value; base.Width = value; }
    }
}

public class Main
{
    public void Test()
    {
        Rectangle rect = new();
        rect.Height = 10;
        rect.Width = 5;
        // For a Rectangle, we expect Area = 10 * 5 = 50
        Console.WriteLine($"Expected Area: 50, Actual Area: {rect.Area}");

        Rectangle square = new Square();
        square.Height = 10;
        square.Width = 5;
        // But for a square, Area will be 5 * 5 = 25
        Console.WriteLine($"Expected Area: 50, Actual Area: {square.Area}");
    }

}