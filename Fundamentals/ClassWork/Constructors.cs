// Create a "Room" class with following:
//  - At least 4 fields
//  - Two methods 
//      - First method takes no parameter and return some value
//      - Second method should return value and takes two parameters
//  - Caller should be able to create objects/instances of this class as follows:\
//      var room1 = new Room();
//      var room2 = new Room(provide all 4 data fields);

class Room
{
    double length;
    double width;
    string wallColor;
    byte roomNumber;

    public Room(double l, double w, string wc = "Green", byte rn = 1)
    {
        length = l;
        width = w;
        wallColor = wc;
        roomNumber = rn;
    }

    public double GetArea()
    {
        var area = length * width;
        return area;
    }

    public string ChangeColor(int roomNumber, string colorName)
    {
        var message = $"Room number {roomNumber} is painted with {colorName} color.";
        return message;
    }
}