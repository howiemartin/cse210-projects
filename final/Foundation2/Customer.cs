class Customer
{
    private string _hmname;
    private Address _hmaddress;

    public Customer(string hmname, Address hmaddress)
    {
        _hmname = hmname;
        _hmaddress = hmaddress;
    }

    public bool IsInUSA()
    {
        return _hmaddress.IsInUSA();
    }

    public string GetName() 
    {
        return _hmname; 
    }
    public Address GetAddress()
    { 
        return _hmaddress; 
    }
}