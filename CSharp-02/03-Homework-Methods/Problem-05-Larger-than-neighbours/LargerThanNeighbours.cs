using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 //Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).

namespace Problem_05_Larger_than_neighbours
{
    class LargerThanNeighbours
    {
        static bool LargerNeighbour(int[]array,int position)
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

        static void Main()
        {

            int[] array = { 2, 4, 5, 6, 2, 3, 12, 45, 67, 32, 56 };
            Console.Write("Enter the position you are looking for: ");
            int position = int.Parse(Console.ReadLine());
            bool larger = LargerNeighbour(array, position);
            Console.WriteLine("The given array is: { 2, 4, 5, 6, 2, 3, 12, 45, 67, 32, 56 }");
            Console.WriteLine("The element at position {0} is larger than its neighbours: {1}",position,larger);
                
           

        }
    }
}
