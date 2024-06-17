using NUnit.Framework;
using ShapeLibrary;

[TestFixture]
public class ShapeTests
{
    [Test]
    public void CircleAreaTest()
    {
        var circle = new Circle(5);
        
        Assert.Equals(Math.PI * 25, circle.CalculateArea());
    }

    [Test]
    public void TriangleAreaTest()
    {
        var triangle = new Triangle(3, 4, 5);
        
        Assert.Equals(6, triangle.CalculateArea());
    }

    [Test]
    public void TriangleIsRightTest()
    {
        var triangle = new Triangle(3, 4, 5);
        
        Assert.Equals(triangle.IsRightTriangle(), true);
    }

    [Test]
    public void TriangleNotRightTest()
    {
        var triangle = new Triangle(3, 4, 6);
        
        Assert.Equals(triangle.IsRightTriangle(), false);
    }
}