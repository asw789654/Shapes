using ShapesLib.Interfaces;

namespace ShapesLib.Shapes;

public class Circle : IShape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double CalculateArea()
    {
        if (radius > 0)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        else
        {
            throw new InvalidDataException();
        }
    }

}
