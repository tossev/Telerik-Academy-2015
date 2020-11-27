using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// * Write a program that finds the sequence of maximal sum in given array.


namespace Problem_08_Maximal_sum
{
    class MaximalSum
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

            int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
            int seqStart = 0; //начало на редицата
            int maxSum = array[0]; //максимална сума
            int curSum = array[0]; //текуща сума
            int count =0; // текущата позиция
            int end = 0; // крайната позиция

            for (int i = 0; i < array.Length; i++)
            {
                if (curSum>0)
                {
                    curSum += array[i];
                }
                else
                {
                    curSum = array[i];
                    count = i;
                }
                if (curSum > maxSum)
                {
                    maxSum = curSum;
                    seqStart = count;
                    end = i;

                }

                
            }
            for (int i = count; i <= end; i++)
            {
                Console.WriteLine(array[i]);
            }


        }
    }
}
