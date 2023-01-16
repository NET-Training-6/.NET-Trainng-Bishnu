// Language INtegrated Query - LINQ
// Way/technique to query collections

using System;
using System.Collections.Generic;
using System.Linq;

class Linq
{
    int[] numbers = { 2, 0, 3, 4, 5, 56, 12, 10, 23, 45, 67, 40 };
    List<string> names = new() { "Bishnu", "Sagar", "Prem", "Kran", "Sajan", "Naresh" };

    public void Test()
    {
        // Filters
        //1. Get all even numbers in "numbers"
        var evenNums = numbers.Where(num => num % 2 == 0);

        //2. Get all odd numbers in "numbers"
        var oddNums = numbers.Where(num => num % 2 != 0);

        //3. Get all numbers which ends with "0"        
        var numsEnding0 = numbers.Where(num => num.ToString().EndsWith("0"));

        // Projections
        //4. Get squares of all numbers in "numbers" array
        var squares = numbers.Select(num => num * num);

        foreach (var n in squares)
        {
            Console.WriteLine(n);
        }

        //5. Get squares of elements which are greater than 50

        //6. Get all person names which starts with letter 'A' in "names" list
        var namesStartingA = names.Where(n => n.StartsWith("a", StringComparison.CurrentCultureIgnoreCase));

        //7. From "names" list, get all person names with less than 4 characters 
        // and convert them to uppercase

    }
}