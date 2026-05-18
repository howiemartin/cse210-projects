using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        /*List<string> prompts = new List<string> 
        {
            "What did you do today that made someone else smile?", 
        "What do you wish you could have done better today?", 
        "What is something you did that made yourself proud?", 
        "Who was the first person you talked to today, and what did you say?", 
        "What was the last thing you did that made you smile today?"
        }; 

        // Random rand = new Random(); 

        // int promptNumb = rand.Next(0,6); */

        // Console.Write(prompts[promptNumb]); 
        string fileName = "myFile.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine("What did the muffin say to the other muffin?");
            string punchline = "I don't know, muffins don't talk.";
            outputFile.WriteLine(punchline);
              
        }
        string fileName = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string FirstName = parts[0];
            string LastName = parts[1];
        }
// string filePath = "myFile.txt";
//         string contents = File.ReadAllText(filePath);
//             Console.WriteLine(contents);
    }
// public static List<Person> ReadFromFile()
//     {
//         Console.WriteLine("Reading list from file...");
//         List<Person> perople = new List<Person>();
//         string filename = "people.txt";
//         string[] lines = System.IO.File.ReadAllLines(filename);
//         foreach (string lin in lines)
//         {
//             Console.WriteLine(line);
//         }
//     }

    
}