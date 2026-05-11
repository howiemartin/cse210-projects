using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input the percent grade: ");
        string hminputGrade = Console.ReadLine();
        int hmpercentGrade = int.Parse(hminputGrade);
        string hmletter;
        bool hmpass = false;
        if (hmpercentGrade >= 90)
        {
            hmletter = "A";
            hmpass = true;
        }
        else if (hmpercentGrade >= 80)
        {
            hmletter = "B";
            hmpass = true;
        }
        else if (hmpercentGrade >= 70)
        {
            hmletter = "C";
            hmpass = true;
        }
        else if (hmpercentGrade >= 60)
        {
            hmletter = "D";
        }
        else
        {
            hmletter = "F";
        }
        Console.WriteLine($"Your grade is {hmletter}.");
        if (hmpass == true)
        {
            Console.WriteLine("Congrats! You passed.");
        }
        else
        {
            Console.WriteLine("Sorry, you failed. Better luck next time!");
        }
    }
}