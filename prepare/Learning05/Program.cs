using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("red", 5);
        Circle circle = new Circle("blue", 4);
        Rectangle rectangle = new Rectangle("green", 7, 4.5);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach(Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
            Console.WriteLine();
        }
    }
}