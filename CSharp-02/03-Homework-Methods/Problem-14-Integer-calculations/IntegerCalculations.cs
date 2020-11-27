using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.

namespace Problem_14_Integer_calculations
{
    class IntegerCalculations
    {
        static void Minimum(params int[] values)
        {
           
            var min = values.Min();
            Console.WriteLine("Minimum value: "+ min);
        }
        static void Maximum(params int[] values)
        {
            var max = values.Max();
            Console.WriteLine("Maximum value: " + max);
        }
        static void Average(params int[] values)
        {
            var average = values.Average();
            Console.WriteLine("Average of numbers: " + average);
        }
        static void Sum(params int[] values)
        {
            var sum = values.Sum();
            Console.WriteLine("The sum of the numbers is: " + sum);
        }
        static void Product(params int[] value)
        {
            //var product = 1;
            //for (int i = 0; i < value.Length; i++)
            //{
            //    product *= value[i];
            //}
            int product = value.Aggregate(1, (a, b) => a * b);
            Console.WriteLine("The product of the numbers is: " + product);
        }

        static void Main()
        {
            Console.WriteLine("The given set of numbers is (12, 3, 44, 25, 10, 1, 3).");
            Minimum(12, 3, 44, 25, 10, 1, 3);
            Maximum(12, 3, 44, 25, 10, 1, 3);
            Average(12, 3, 44, 25, 10, 1, 3);
            Sum(12, 3, 44, 25, 10, 1, 3);
            Product(12, 3, 44, 25, 10, 1, 3);

        }
    }
}
