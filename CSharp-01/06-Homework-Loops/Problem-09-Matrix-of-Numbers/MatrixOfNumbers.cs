using System;
//Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix like in the examples below. Use two nested loops.

namespace Problem_09_Matrix_of_Numbers
{
class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Enter \"n\" in range \"1 <= n <= 20\": ");
        int n = int.Parse(Console.ReadLine());
        while ((n<1) || (n>20) )
        {
            Console.Write("Wrong input value!\nEnter another number: ");
            n = int.Parse(Console.ReadLine());

        }
        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j < n + i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }

          
    }
}
}
