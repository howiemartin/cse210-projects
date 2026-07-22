class Product
{
    private string _hmname;
    private string _hmproductId;
    private double _hmprice;
    private int _hmquantity;

    public Product(string hmname, string hmproductId, double hmprice, int hmquantity)
    {
        _hmname = hmname;
        _hmproductId = hmproductId;
        _hmprice = hmprice;
        _hmquantity = hmquantity;
    }

    public double GetTotalCost()
    {
        return _hmprice * _hmquantity;
    }

    public string GetName() 
    { 
        return _hmname; 
    }
    public string GetProductId() 
    { 
        return _hmproductId; 
    }
}