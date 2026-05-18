using System;

class Program
{
    static void Main(string[] args)
    {
       
        Random randomGenerator = new Random();
        
        int hmmagic_number = randomGenerator.Next(1, 101);
        int hmnumb;
        int hmattempts = 0;

       do{

        hmattempts++;

        Console.Write("\nWhat is your guess: ");
        string hmguess = Console.ReadLine();

        hmnumb = int.Parse(hmguess);
       if(hmnumb == hmmagic_number)
        {
            Console.Write("You guessed it!");
        }
        else if(hmnumb > hmmagic_number)
        {
            Console.Write("Lower");
        }
        else
        {
            Console.Write("Higher");
        }
       } while(hmnumb != hmmagic_number);
        Console.Write($"\nAttempts: {hmattempts}");
    }
}