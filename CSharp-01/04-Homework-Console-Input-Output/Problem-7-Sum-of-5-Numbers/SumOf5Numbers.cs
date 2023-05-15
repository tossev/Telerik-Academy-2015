using System;
using System.Linq; //Required to .Sum
//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

//string full = " ";
//string[] parts = full.Split(' ');
//string first = parts[0];
//string last = parts[1];

namespace Problem_7_Sum_of_5_Numbers
{
class SumOf5Numbers
{
    static void Main()
    {
        //============================ ВАРИАНТ №1 =================


        //Console.Write("Enter five numbers separeted by \"space\": ");
        //string[] input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        //decimal a = decimal.Parse(input[0]);
        //decimal b = decimal.Parse(input[1]);
        //decimal c = decimal.Parse(input[2]);
        //decimal d = decimal.Parse(input[3]);
        //decimal e = decimal.Parse(input[4]);
        //decimal sum = a + b + c + d + e;
        //Console.WriteLine("The sum of five numbers is: {0}", sum);

        //============================ ВАРИАНТ №2 =================


        Console.WriteLine("Enter numbers separeted by spaces: ");
        string input = Console.ReadLine();
        double numbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Sum(x => double.Parse(x));
        Console.WriteLine("The sum of your numbers is: {0}.",numbers);
    }
}
}
