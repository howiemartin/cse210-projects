class Address
{
    private string _hmstreet;
    private string _hmcity;
    private string _hmstate;
    private string _hmcountry;

    public Address(string hmstreet, string hmcity, string hmstate, string hmcountry)
    {
        _hmstreet = hmstreet;
        _hmcity = hmcity;
        _hmstate = hmstate;
        _hmcountry = hmcountry;
    }

    public string GetFullAddress()
    {
        return $"{_hmstreet}, {_hmcity}, {_hmstate}, {_hmcountry}";
    }
}