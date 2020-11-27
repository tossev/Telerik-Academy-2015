using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.


namespace Problem_09_Sorting_array
{
    class SortingArray
    {
        static int MaxElement(int[] array,int index)
        {
            int indexMax = 0;
            int elementMax = int.MinValue;
            for (int i = index; i < array.Length; i++)
            {
                if (array[i] > elementMax)
                {
                    elementMax = array[i];
                    indexMax = i;
                }
            }
            return indexMax;
        }
        static void SortDescreasing(int[] array)
        {
            int index = 0;
            int check = 0;

            for (int i = 0; i < array.Length; i++)
            {
                index = MaxElement(array, i);
                check = array[i];
                array[i] = array[index];
                array[index] = check;
            }
        }
        static void SortIncreasing(int[] array)
        {
            SortDescreasing(array);
            Array.Reverse(array);
        }

        static void Main()
        {
            int[] array = { 4, 12, 666, 3, 5, 6, 7, 12, 89, 6, 359, 43, 76, 9, 20, 35, 40 };
            Console.Write("Choose position: ");
            int position = int.Parse(Console.ReadLine());
            while (position < 0 || position > array.Length-1)
            {
                Console.Write("There are {0} elements in the array.\nChoose another position in this range: ",array.Length);
                position = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The given array is { 4, 12, 3, 5, 6, 7, 12, 89, 6, 359, 43, 76, 666, 9, 20, 35, 40 }");
            Console.WriteLine("The max element after position {0} is: {1}.",position,array[MaxElement(array,position)]);

            SortDescreasing(array);
            Console.Write("The array sorted in descreasing order:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" {0}", array[i]);
            }

            SortIncreasing(array);
            Console.Write("The array sorted in increasing order:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" {0}", array[i]);
            }
            Console.WriteLine();
           
        }
    }
}
