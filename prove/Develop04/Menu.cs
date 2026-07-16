class Menu
{
    public string DisplayMenu()
    {
        Console.Clear();
        return "Activity Options:\n1)   Breathing Activity\n2)   Reflection Activity\n3)   Listing Activity\n4)   Quit";
    }
        private int _hmactivityLog;
        private string _hmactivityName;
        public Menu(int hmlog, string hmname)
    {
        _hmactivityLog = hmlog;
        _hmactivityName = hmname;
    }
    
        public int AddToActivityLog()
    {
        return _hmactivityLog++;
    }
    public void DisplayLog()
    {
        
        if (_hmactivityLog == 1)
        {
            Console.WriteLine($"You did the {_hmactivityName} {_hmactivityLog} time.");
        }
        else if (_hmactivityLog >= 2)
        {
            Console.WriteLine($"You did the {_hmactivityName} {_hmactivityLog} times.");
        }
    }
        static Menu hmbreathingLog = new Menu(0, "Breathing Activity");
        static Menu hmreflectionLog = new Menu(0, "Reflection Activity");
        static Menu hmlistingLog = new Menu(0, "Listing Activity");
    public void ActivitySelect(int hmselection)
    {
        
        if (hmselection == 1)
        {
            BreathingActivity hmbreathing = new BreathingActivity();
            
            hmbreathingLog.AddToActivityLog();
            hmbreathing.Run();
        }
        else if (hmselection == 2)
        {
            ReflectionActivity hmreflection = new ReflectionActivity();
            hmreflectionLog.AddToActivityLog();
            hmreflection.Run();
        }
        else if (hmselection == 3)
        {
            ListingActivity hmlisting = new ListingActivity();
            hmlistingLog.AddToActivityLog();
            hmlisting.Run();
        }
        else
        {
            
            Activity hmactivity = new Activity("Minfulness Program", "Closing Program");
            hmactivity.EndMessage();
            hmbreathingLog.DisplayLog();
            hmreflectionLog.DisplayLog();
            hmlistingLog.DisplayLog();
            hmactivity.Spinner(3);
            Environment.Exit(0);
        }
    }
}