class Cigeratte
{
    // Members: fields, methods, properties
    
    // Full property definition 
    double price;
    public double Price
    {
        get
        {
            return price;
        }
        set
        {
            if (value > 0)
                price = value;
        }
    }

    // Auto-implemented property
    public string Vendor { get; set; }
    public string Vendor1 { get; private set; }
    public string Vendor2 { get; }
}

class GJHGLJ
{
    void Test()
    {
        Cigeratte khill1 = new();
        khill1.Price = -20;
    }
}