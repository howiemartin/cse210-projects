class Order
{
    private List<Product> _hmproducts;
    private Customer _hmcustomer;

    public Order(Customer hmcustomer)
    {
        _hmcustomer = hmcustomer;
        _hmproducts = new List<Product>();
    }

    public void AddProduct(Product hmproduct)
    {
        _hmproducts.Add(hmproduct);
    }

    public double GetTotalPrice()
    {
        double hmtotal = 0;
        foreach (Product hmproduct in _hmproducts)
        {
            hmtotal += hmproduct.GetTotalCost();
        }
        if (_hmcustomer.IsInUSA())
        {
            hmtotal += 5.00;
        }
        else
        {
            hmtotal += 35.00;
        }
        return hmtotal;
    }

    public string GetPackingLabel()
    {
        string hmlabel = "Packing Label:\n";
        foreach (Product hmproduct in _hmproducts)
        {
            hmlabel += $"- {hmproduct.GetName()} (ID: {hmproduct.GetProductId()})\n";
        }
        return hmlabel;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_hmcustomer.GetName()}\n{_hmcustomer.GetAddress().GetFullAddress()}";
    }
}