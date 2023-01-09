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
}
