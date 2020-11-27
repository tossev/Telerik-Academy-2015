using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// * Write a program that finds the maximal increasing sequence in an array.

namespace Problem_05_Maximal_increasing_sequence
{
    class MaximalIncreasingSequence
    {
        static void Main()
        {

            //Console.Write("Enter the lenght of the array: ");
            //int n1 = int.Parse(Console.ReadLine());
            //int[] array = new int[n1];
            //int count = 0;
            ////int bestLenght = 0;
            ////int minLenght = 0;
            //int nums = 0;
            //int maxStart = 0;
            //int currentStart = 0;
            //int sequenceLength = 1;

            //for (int i = 0; i < n1; i++)
            //{
            //    Console.Write("Enter value #{0}: ", i + 1);
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            int[] array = { 3, 2, 3, 4, 2, 2, 4 };
            int indexEnd = 0;
            int lenght = 1;
            int bestLenght = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    lenght++;
                }
                else
                {
                    if (lenght > bestLenght)
                    {
                        bestLenght = lenght;
                        indexEnd = i;
                    }
                    lenght = 1;
                }
            }
            if (lenght > bestLenght)
            {
                bestLenght = lenght;
                indexEnd = array.Length - 1;
            }
            lenght = 1;
            Console.Write("The longest sequence is: ");
            for (int i = indexEnd - bestLenght + 1; i < indexEnd + 1; i++)
            {
                Console.Write("{0} ", array[i]);
            }

            Console.WriteLine();
           

        }
    }
}
