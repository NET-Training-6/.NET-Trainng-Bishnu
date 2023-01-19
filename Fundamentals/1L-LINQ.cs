// Language INtegrated Query - LINQ
// Way/technique to query collections

using System;
using System.Collections.Generic;
using System.Linq;

class Linq
{
    int[] numbers = { 2, 0, 3, 4, 5, 56, 12, 10, 23, 45, 67, 40 };
    List<string> names = new() { "Bishnu", "Sagar", "Prem", "Kran", "Sajan", "Naresh" };

    List<Employee> employees = new()
    {
        new Employee { Name = "Ram Basnet", Age = 23, Department = "HR", Designation = "Software Engineer" },
        new Employee { Name = "Shyam Rana", Age = 32, Department = "HR", Designation = "Sr. Software Engineer" },
        new Employee { Name = "Prabin Thapa", Age = 25, Department = "R&D", Designation = "QA" },
        new Employee { Name = "Govinda Giri", Age = 20, Department = "R&D", Designation = "Software Engineer" },
        new Employee { Name = "Prakash Saud", Age = 20, Department = "R&D", Designation = "QA" }
    };

    public void Test()
    {
        // Filters
        //1. Get all even numbers in "numbers"
        var evenNums = numbers.Where(num => num % 2 == 0);      // Method systax

        evenNums =  from num in numbers              // Expression syntax
                    where num % 2 == 0
                    select num;

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

    public void LINQDay2()
    {
        // Quantifiers: Any, All
        // 1. Find if "numbers" array contain any even number
        var hasEven = numbers.Any(n => n % 2 == 0);

        // 2. Find if "numbers" array has all even numbers
        var allEven = numbers.All(n => n % 2 == 0);

        // 3. Get first 5 elements from numbers
        var firstFive = numbers.Take(5);

        // 4. Get 5 elements skipping first 2 from numbers
        var x = numbers.Skip(2).Take(5);
    }

    public void LearnToQueryComplexCollection()
    {
        // 1. Get all employees in HR department
        var x = employees.Where(e => e.Department == "HR");

        // 2. Get names of employees in HR department
        var x1 = employees.Where(e => e.Department == "HR").Select(e => e.Name);
        
        
        // 3. Get all software engineers under age of 22
        var y = employees.Where(e => e.Designation == "Software Engineer" && e.Age < 22);

        foreach(var e in y)
        {
            Console.WriteLine($"{e.Name}");
        }
    }
}


public class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Department { get; set; }
    public string Designation { get; set; }
}
