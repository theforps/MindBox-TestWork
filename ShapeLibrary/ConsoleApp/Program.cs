using ShapeLibrary;
using ShapeLibrary.Interfaces;

IShape circle = ShapeFactory.CreateCircle(5);
Console.WriteLine($"Circle area: {circle.CalculateArea()}");

IShape triangle = ShapeFactory.CreateTriangle(3, 4, 5);
Console.WriteLine($"Triangle area: {triangle.CalculateArea()}");