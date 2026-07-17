
public class Circle : Shape
{
    private double _hmradius;
    
    public Circle(double hmradius, string hmcolor) : base(hmcolor)
    {
        _hmradius = hmradius;
    }

    public override double GetArea()
    {
        return _hmradius * _hmradius * Math.PI;
    }
}