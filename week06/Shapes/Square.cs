public class Square : Shape
{
    private double _side = 0;

    public Square(double side, string colour) : base (colour)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}