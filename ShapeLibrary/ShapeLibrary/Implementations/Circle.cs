using ShapeLibrary.Interfaces;

namespace ShapeLibrary;

public class Circle: IShape
{
    public readonly double _radius;

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Radius must be greater than zero.");
        
        _radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * _radius * _radius;
    }
}