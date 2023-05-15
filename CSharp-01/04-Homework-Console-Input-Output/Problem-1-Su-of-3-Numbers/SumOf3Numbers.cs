using System;

namespace Problem_1_Su_of_3_Numbers
{
class SumOf3Numbers
{
    static void Main()
    {
        Console.Write("Enter \"a\": ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter \"b\": ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter \"c\": ");
        double c = double.Parse(Console.ReadLine());
        double sum = a + b + c;
        Console.WriteLine("The sum of three numbers is: " + sum);
        
    }
}
}
