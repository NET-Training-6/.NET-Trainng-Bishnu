class MethodLearner
{
    // 1. Method that returns nothing and takes no arguments
    public void Print()
    {
        Console.WriteLine("Hello There!");
        Console.WriteLine("I am inside simplest possible method");
    }

    // 2. Method that returns nothing and takes some argument(s)
    public void Print(string message)
    {
        Console.WriteLine("Hello There!");
        Console.WriteLine(message);
    }

    // 3. Method that returns something and takes some argument(s)
    public double Sum(double a, double b)
    {
        var s = a + b;
        return s;
    }

    // 4. Optional arguments
    public double CalculateAverage(int num1, int num2, int num3 = 0)
    {
        var sum = num1 + num2 + num3;
        var average = sum / 3;
        return average;
    }    

    // 5. Method that returns multiple values
    public (int, int) GetSumAndProduct(byte n1, byte n2)    // Tuple
    {
        var s = n1 + n2;
        var p = n1 * n2;
        return (s, p);
    }

    // 6. Expression bodied member
    public double Product(double a, double b) => a * b;
}
