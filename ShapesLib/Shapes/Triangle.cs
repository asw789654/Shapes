using ShapesLib.Interfaces;

namespace ShapesLib.Shapes;

public class Triangle : IShape
{
    private double a, b, c;

    private bool isRight { get; set; }
    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
        IsRight = IsRight;
    }

    public double CalculateArea()
    {
        if (a > 0 && b > 0 && c > 0
            && a + b > c && a + c > b && b + c > a)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p *
                (p - a) *
                (p - b) *
                (p - c));
        }
        else
        {
            throw new InvalidDataException();
        }
    }
    public bool IsRight
    {
        get { return isRight; }
        private set
        {
            if ((a * a + b * b == c * c) || 
                (a * a + c * c == b * b) || 
                (c * c + b * b == a * a))
            {
                isRight = true;
            }
            else
            {
                isRight = false;
            }
        }
    }
}
