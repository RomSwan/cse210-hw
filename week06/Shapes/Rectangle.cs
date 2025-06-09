public class Rectangle : Shape
{
    private double _length = 0;
    private double _width = 0;

    public Rectangle(double length, double width, string colour) : base(colour)
    {
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}