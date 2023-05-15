using System;

//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

namespace Problem_4_Number_Comparer
{
class NumberComparer
{
    static void Main()
    {

        Console.Write("Enter number\"a\": "); ;
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter number\"b\": "); 
        double b = double.Parse(Console.ReadLine());
        double graterNumber = Math.Max(a,b);
        Console.WriteLine("The greater number is: {0}.",graterNumber);
    }
}
}
