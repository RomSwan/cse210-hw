public class Circle : Shape
{
    private double _radius = 0;

    public Circle(double radius, string colour) : base(colour)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}