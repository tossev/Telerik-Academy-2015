using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.



namespace Problem_06_First_larger_than_neighbours
{
    class FirstLargerThanNeighbours
    {
        static bool LargerNeighbour(int[] array, int position)
        {
            bool isBigger = false;
            if ((position - 1) >= 0 && (position + 1) < array.Length)
            {
                if (array[position] > array[position + 1] && array[position] > array[position - 1])
                {
                    isBigger = true;
                }
            }
            return isBigger;
        }


        static int FirstLargerNeighbour(int[] array)
        {
            int position = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (LargerNeighbour(array, i))
                {
                    position = i;
                    break;
                }
                else
                {
                    position = -1;
                }
            }
            return position;
            
        }
        static void Main()
        {
            int[] array = { 5, 5, 5, 5, 5, 5, 5 };
            Console.WriteLine("The given array is: { 25, 16, 98, 101, 256, 23, 96 }");
            Console.WriteLine("The first element larger than its two neighbours is at position {0}!",FirstLargerNeighbour(array));
           

        }
    }
}
