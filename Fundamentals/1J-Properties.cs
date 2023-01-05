class Cigeratte
{
    string vendor;
    
    // Full property definition 
    double price;
    public double Price
    {
        get
        {
            return price;
        }
        private set
        {
            if (value > 0)
                price = value;
        }
    }
}

class GJHGLJ
{
    void Test()
    {
        Cigeratte khill1 = new();
        khill1.Price = -20;
    }
}