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

        ml.PrintMessage("638756");
        var s = ml.Sum(23423.242, 4535.23);

        var x = ml.IsEven(314243);
    }
}
