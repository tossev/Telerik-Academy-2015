using System;

//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.

namespace Problem_01_Numbers_from_1_to_N
{
class NumbersFrom1ToN
{
    static void Main()
    {
        Console.Write("Enter positive number: ");
        int number = int.Parse(Console.ReadLine());
        while (number < 0)
        {
            Console.Write("Wrong input format! Enter another number: ");
            number = int.Parse(Console.ReadLine());
        }
        for (int i = 1; i <= number; i++)
        {
            Console.Write("{0} ",i);
        }
        Console.WriteLine();
    }
}
}
