// Write a class for rectangle, this class should have methods to calulate
// area and perimeter.

using System;

class Rectangle: IShape
{
    double length;
    double width;

    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }

    public double GetArea() => length * width;
    public double GetPerimeter() => 2 * (length + width);
    public virtual void PrintDetails()
    {
        Console.WriteLine($"I am rectangle with L={length} and B={width}.");
    }
}

// Write a class for square, this class should have methods to calulate
// area and perimeter.
class Square : Rectangle
{
    double side;
    public Square(double s) : base(s, s)
    { 
        side = s;             
    }

    public override void PrintDetails()
    {
        Console.WriteLine($"I am square with side S={side}.");
    }
}

// Write a class for Triangle, this class should have methods to calulate
// area and perimeter.
class Triangle: IShape
{
    double a, b, c;

    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double GetPerimeter() => a + b + c;
    public double GetArea() 
    {
        var s = (a + b + c) / 2;
        var area = Math.Sqrt(s * (s - a) * (s -b) * (s -c));
        return area;
    } 

    public void PrintDetails()
    {
        Console.WriteLine($"I am traingle with sides A={a}, B={b} and C={c}.");
    }
}

// Display details of all the 2D shapes
interface IShape
{
    public void PrintDetails();
}
