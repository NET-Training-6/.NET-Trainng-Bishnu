using Basics;
class EntryPoint
{
    public static void Main()
    {
        // Person person1 = new();
        // person1.name = "Ram Karki";
        // person1.age = 23;

        // // Person person2 = new();        
        // Person person3 = new();
        // Person person4 = new();
        // Person person5 = new();
        // Person person6 = new();
        // Person person7 = new();
        // Person person8 = new();

        // ArrayLearner al = new();
        // al.LearnArrays();

        MethodLearner ml = new();
        ml.Print();
        ml.Print();
        ml.Print("638756");

        var s = ml.Sum(23423.242, 4535.23);
        var x = ml.IsEven(314243);

        // Named arguements
        var y1 = ml.CalculateAverage(num2: 3434, num1: 345353, num3: 67868);
        var y2 = ml.CalculateAverage(3434, 3453523);

        int[] marks = { 67, 78, 98, 45, 70, 80 };
        int[] marks1 = { 67, 78, 98, 45, 70, 80, 34, 34_534, 345_353, 3453 };
        //var z = ml.CalculateAverage(new int[] { 67, 78, 98, 45, 70, 80 });
        var z1 = ml.CalculateAverage(67, 78);
        var z2 = ml.CalculateAverage(67, 78, 98, 45, 70, 80, 34, 34_534, 345_353, 3453);

        var (sum, product) = ml.GetSumAndProduct(34, 56);
        

    }
}
