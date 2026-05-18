using System.IO;
using System.Runtime.CompilerServices;
public class Journal
{

    public List<Entry> _hmentries = new List<Entry>();
    Entry entry1 = new Entry();
    public void NewEntry()
    {
        
        entry1.WriteEntry();
        _hmentries.Add(entry1);
    }

    public void Display()
    {
        // figure out how to display the list. It isn't working.
        foreach (Entry item in _hmentries)
        {
            Console.WriteLine($"---------------------------\n{item._hmdateTime}\n\n'{item._hmprompt}'\n\n> {item._hmentry}\n---------------------------");
        }
        

    }

    public void SaveFile()
    {
        /// <summary>
        /// saves the entries written to a file that the user names.
        /// </summary>
        Console.WriteLine("Enter name of the csv file you want to save to.\nIf you enter an already existing file, it will be overwritten.");
        string _hmfileName = Console.ReadLine();
        
        

    // This opens the file. If it doesn't exist, C# creates it for you!
    using (StreamWriter hmoutputFile = new StreamWriter(_hmfileName))
    {
        string hmsaveLine;
        foreach (Entry item in _hmentries)
            {
                hmsaveLine =  $@"---------------------------
{item._hmdateTime}
                
'{item._hmprompt}'
                
> {item._hmentry}
---------------------------~|";
                hmoutputFile.WriteLine(hmsaveLine);
            }
    }

    }

    public void ReadFile()
    {
        Console.WriteLine("Enter name of csv file you want to load.");
        string _hmfileName = Console.ReadLine();
        
            string hmwholeFile = File.ReadAllText(_hmfileName);
            string[] hmentryItems = hmwholeFile.Split("~|", StringSplitOptions.RemoveEmptyEntries);
            
            foreach (string item in hmentryItems)
            {
                
                Entry entry2 = new Entry();
                string hmitem = item.Trim();
                string[] hmlines = hmitem.Split("\n");
            if (hmlines.Length < 6)
                {
                    continue; 
                }
                entry2._hmdateTime = hmlines[1].Trim();
                entry2._hmprompt = hmlines[3].Replace("'", "").Trim();
                entry2._hmentry = hmlines[5].Replace(">", "").Trim();

            _hmentries.Add(entry2); 
                
                
            
            
            }
    }

}