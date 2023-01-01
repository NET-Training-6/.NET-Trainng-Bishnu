class Loop
{
    public void LearnLoops()
    {
        // for (byte counter = 1; counter <= 100; counter++)
        // {
        //     Console.Write($"{counter}\t");
        // }

        // char input = 'y';
        // while (input == 'y')
        // {
        //     Console.Write("I am running again");

        //     Console.Write("Run again?");
        //     input = Console.ReadKey().KeyChar;
        // }

        byte[] ages = { 2, 45, 67, 12, 33, 90 };

        byte youngest = byte.MaxValue;
        foreach (var age in ages)
        {
            if (age < youngest)
            {
                youngest = age;
            }
        }
        Console.WriteLine(youngest);

    }
}