using System;
using System.Linq; // За да ползваме Math.Max();

namespace Problem_06_The_Biggest_of_Five_Numbers
{
class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.Write("Enter \"a\": ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter \"b\": ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter \"c\": ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("Enter \"d\": ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("Enter \"e\": ");
        double e = double.Parse(Console.ReadLine());
        double[] numbers = {a, b, c, d, e };
        double biggestNumber = numbers.Max();
        if (biggestNumber == a)
        {
            Console.WriteLine("Biggest: {0}",a);
        }
        else if (biggestNumber == b)
        {
            Console.WriteLine("Biggest: {0}",b);
        }
        else if (biggestNumber == c)
        {
            Console.WriteLine("Biggest: {0}", c);
        }
        else if (biggestNumber == d)
        {
            Console.WriteLine("Biggest: {0}", d);
        }
        else if (biggestNumber == e)
        {
            Console.WriteLine("Biggest: {0}", e);
        }


    }
}
}
