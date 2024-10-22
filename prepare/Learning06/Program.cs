using System;
using Learning06;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = [];

        Square shape1 = new("Red", 3);
        shapes.Add(shape1);

        Rectangle shape2 = new("Blue", 4, 5);
        shapes.Add(shape2);

        Circle shape3 = new("Green", 6);
        shapes.Add(shape3);

        foreach (Shape shape in shapes)
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea()}.");
    }
}