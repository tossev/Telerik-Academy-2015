﻿using System;

//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.

namespace Problem_8_Numbers_From_1_to_n
{
class NumbersFrom1ToN
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("The numbers between 1 and {0} are:", number);
        for (int i = 1; i <= number; i++)
        {   
            Console.WriteLine(i);
        }

    }
}
}
