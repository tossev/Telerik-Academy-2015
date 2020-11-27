using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// * Write a program that finds the most frequent number in an array.

namespace Problem_09_Frequent_number
{
    class FrequentNumber
    {
        static void Main()
        {

            //Console.Write("Enter the lenght of the array: ");
            //int n1 = int.Parse(Console.ReadLine());
            //int[] array = new int[n1];

            //for (int i = 0; i < n1; i++)
            //{
            //    Console.Write("Enter value #{0}: ", i + 1);
            //    array[i] = int.Parse(Console.ReadLine());
            //}
            // при желание, горният текст да се разкоментира и да се провери задачата с други стойности.

            int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            int bestSeq = 1; //Cъхранява най-голямата поредица числа, до съответния момент на обхождане.
            int currSeq = 1; // тази променлива е нужна при търсенето на по-голяма поредица
            int numbers = 0; // тук ще съхранявам резултата

            Array.Sort(array); //сортираме масива, така числата с еднаква стойност ще се подредят едно до друго.

            // тук използваме алгоритъма от задача 4.

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    currSeq++;
                }
                else
                {
                    currSeq = 1;
                }
                if (currSeq > bestSeq)
                {
                    bestSeq = currSeq;
                    numbers = array[i];
                }
            }
            
                Console.WriteLine("The number {0} is repeated {1} times!",numbers,bestSeq);
        }
    }
}
