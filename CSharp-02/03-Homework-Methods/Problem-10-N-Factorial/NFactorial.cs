using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

//Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.

namespace Problem_10_N_Factorial
{
    class NFactorial
    {
        static BigInteger FactorialN(int n)
        {
            BigInteger result = 1;
            int[] array = new int[n];
            for (int i = 0, j = 1; i < array.Length; i++, j++)
            {
                array[i] = j;
                result *= array[i];
            }
            return result;
        }
        static void Main()
        {
            Console.Write("Enter \"N\" in the range [1..100]: ");
            int n = int.Parse(Console.ReadLine());
            while (n < 1 || n > 100)
            {
                Console.Write("The number is out of range!\nTry again: ");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Factorial of {0} is ---> {1}",n,FactorialN(n));
           


            //for (int i = 1; i <= 100; i++)
            //{
            //    BigInteger result = FactorialN(i);
            //    Console.WriteLine(result);
            //}
        }
        
    }
}
