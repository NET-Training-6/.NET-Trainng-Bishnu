using System;
using System.Collections.Generic;

class CollectionLearner
{
    // List of something
    public void LearnLists()
    {
        List<int> numbers = new List<int>() { 43535, 456464, 456464 };
        numbers.Add(2342);
        numbers.Add(121);
        numbers.Add(6867);
        numbers.Add(3454);
        numbers.Remove(121);

        foreach(var num in numbers)
        {
            Console.WriteLine(num);
        }
        // Create list to store name of 10 people
        // Print all names in console in uppercase which are less than 5 characters in length
    }
    
    public void LearnDictionary()
    {
        // Key-value pairs
        Dictionary<string, byte> people = new();
        people.Add("Ram", 23);
        people.Add("Hari", 12);
        people.Add("Bam", 6);
        people.Add("Prakash", 24);
        people.Add("Bishnu", 35);
        people.Add("Bhoj", 89);
        people.Add("Sankar", 102);
        people.Add("Bikrant", 200);
        people.Add("Sankar1", 102);

        foreach (var person in people)
        {
            Console.WriteLine($"{person.Key} => {person.Value}");           // Bhoj => 34 
        }
    }

    // Create a data structure to store list of country name, 
    // its population and area in square metre
    
    public void TupleList()
    {
        //List<>
        List<(string, long, double)> countries = new();
        countries.Add(("Nepal", 2342535345, 1423434.45));
        countries.Add(("India", 2342342535345, 981423434.45));
        countries.Add(("China", 23999935345, 93481423434.45));
    }
}


class Country
{
    string name;
    long population;
    double area;
    //......
}
