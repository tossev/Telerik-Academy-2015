using System;

//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space.

namespace Problem_02_Numbers_Not_Divisible_by_3_and_7
{
class NumbersNotDivisibleBy3And7
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
            if (i % 3 != 0 && i % 7 != 0)
            {
                Console.Write("{0} ", i);
            }

        }
        Console.WriteLine();


    }
}
}
