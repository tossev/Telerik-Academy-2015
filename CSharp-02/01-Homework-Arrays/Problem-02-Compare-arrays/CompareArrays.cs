using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// * Write a program that reads two integer arrays from the console and compares them element by element.

namespace Problem_02_Compare_arrays
{
    class CompareArrays
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the lenght of the first array: ");
            int n1 = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n1];
            for (int i = 0; i < n1; i++)
            {
                Console.Write("Enter value #{0}: ",i+1);
                arr1[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the lenght of the second array: ");
            int n2 = int.Parse(Console.ReadLine());
            int[] arr2 = new int[n2];
            for (int i = 0; i < n2; i++)
            {
                Console.Write("Enter value #{0}: ", i + 1);
                arr2[i] = int.Parse(Console.ReadLine());
            }


            if (arr1.Length != arr2.Length)
            {
                Console.WriteLine("The lenght of the arrays is not equal!");
            }
            else if (arr1.Length == arr2.Length)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] != arr2[i])
                    {
                        Console.WriteLine("The lenght of the arrays is equal but the elements are not!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The lenght and elements are equal!");
                        break;
                    }

                }
            }



        }
    }
}
