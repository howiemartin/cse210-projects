using System;

class Program
{
    static void Main(string[] args)
    {
        int hmselection = 0;
        bool hmrunning = true;

        Journal journal1 = new Journal();

        while (hmrunning)
        {
        
        Console.WriteLine("What would you like to do?\n1. Write Entry\n2. Display Entries\n3. Load File\n4. Save Entries to File\n5. Quit");

        hmselection = int.Parse(Console.ReadLine());
        
        if (hmselection == 1){journal1.NewEntry();}

        else if (hmselection == 2){journal1.Display();}

        else if (hmselection == 3){journal1.ReadFile();}

        else if (hmselection == 4){journal1.SaveFile();}

        else
            {
                Console.WriteLine("Are you sure you want to quit? Make sure you saved.\n1. Quit\n2. Return to Menu");
                int hmquitting = int.Parse(Console.ReadLine());
                if (hmquitting == 1)
                {
                    Console.WriteLine("Thank you!");
                    Environment.Exit(0);
                }
            }
    }
}
}