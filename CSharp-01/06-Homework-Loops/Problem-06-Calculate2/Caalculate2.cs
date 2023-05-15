using System;
using System.Numerics;

//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.

namespace Problem_06_Calculate2
{
class Caalculate2
{
    static void Main()
    {

        Console.Write("n (n < 100) = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k (1 < k < n) = ");
        int k = int.Parse(Console.ReadLine());
        BigInteger factorialNK = 1;
        BigInteger result = 1;
       
        if (1<k && k<n && n<100)             // Може и без If/else loop, но така правя проверка на условието.
        {
            for (int i = (k+1); i <= n; i++)
            {
                result = factorialNK * i;
                factorialNK = result;

            }
            Console.WriteLine("n! / k! = {0}", result);
            
        }
        else
        {
            Console.WriteLine("Wrong input value!");
        }
       
    }
}
}
