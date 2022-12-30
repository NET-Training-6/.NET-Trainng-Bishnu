class MethodLearner
{
    // Method that returns nothing and takes no arguments
    public void Print()
    {
        Console.WriteLine("Hello There!");
        Console.WriteLine("I am inside simplest possible method");
    }

    // Method that returns nothing and takes some argument(s)
    public void Print(string message)
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
        if(number % 2 == 0)
            return true;
        else
            return false;  
    }

    // Optional arguments
    public double CalculateAverage(int num1, int num2, int num3 = 0)
    {
        var sum = num1 + num2 + num3;
        var average = sum / 3;
        return average;
    }
    
    // Write a method that takes an number array and returns average of those.
    public double CalculateAverage(params int[] numbers)   // [3, 5, 1, 8, 9]
    {
        var sum = 0;
        foreach(var num in numbers)
        {
            sum = sum + num;
        }

        var average = sum / numbers.Length;
        return average;
    }

    // Write a method that takes bunch of numbers and returns minimum among them.
    public double CalculateMinimum(params int[] numbers)     // [3, 5, 1, 8, 9]
    {
        var min = numbers[0];
        foreach(var num in numbers)
        {
            if(num < min)
            {
                min = num;
            }
        }

        return min;
    }

    // Write a method to find sum and product of two numbers
    public (int, int) GetSumAndProduct(byte n1, byte n2)    // Tuple
    {
        var s = n1 + n2;
        var p = n1 * n2;
        return (s, p);
    }

}
