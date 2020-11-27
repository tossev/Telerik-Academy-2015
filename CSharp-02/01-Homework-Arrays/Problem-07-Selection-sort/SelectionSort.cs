using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 //* Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
 //* Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

namespace Problem_07_Selection_sort
{
    class SelectionSort
    {
        static void Main()
        {
            Console.Write("Enter the lenght of the array: ");
            int n1 = int.Parse(Console.ReadLine());
            int[] array = new int[n1];

            for (int i = 0; i < n1; i++)
            {
                Console.Write("Enter value #{0}: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            int check = 0;


            for (int i = 0; i < array.Length-1; i++)
            {
                for (int k = i+1; k < array.Length; k++)
                {
                    if (array[i] > array[k])
                    {
                        check = array[i];
                        array[i] = array[k];
                        array[k] = check;
                    }
                    
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ",array[i]);
            }
            Console.WriteLine();
        }
    }
}
