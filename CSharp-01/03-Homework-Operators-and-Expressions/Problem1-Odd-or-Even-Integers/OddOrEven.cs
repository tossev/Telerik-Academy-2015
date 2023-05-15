using System;

namespace Problem1_Odd_or_Even_Integers
{
class OddOrEven
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        bool even = (number % 2 == 0);
        Console.WriteLine(even ? "Even" : "Odd");
        
    }
}
}
