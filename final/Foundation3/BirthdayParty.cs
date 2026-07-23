class BirthdayParty : Event
{
    private string _hmbirthdayPerson;
    private string _hmcakeFlavor;

    private int _hmcapacity;

    public BirthdayParty(string hmtitle, string hmdescription, string hmdate, string hmtime, Address hmaddress, string hmbirthdayPerson, string hmcakeFlavor, int hmcapacity) 
        : base(hmtitle, hmdescription, hmdate, hmtime, hmaddress)
    {
        _hmbirthdayPerson = hmbirthdayPerson;
        _hmcakeFlavor = hmcakeFlavor;
        _hmcapacity = hmcapacity;
    }

    public string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Birthday Party\nBirthday we are Celebrating: {_hmbirthdayPerson}\nBirthday Cake Flavor: {_hmcakeFlavor}\nCapacity: {_hmcapacity}";
    }
}