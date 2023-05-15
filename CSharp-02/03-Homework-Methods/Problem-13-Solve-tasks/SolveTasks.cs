using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0

namespace Problem_13_Solve_tasks
{
    class SolveTasks
    {
        static void ReverseNumber(double number)
        {
            string reversed = new string(number.ToString().Reverse().ToArray());
            Console.WriteLine("The reversed number: " + reversed);
        }
        static void Average(double[] numbers)
        {
            double average = numbers.Average();
            Console.WriteLine("The average of the sequence of numbers is: {0}",average);
        }
        static void LinearEquation(double a, double b)
        {
            double x = -b / a;
            Console.WriteLine("\"X\" = {0}",x);
        }

        static void Main()
        {
            Console.WriteLine("To reverse the digits of your number press 1.\nTo calculate the average of numbers press 2.\nTo solve a linear equation of type \"a * x + b = 0\" press 3. ");
            int choice = int.Parse(Console.ReadLine());
            while (choice < 1 || choice > 3)
            {
                Console.WriteLine("There are only three choices!!! CHOOSE A NUMBER BETWEEN 1 AND 3!!!");
                choice = int.Parse(Console.ReadLine());
            }

            if (choice == 1)
            {

                Console.Write("Enter your number: ");
                double number = double.Parse(Console.ReadLine());
                while (number < 0)
                {
                    Console.Write("The number can't be negative!\nEnter another number: ");
                    number = double.Parse(Console.ReadLine());
                }
                ReverseNumber(number);
            }
            if (choice == 2)
            {
                Console.Write("Enter numbers separeted by space or comma: ");
                string input = Console.ReadLine();
                string[] array = input.Split(new char[]{',',' '}, StringSplitOptions.RemoveEmptyEntries);
                double[] sequenceOfNums = new double[array.Length];
                while (array.Length==0)
                {
                    Console.WriteLine("The input CAN'T be empty!\nTry again: ");
                    input = Console.ReadLine();
                }
                for (int i = 0; i < array.Length; i++)
                {
                    sequenceOfNums[i] = Convert.ToDouble(array[i]);
                }

               
                Average(sequenceOfNums);

            }
            if (choice == 3)
            {
                Console.Write("Enter valiue for \"a\": ");
                double a = double.Parse(Console.ReadLine());
                while (a == 0)
                {
                    Console.Write("\"A\" can't be equal to \"0\"!\nEnter another value for \"A\": ");
                    a = double.Parse(Console.ReadLine());
                }
                Console.Write("Enter valiue for \"b\": ");
                double b = double.Parse(Console.ReadLine());
               
                LinearEquation(a, b);
               
            }

        }
    }
}
