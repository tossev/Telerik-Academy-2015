using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11_Binary_Search
{
    class BinarySearchAlgo
    {
        static void BinarySearch(int[] arr, int start, int end, int searchNum)
        {
            if (end <= start)
            {
                Console.WriteLine("There is no such element");
                return;
            }
            else
            {
                int middle = start + (end - start) / 2;
                if (searchNum < arr[middle])
                {
                    BinarySearch(arr, start, middle - 1, searchNum);
                }
                else if (searchNum > arr[middle])
                {
                    BinarySearch(arr, middle + 1, end, searchNum);
                }
                else
                {
                    Console.WriteLine("The number {0} has index {1}", searchNum, middle);
                    return;
                }
            }
        }
        static void Main()
        {
            Console.Write("Enter the lenght of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter value #{0}: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the number you are looking for: ");
            int searchNum = int.Parse(Console.ReadLine());
            Array.Sort(array);
            BinarySearch(array, 0, array.Length, searchNum);

        }
    }
}
