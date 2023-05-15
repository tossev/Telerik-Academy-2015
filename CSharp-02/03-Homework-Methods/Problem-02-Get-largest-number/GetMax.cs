using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02_Get_largest_number
{
    class GetMaxNum
    {
       private static int GetMax(int first, int second)
        {
            if (first>second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static void Main()
        {
            int[] input = new int[3];
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write("Enter number #{0}: ",i+1);
                input[i] = int.Parse(Console.ReadLine());
            }
            int max = GetMax(GetMax(input[0], input[1]), input[2]);
            Console.WriteLine("The largest number is: {0}",max);
        }
    }
}
