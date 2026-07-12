//Name: Howard Martin
//CSE 210 - 01
//Scripture Memorizer
//Show of Creativity: I changed my hideRandomWord() method so it always hides a word that hasn't already been hidden. 
// to ensure it does not infinitely loop at the end, I put a limit of 50 tries before it gives up trying to hide another word.


using System;

class Program
{
    static void Main(string[] args)
    {
        Reference hmRef = new Reference("2 Nephi", "2", "8");

        Scripture hmScripture = new Scripture(hmRef, "Wherefore, how great the importance to make these things known unto the inhabitants of the earth, that they may know that there is no flesh that can dwell in the presence of God, save it be through the merits, and mercy, and grace of the Holy Messiah, who layeth down his life according to the flesh, and taketh it again by the power of the Spirit, that he may bring to pass the resurrection of the dead, being the first that should rise.");
        bool hmcont = true;
        while (hmcont == true)
        {
            Console.Clear();
            Console.WriteLine(hmScripture.displayScripture());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");


            string hmcontstr = Console.ReadLine();
            if (hmcontstr == "quit")
            {
                hmcont = false;
            }
            else
            {
                hmScripture.hideRandWord();
            }

        }
    }
}