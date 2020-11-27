using System;

//Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

namespace Problem_11_Random_Numbers_in_Given_Range
{
    class RandomNumbersInGivenRange
    {
        static void Main()
        {
            Console.WriteLine("Define range by entering \"min\" and \"max\" values.");
            Console.Write("Enter \"min\": ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Enter \"max\": ");
            int max = int.Parse(Console.ReadLine());
            while (min == max || min > max)
            {
                Console.WriteLine("\"Min\" can't be equal to \"max\" and \"max\" must be greater than \"min\"! Try again!!");
                Console.Write("Enter \"min\": ");
                min = int.Parse(Console.ReadLine());
                Console.Write("Enter \"max\": ");
                max = int.Parse(Console.ReadLine());
            }
            Console.Write("How many numbers do you want to print in the given range?\nPlease enter value: ");
            int n = int.Parse(Console.ReadLine());
            Random r = new Random();


            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ",r.Next(min,max+1));
                
            }
            Console.WriteLine();
        }
    }
}
