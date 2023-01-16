using System.Collections.Generic;
using System;

class CollectionSolution
{
    // Create list of at least 10 numbers and print in console 
    // only the numbers multiple of 3 and 5.
    public void ListNumbers()
    {
        List<long> numbers = new List<long>() { 3, 23424, 15, 34534, 2131, 5, 454, 5675, 4564, 8, 35, 57, 343, 5675, 56, 44, 5, 242, 33 };

        foreach (long num in numbers)
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.Write($"{num} ");
            }
        }
    }

    // Create list of date of births of 8 people. Print those dobs in console oldest first.
    public void ListDobs()
    {
        List<DateTime> dobs = new List<DateTime>
        {
            new DateTime(1988, 12, 12),
            new DateTime(1981, 12, 13),
            new DateTime(1988, 1, 17),
            new DateTime(1973, 2, 22),
            new DateTime(1958, 3, 10),
            new DateTime(1965, 5, 20),
            new DateTime(1917, 8, 23),
            new DateTime(1938, 9, 12),
            new DateTime(1999, 11, 12),
            new DateTime(1920, 1, 12)
        };

        dobs.Sort();
        foreach(DateTime dob in dobs)
        {                       
            Console.WriteLine(dob.ToString("MMMM dd, yyyy"));
        }
    }
}
