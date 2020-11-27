using System;
using System.Numerics;
//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//Write a program to calculate the nth Catalan number by given n (1 <= n <= 100).


namespace Problem_08_Catalan_Numbers
{
class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter \"n\" (1 <= n <= 100): ");
        int n = int.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        BigInteger factorial2N = 1;
        BigInteger factorialNPlus1 = 1;

        //if ((1 <= n) && (n <= 100))   
        //{
            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
            }
            for (int i = 1; i <= (2*n); i++)
            {
                factorial2N *= i;
            }
            for (int i = 1; i <= (n+1); i++)
            {
                factorialNPlus1 *= i;
            }

            BigInteger result = factorial2N / (factorialNPlus1 * factorialN);

            Console.WriteLine("Catalan \"n\": {0}",result);
        //}
       
        //else
        //{
        //    Console.WriteLine("Wrong input value!");
        //}




    }
}
}
