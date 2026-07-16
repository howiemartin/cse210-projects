/*
Name: Howard Martin
Course: CSE 210
Project: Mindfulness Program
Exceeding Expectation: I wrote code that keeps a log of how many times the user did each activity. It prints nothing if someone didn't do a certain activity and is grammatically correct for the number of times done. I did this focusing on object-oriented programming so I did not have to create redundant code and it also works well if I made another activity. 
*/


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfullness Program.");
        while (true)
        {
            Menu hmmenu = new Menu(0, "");
        Console.WriteLine(hmmenu.DisplayMenu());
        hmmenu.ActivitySelect(int.Parse(Console.ReadLine()));
        
        }
        
    }
}