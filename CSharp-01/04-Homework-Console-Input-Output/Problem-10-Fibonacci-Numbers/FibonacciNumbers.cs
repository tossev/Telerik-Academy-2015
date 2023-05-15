using System;

//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

namespace Problem_10_Fibonacci_Numbers
{
class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("How many members of the Fibonacci sequence do you want to print?\nEnter value: ");
        int n = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 1;
        int check = 0;
        Console.Write("The first {0} members of the Fibonacci sequence are: {1}, {2}, ", n, a, b);
        for (int i = 3; i <= n; i++) //започваме от 3'тото число, защото вече сме дали първите 2
        {
            check = a + b;
            Console.Write("{0}, ", check);
            a = b;
            b = check;
        }
        Console.WriteLine();
    }
}
}
