using System;


//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.


namespace Problem_03_Min_Max_Sum_and_Average_of_N_Numbers
{
class MinMaxSumAverageOfNNumbers
{
    static void Main()
    {
        Console.Write("How many numbers do you want to check? ===> ");
        int count = int.Parse(Console.ReadLine());
        int input = 0;
        int sum = 0;
        int minValue = int.MinValue;
        int maxValue = int.MaxValue;
        for (int i = 1; i <= count; i++)
        {
            Console.Write("Enter number #{0}: ",i);
            input = int.Parse(Console.ReadLine());

            sum += input;

            if (input <= maxValue)
            {
                maxValue = input;
            }
            else if (input >= minValue)
            {
               minValue = input;
            }
        }
        float average = (float)sum / (float)count;
        Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3:F2}",minValue,maxValue,sum,average);

    }
}
}
