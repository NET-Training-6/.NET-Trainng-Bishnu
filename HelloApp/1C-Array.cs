class ArrayLearner
{
    public void LearnArrays()
    {
        // One dimensional arrays
        byte[] ages = { 56, 89, 12, 34, 55, 33 };
        var x = ages[4];

        var l = ages.Length;
        Console.WriteLine(l);

        var numbers = new int[100];

        // Multi dimensional array
        var matrix = new double[20, 10];
        // 45   89
        // 33   55

        matrix[0, 0] = 45;
        matrix[0, 1] = 89;
        matrix[1, 0] = 33;
        matrix[1, 1] = 55;

        // Jagged array
        var jArray = new decimal[20][];
        jArray[0] = new decimal[] { 2, 3, 4, 5, 7 };
        jArray[1] = new decimal[] { 21, 30, 47 };        
    }
}
