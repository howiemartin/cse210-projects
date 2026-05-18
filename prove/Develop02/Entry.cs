public class Entry
{
    // first, get a random prompt
    public string _hmprompt;
    public string _hmentry;
    public string _hmdateTime;


RandomPrompt hmprompt = new RandomPrompt();
    public void WriteEntry()
    {
        /// <summary>
/// Pulls a random prompt from the list and writes it.
/// User types in the entry
/// Saves the Date and time.
/// </summary>
        
        _hmprompt = hmprompt.SelectPrompt();
        Console.WriteLine(_hmprompt);

        _hmentry = Console.ReadLine();

        _hmdateTime = DateTime.Now.ToString("dddd, MMMM dd, yyyy - h:mm tt");
    }
}