using System.Security.Cryptography;

public class Shape
{
    protected string _hmcolor; 


    public Shape(string hmcolor)
    {
        _hmcolor = hmcolor;
    }
    public string GetColor()
    {
        return _hmcolor;
    }

    public void SetColor(string hmcolor)
    {
        _hmcolor = hmcolor;
    }

    public virtual double GetArea()
    {
        return 0;
    }
}