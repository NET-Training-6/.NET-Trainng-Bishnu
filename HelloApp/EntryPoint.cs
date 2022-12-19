class EntryPoint
{
    public static void Main()
    {
        // var input = Console.ReadLine();        
        // var number = int.Parse(input);

        // if(number % 2 == 0)
        // {
        //     Console.WriteLine(number + " is even");
        // }
        // else
        // {
        //     Console.WriteLine(number + " is odd");
        // }

        // // Find if user supplied number is multiple of 3 and 5
        // Console.Write("Enter number:");
        // var input = Console.ReadLine();
        // var n = int.Parse(input);

        // // If divisible by 3 => Only multiple of 3
        // // If divisible by 5 => Only multiple of 5
        // // If not divisible by 3 and 5 => Not multiple of 3 or 5


        // if (n % 3 == 0 && n % 5 == 0)
        // {
        //     Console.WriteLine(n + " is multiple of 3 and 5.");
        // }
        // else
        // {
        //     if (n % 3 == 0)
        //     {
        //         Console.WriteLine("Only multiple of 3");
        //     }
        //     else if (n % 5 == 0)
        //     {
        //         Console.WriteLine("Only multiple of 5");
        //     }
        //     else
        //     {
        //         Console.WriteLine(n + " is not divisible by 3 or 5.");
        //     }
        // }


        // CW - Calculate compound interest for pricipal amount, time and rate given by user.
        Console.Write("Principle:");
        var pText = Console.ReadLine();
        var p = double.Parse(pText);

        Console.Write("Time(Years):");
        var tText = Console.ReadLine();
        var t = double.Parse(tText);

        Console.Write("Rate(%):");
        var rText = Console.ReadLine();
        var r = double.Parse(rText);

        var ci = p * Math.Pow((1 + r / 100), t) - p;
        // String interpolation
        Console.WriteLine($"Compound Interest of {p} for {t} years at {r}% is {ci}");

        Console.ReadKey();
    }
}
