class Event
{
    private string _hmtitle;
    private string _hmdescription;
    private string _hmdate;
    private string _hmtime;
    private Address _hmaddress;

    public Event(string hmtitle, string hmdescription, string hmdate, string hmtime, Address hmaddress)
    {
        _hmtitle = hmtitle;
        _hmdescription = hmdescription;
        _hmdate = hmdate;
        _hmtime = hmtime;
        _hmaddress = hmaddress;
    }

    public string GetStandardDetails()
    {
        return $"Title: {_hmtitle}\nDescription: {_hmdescription}\nDate: {_hmdate}\nTime: {_hmtime}\nAddress: {_hmaddress.GetFullAddress()}";
    }

    public string GetShortDescription()
    {
        return $"Type: {this.GetType().Name}\nTitle: {_hmtitle}\nDate: {_hmdate}";
    }
}