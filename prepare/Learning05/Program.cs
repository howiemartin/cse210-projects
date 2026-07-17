using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> hmshapes = new List<Shape>();
        hmshapes.Add(new Square(3, "Red"));
        hmshapes.Add(new Rectangle(4, 6, "Yellow"));
        hmshapes.Add(new Circle(2.55, "Blue"));

        foreach (Shape hmshape in hmshapes)
        {
            Console.WriteLine(hmshape.GetArea());
        }
        
    }
}