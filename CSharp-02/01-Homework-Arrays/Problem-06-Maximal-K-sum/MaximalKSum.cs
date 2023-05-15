using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


 //* Write a program that reads two integer numbers N and K and an array of N elements from the console.
 //* Find in the array those K elements that have maximal sum.

namespace Problem_06_Maximal_K_sum
{
    class MaximalKSum
    {
        static void Main()
        {

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter K: ");
            int k = int.Parse(Console.ReadLine());
            while (k>n)
            {
                Console.Write("\"K\" can't be greater than \"N\"\nEnter another value vor \"K\": ");
                k = int.Parse(Console.ReadLine());
            }
            int[] array = new int[n];
            Console.WriteLine("Your array has {0} elements.",n);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter element #{0}: ",i+1);
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array); // Сортираме масива по големина. Така числата, които имат най-голяма сума ще се подредят едно до друго.

            int lenght = array.Length;  // обръщаме масива на обратно
            int[] reversed = new int[lenght];
            for (int i = 0; i < lenght; i++)
            {
                reversed[lenght - i - 1] = array[i];
            }

            var first = reversed.Take(k); // взимаме първите "К" елемента. Те са с най-голяма сума.
            Console.Write("The {0} numbers that have maximal sum are: ",k);
            foreach (var num in first)
            {
                Console.Write("{0} ",num);
            }
            Console.WriteLine();
        }
    }
}
