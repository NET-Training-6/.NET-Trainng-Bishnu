class Methods
{
    // Write a method takes number as a argument and
    // and returns if number is even or odd   
    public bool IsEven(int number)
    {
        if(number % 2 == 0)
            return true;
        else
            return false;  
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
}
