using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// * Write a program that finds the maximal sequence of equal elements in an array.


namespace Problem_04_Maximal_Sequence
{
    class MaximalSequence
    {
        static void Main()
        {
            Console.Write("Enter the lenght of the array: ");
            int n1 = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n1];
            for (int i = 0; i < n1; i++)
            {
                Console.Write("Enter value #{0}: ", i + 1);
                arr1[i] = int.Parse(Console.ReadLine());
            }

            int bestSeq = 1; //Cъхранява най-голямата поредица числа, до съответния момент на обхождане.
            int currSeq = 1; // тази променлива е нужна при търсенето на по-голяма поредица
            int numbers = 0; // тук ще съхранявам резултата

            for (int i = 0; i < arr1.Length-1; i++)
            {
                if (arr1[i] == arr1[i+1])
                {
                    currSeq++;
                }
                else
                {
                    currSeq = 1;
                }
                if (currSeq>bestSeq)
                {
                    bestSeq = currSeq;
                    numbers = arr1[i];
                }
            }
            for (int i = 0; i < bestSeq; i++)
            {
                Console.Write("{0} ",numbers);
            }

        }
    }
}
