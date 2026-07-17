public class Square : Shape
{
    private double _hmside;
    public Square(double hmside, string hmcolor) : base(hmcolor)
    {
        _hmside = hmside;
    }

    public override double GetArea()
    {
        return _hmside * _hmside;
    }

}