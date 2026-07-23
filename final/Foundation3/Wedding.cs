class Wedding : Event
{
    private string _hmbestMan;
    private string _hmmaidOfHonor;

    private int _hmcapacity;

    public Wedding(string hmtitle, string hmdescription, string hmdate, string hmtime, Address hmaddress, string hmbestMan, string hmmaidOfHonor, int capacity) 
        : base(hmtitle, hmdescription, hmdate, hmtime, hmaddress)
    {
        _hmmaidOfHonor = hmmaidOfHonor;
        _hmbestMan = hmbestMan;
        _hmcapacity = capacity;
    }

    public string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Wedding\nBest Man: {_hmbestMan}\nMaid of Honor: {_hmmaidOfHonor}\nCapacity: {_hmcapacity}";
    }
}