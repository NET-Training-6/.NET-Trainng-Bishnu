class MethodLearner
{
    // Method that returns nothing and takes no arguments
    public void Print()
    {
        Console.WriteLine("Hello There!");
        Console.WriteLine("I am inside simplest possible method");
    }

    // Method that returns nothing and takes some argument(s)
    public void PrintMessage(string message)
    {
        Console.WriteLine("Hello There!");
        Console.WriteLine(message);
    }

    // Method that returns something and takes some argument(s)
    public double Sum(double a, double b)
    {
        var s = a + b;
        return s;
    }

    // Write a method takes number as a argument and
    // and returns if number is even or odd   
    public bool IsEven(int number)
    {
        // Implementation 1
        // if(number % 2 == 0)
        //     return true;
        // else
        //     return false;

        // Implementation 2
        // var y = number % 2 == 0 ? true : false;
        // return y;

        // Implementation 3
        // return number % 2 == 0;

        return (number & 1) == 0;
    }
}
