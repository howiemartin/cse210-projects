using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string hmfirst = Console.ReadLine();
        Console.Write("What is your last name? ");
        string hmlast = Console.ReadLine();
        Console.WriteLine($"\nYour name is {hmlast}, {hmfirst} {hmlast}.");
    }
}