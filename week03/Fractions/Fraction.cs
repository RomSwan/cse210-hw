public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {   // Sets default
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int top, int bottom)
    {
        _numerator = top;
        _denominator = bottom;
    }

    public string GetFractionString()
    {
        string f = $"{_numerator}/{_denominator}";
        return f;
    }

    public double GetDecimalValue()
    {
        return (double)_numerator / (double)_denominator;
    }
}