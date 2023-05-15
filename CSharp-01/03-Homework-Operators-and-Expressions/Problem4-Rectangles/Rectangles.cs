using System;

//Write an expression that calculates rectangle’s perimeter and area by given width and height.

namespace Problem4_Rectangles
{
class Rectangles
{
    static void Main()
    {
        Console.Write("Enter width: ");
        double widht = double.Parse(Console.ReadLine());
        Console.Write("Enter high: ");
        double high = double.Parse(Console.ReadLine());
        double perimeter = (widht * 2) + (high * 2);
        double area = widht * high;
        Console.WriteLine("Rectangles perimeter is: {0}.\nRectangles area is: {1}.",perimeter,area);
    }
}
}
