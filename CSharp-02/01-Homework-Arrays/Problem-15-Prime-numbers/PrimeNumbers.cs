using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 //* Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.




//масивът S се попълва със стойности 'да'
//за всяко i от 2 до n //с оптимизация 2. от долу: от 2 до sqrt(n)
//   ако S[i] е 'да', тогава
//      j = i+i; //с оптимизация 1. от долу: j = i*i;
//      докато j <= n 
//         S[j] = 'не'; //"задраскване"
//         j = j + i

namespace Problem_15_Prime_numbers
{
    class PrimeNumbers
    {
        static void Main(string[] args)
        {
            bool[] nums = new bool[10000000];
            for (int i = 2; i < Math.Sqrt(nums.Length); i++)
            {
                if (nums[i] == false)
                {
                    for (int j = i * i; j < nums.Length; j += i)
                    {
                        nums[j] = true;
                    }
                }
            }
            for (int i = 2; i < nums.Length; i++)
            {
                if (nums[i]==false)
                {
                    Console.Write("{0} ",i);
                }
            }

        }
    }
}
