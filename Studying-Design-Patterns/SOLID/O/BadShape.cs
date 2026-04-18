
namespace SOLID.O;

public enum ShapeType { Circle, Rectangle };

public class Shape
{
    public ShapeType Type { get; set; }
    public double Radius { get; set; }
    public double Length { get; set; }
    public double Width { get; set; }

    public double CalculateArea()
    {
        return Type switch
        {
            ShapeType.Circle => Math.PI * Math.Pow(Radius, 2),
            ShapeType.Rectangle => Length * Width,
            _ => throw new NotSupportedException("Shape not supported")
        };
    }

}