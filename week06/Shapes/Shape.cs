public abstract class Shape
{
    protected string _colour = "";

    public Shape(string colour)
    {
        _colour = colour;
    }

    public string GetColour()
    {
        return _colour;
    }

    public string SetColour(string colour)
    {
        return _colour = colour;
    }

    public abstract double GetArea();
}