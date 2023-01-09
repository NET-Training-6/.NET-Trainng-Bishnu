
using System;

namespace Basics;
class Variable
{
    void LearnVariables()
    {
        // Numbers: integers and floating point
        // Integers
        byte a = 255; // Unsigned - positive values only 0-255
        short b = -2323;
        ushort b1 = 2323;
        int c = -4242424;
        uint c1 = 4242424;
        long d = 3223242425;
        ulong d1 = 3223242425;

        // Floating points
        float e = 345.6742342423424242342f;
        double f = 355335.445453790823798027498;
        decimal g = 35324526.352344242423245243523525252m;

        // Text
        string name = "Krishna Paudel";
        char gender = 'M';

        // Boolean
        bool areYouMale = true;
        bool? sex = null; // true => Male, false => Female, null => Others

        var x = 4546.678f;
        
        // Dates and times
        DateTime dob;
    }
}