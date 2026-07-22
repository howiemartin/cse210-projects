class Address
{
    private string _hmstreet;
    private string _hmcity;
    private string _hmstateProvince;
    private string _hmcountry;

    public Address(string hmstreet, string hmcity, string hmstateProvince, string hmcountry)
    {
        _hmstreet = hmstreet;
        _hmcity = hmcity;
        _hmstateProvince = hmstateProvince;
        _hmcountry = hmcountry;
    }

    public bool IsInUSA()
    {
        string lowerCountry = _hmcountry.ToLower();

        if (lowerCountry == "usa" || lowerCountry == "united states")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetFullAddress()
    {
        return $"{_hmstreet}\n{_hmcity}, {_hmstateProvince}\n{_hmcountry}";
    }
}