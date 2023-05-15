using System;

//Write an expression that calculates trapezoid's area by given sides a and b and height h.

namespace Problem9_Trapezoids
{
class Trapezoids
{
static void Main()
{
    Console.Write("Enter side \"a\": ");
    double a = double.Parse(Console.ReadLine());
    Console.Write("Enter side \"b\": ");
    double b = double.Parse(Console.ReadLine());
    Console.Write("Enter height \"h\": ");
    double h = double.Parse(Console.ReadLine());
    double area = (((a + b)) / 2) * h;
    Console.WriteLine("The trapezoids area is: " + area);

}
}
}
