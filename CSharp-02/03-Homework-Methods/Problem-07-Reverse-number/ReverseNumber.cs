using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 //Write a method that reverses the digits of given decimal number.

namespace Problem_07_Reverse_number
{
    class ReverseNumber
    {
        static void ReversedNumber(double number)
        {
            string reversed = new string(number.ToString().Reverse().ToArray());
            Console.WriteLine("The reversed number: " + reversed);
        }

        static void Main()
        {
            Console.Write("Enter your number: ");
            double number = double.Parse(Console.ReadLine());
            ReversedNumber(number);

        }
    }
}
