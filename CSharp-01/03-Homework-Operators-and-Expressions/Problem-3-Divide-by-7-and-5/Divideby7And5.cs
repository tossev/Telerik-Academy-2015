using System;

// Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

namespace Problem_3_Divide_by_7_and_5
{
class Divideby7And5
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        bool devider1 = number % 5 == 0;
        bool devider2 = number % 7 == 0;
        Console.WriteLine(devider1 && devider2);
    }
}
}
