using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03_English_digit
{
    class EnglishDigit
    {
        static void ReturnLastDig(int num)
        {
            int last = num % 10;
            int[] digits = new int[]{0,1,2,3,4,5,6,7,8,9};
            string word = "";
            string[] words = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            for (int i = 0; i < digits.Length; i++)
            {
                if (last == digits[i])
                {
                    word = words[i];
                }
            }

            Console.WriteLine("Last digit is: {0}",word);
        }

        static void Main()
        {
            Console.Write("Enter your number: ");
            int number = int.Parse(Console.ReadLine());
            ReturnLastDig(number);

        }
    }
}
