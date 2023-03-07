class Square : Shape
{
    private double _sides;

    public Square (string color, double sides)
    :base (color)
    {
        _sides = sides;
    }

    public override double GetArea()
    {
        double area = _sides * 4;
        return area;
    }

}