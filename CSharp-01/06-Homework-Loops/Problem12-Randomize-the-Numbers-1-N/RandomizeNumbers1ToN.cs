using System;
using System.Collections.Generic;
//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

namespace Problem12_Randomize_the_Numbers_1_N
{
class RandomizeNumbers1ToN
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        Random r = new Random();
        List<int> randomNumbers = new List<int>();
        Console.Write("Randomized numbers in the range 1-{0}: ", n);

        for (int i =1 ; i <= n; i++)
        {
            int number;
            do
            {
                number = r.Next(1, n + 1);
            } while (randomNumbers.Contains(number));

            randomNumbers.Add(number);

            Console.Write("{0} ",number);
        }

        Console.WriteLine();
    }
}
}
