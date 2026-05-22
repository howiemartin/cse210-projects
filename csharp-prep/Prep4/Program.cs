using System;
using System.Globalization;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        int hmnumb = -1;
        List<int> hmnumbs = new List<int>();

        while (hmnumb != 0 )
        {
            Console.WriteLine("Enter a number:");
            hmnumb = int.Parse(Console.ReadLine());
            if (hmnumb != 0)
            {
                hmnumbs.Add(hmnumb);
            }
            
        }

        float hmsum = hmnumbs.Sum();
        Console.WriteLine($"Sum: {hmsum}");
        
        int hmlargest = 0;
        int hmlistSize = hmnumbs.Count();
        foreach (int number in hmnumbs)
        {
            if (number > hmlargest)
            {
                hmlargest = number;
            }
        }
        float hmaverage = hmsum / hmlistSize;
        Console.WriteLine($"Average: {hmaverage}");
        Console.WriteLine($"Largest: {hmlargest}");
        
    }
}