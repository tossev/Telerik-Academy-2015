using System;

// Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
//area = Pi*r*r
//Circumference =2*Pi*r
namespace Problem3_Circle_Perimeter_And_Area
{
class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter the radius \"r\" of a circle: ");
        double radius = double.Parse(Console.ReadLine());
        double area = Math.PI * Math.Pow(radius, 2);
        double perimeter = 2 * Math.PI * radius;
        Console.WriteLine("The area of the circle is: {0:0.00}.\nThe perimeter of the circle is: {1:F2}.", area, perimeter);
    }
}
}
