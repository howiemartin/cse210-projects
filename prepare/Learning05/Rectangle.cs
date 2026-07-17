public class Rectangle : Shape
{
    private double _hmlength;
    private double _hmwidth;
    
    public Rectangle(double hmlength, double hmwidth, string hmcolor) : base(hmcolor)
    {
        _hmlength = hmlength;
        _hmwidth = hmwidth;
    }

    public override double GetArea()
    {
        return _hmlength * _hmwidth;
    }
}