class BBQ : Event
{
    private int _hmhotdogs;
    private int _hmburgers;

    private int _hmcapacity;

    public BBQ(string hmtitle, string hmdescription, string hmdate, string hmtime, Address hmaddress, int hmhotdogs, int hmburgers, int hmcapacity) 
        : base(hmtitle, hmdescription, hmdate, hmtime, hmaddress)
    {
        _hmhotdogs = hmhotdogs;
        _hmburgers = hmburgers;
        _hmcapacity = hmcapacity;
    }

    public string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Barbeque\nNumber of Hotdogs: {_hmhotdogs}\nNumber of Burgers: {_hmburgers}\nCapacity: {_hmcapacity}";
    }
}