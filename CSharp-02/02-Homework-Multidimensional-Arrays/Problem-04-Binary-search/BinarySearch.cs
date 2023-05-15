using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


 //* Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.


namespace Problem_04_Binary_search
{
    class BinarySearch
    {
        static void Main()
        {
            Console.Write("Enter the lenght of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter element {0}:",i+1);
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter the element you are looking for: ");
            int searchElement = int.Parse(Console.ReadLine());

            Array.Sort(array);
            int check = Array.BinarySearch(array, searchElement);
           //Console.WriteLine(Array.BinarySearch(array, searchElement));

            //Console.WriteLine("The number {0} is found at index {1}.",searchElement,check);

            if (check == -1) //програмата връща "-1", когато търсената стойност е по-малка от най-малкият елемент в масива
            {
                Console.Write("There is no such number!");
            }
            else if (check < -1) // това се получава, когато търсеното число е по-голямо от няй-голямото в масива
            {
                int positiveIndex = ~check - 1;
                Console.Write("The biggest number that is smaller than {0} is {1} at position {2}",searchElement,array[positiveIndex],positiveIndex);
            }
            else if (check >=0) // когато числото съществува в масива
            {
                Console.Write("The number {0} is at position {1}",searchElement,check);
            }
            Console.WriteLine();
        }
    }
}
