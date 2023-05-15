using System;

// Write a program that finds the biggest of three numbers.

namespace Problem_05_The_Biggest_of_3_Numbers
{
class TheBiggestОf3Numbers
{
    static void Main()
    {
        Console.Write("Enter \"a\": ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter \"b\": ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter \"c\": ");
        double c = double.Parse(Console.ReadLine());

        bool checkA = a > b && a > c;
        bool checkB = b > a & b > c;
        bool checkC = c > a && c > b;

        if (checkA)
        {
            Console.WriteLine("Biggest number: {0}",a);
        }
        else if (checkB)
        {
            Console.WriteLine("Biggest number: {0}",b);
        }

        else if (checkC)
        {
            Console.WriteLine("Biggest number: {0}",c);
        }


    }
}
}
