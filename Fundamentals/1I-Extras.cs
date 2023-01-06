// Constants

public class Car
{
    public Car()
    {
        gears = 5;
    }

    string vendor;
    string category;
    public double price;
    const byte noOfWheels = 4;  // Compile-time
    readonly byte gears = 6;    // Runtime
    static byte seats = 4;

    public void Test()
    {
        //noOfWheels = 5;
        // Car car1 = new();
        // car1.vendor = "TaTa";

        // Car.seats = 5;
        // Console.WriteLine();

        // string name = "Kishan Karki";   // initials: KK
        // var parts = name.Split(" ");
        // var initials = parts[0][0] + parts[1][0];
    }
}


// Static
// Access modifiers: 
// public - Highest visibility, jo le ni pau6a yelai
// internal - Project/assembly level ko visibility
// , private, protected