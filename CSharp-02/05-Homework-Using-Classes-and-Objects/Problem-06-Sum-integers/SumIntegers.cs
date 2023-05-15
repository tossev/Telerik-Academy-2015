using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.

namespace Problem_06_Sum_integers
{
    class SumIntegers
    {
        private static long SumOfIntegers(string sequence)
        {
            uint[] integers = sequence.Split(' ').Select(uint.Parse).ToArray();
            long sum = 0;

            for (int i = 0; i < integers.Length; i++)
            {
                sum += integers[i];
            }

            return sum;
        }

        static void Main()
        {
            Console.Write("Enter a sequence of positive integer values separated by spaces: ");
            string sequence = Console.ReadLine();
            long sum = SumOfIntegers(sequence);
            Console.WriteLine(sum);
        }

    }
}
