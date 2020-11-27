using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// * Write a program that finds in given array of integers a sequence of given sum S (if present).


namespace Problem_10_Find_sum_in_array
{
    class FindSumInArray
    {
        static void Main(string[] args)
        {


            Console.Write("Enter the lenght of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter value #{0}: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the sum you are looking for: ");
            int s = int.Parse(Console.ReadLine());
            bool hasSum = false;
            int seq = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    seq += array[j];
                    if (seq == s)
                    {
                        hasSum = true;
                        Console.Write("The sequence of numbers that has the sum of {0} is: ", s);
                        for (int print = i; print <= j; print++)
                        {
                            Console.Write("{0} ", array[print]);
                        }
                        Console.WriteLine();
                    }
                }
                seq = 0;
            }
            if (!hasSum)
            {
                Console.WriteLine("There is no such sequence!");
            }
           




        }
    }
}
