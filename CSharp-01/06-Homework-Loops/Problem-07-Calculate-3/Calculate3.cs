using System;
using System.Numerics;
//In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.



namespace Problem_07_Calculate_3
{
class Calculate3
{
    static void Main()
    {
        Console.Write("n (n < 100) = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k (1 < k < n) = ");
        int k = int.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        BigInteger factorialNK = 1;
        BigInteger result = 1;

        int a = n - k;

        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
            if (i <= k)
            {
                factorialK *= i;
            }
            if (i <= a)
            {
                factorialNK *= i;
            }

           result = factorialN / (factorialK * factorialNK);
            
        }

        Console.WriteLine(result);

    }
}
}
