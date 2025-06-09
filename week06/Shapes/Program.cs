using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square(5, "Blue");
        Rectangle rectangle = new Rectangle(5, 8, "Purple");
        Circle circle = new Circle(10, "Green");

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string colour = shape.GetColour();
            double area = shape.GetArea();

            Console.WriteLine($"The {colour} shape's area is {area}.");
        }
    }
}