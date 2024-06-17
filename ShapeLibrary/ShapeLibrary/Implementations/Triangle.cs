using ShapeLibrary.Interfaces;

namespace ShapeLibrary;

public class Triangle : IShape
{
    public readonly double _a;
    public readonly double _b;
    public readonly double _c;

    public Triangle(double a, double b, double c)
    {
        _a = a;
        _b = b;
        _c = c;
        
        
        if (_a <= 0 || _b <= 0 || _c <= 0)
            throw new ArgumentException("All sides must be greater than zero.");
        if (_a + _b <= _c || _a + _c <= _b || _b + _c <= _a)
            throw new ArgumentException("The given sides do not form a triangle.");
    }

    public double CalculateArea()
    {
        double s = (_a + _b + _c) / 2;

        if(IsRightTriangle())
        {
            Console.WriteLine("The triangle is rectangular");
        }
        
        return Math.Sqrt(s * (s - _a) * (s - _b) * (s - _c));
    }

    public bool IsRightTriangle()
    {
        double[] sides = { _a, _b, _c };
        Array.Sort(sides);

        return (sides[0] * sides[0]) == (sides[1] * sides[1] + sides[2] * sides[2]);
    }
}
