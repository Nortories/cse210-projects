
class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string top = _top.ToString();
        string bottom = _bottom.ToString();
        string fraction = top+"/"+bottom;
        return fraction;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom; 
    }

    public void SetFraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
}