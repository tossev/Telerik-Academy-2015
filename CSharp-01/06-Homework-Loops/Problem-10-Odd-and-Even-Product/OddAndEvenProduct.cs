using System;

//* You are given n integers (given in a single line, separated by a space).
//* Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//* Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

namespace Problem_10_Odd_and_Even_Product
{
    class OddAndEvenProduct
    {
        static void Main()
        {
            Console.Write("Enter numbers, separated by a space: ");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            int odd = 1;
            int even = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                int number;
                bool isNumber = int.TryParse(numbers[i], out number);   //проверяваме input'a дали е от числа. Ако е - числата се записват в променливата "number"
                if (isNumber)
                {
                    if (i % 2 == 0) 
                    {
                        even *= number;  // произведението на четните числа
                    }
                    else
                    {
                        odd *= number; // произведението на начетените
                    }
                }

            }
            if (even == odd)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
