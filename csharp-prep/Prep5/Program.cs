using System;

class Program
{
    static void Main(string[] args)
    {
        void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        string PromptUserName()
        {
            Console.WriteLine("Enter your name: ");
            return Console.ReadLine();
        }
        int PromptUserNumber()
        {
            Console.WriteLine("Enter your favorite number: ");
            return int.Parse(Console.ReadLine());
        }
        
        void PromptUserBirthYear(out int hmyear)
        {
            Console.WriteLine("Enter your birth year: ");
            hmyear = int.Parse(Console.ReadLine());
        }
        int SquareNumber(int x)
        {
            return x * x;
        }
        void DisplayResult()
        {
           DisplayWelcome();
           string hmname = PromptUserName();
           int hmnumb = PromptUserNumber();
           PromptUserBirthYear(out int hmyear);
           Console.WriteLine($"{hmname}, the square of your number is {SquareNumber(hmnumb)}.\n{hmname}, you will turn {2026 - hmyear} this year.");
        }
DisplayResult();




        
    }
}