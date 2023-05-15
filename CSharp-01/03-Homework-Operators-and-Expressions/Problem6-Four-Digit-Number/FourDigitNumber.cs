using System;


namespace Problem6_Four_Digit_Number
{
class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Enter a four-digit number in format \"ABCD\": ");
        int number = int.Parse(Console.ReadLine());
        int a = (number / 1000) % 10;
        int b = (number / 100) % 10;
        int c = (number / 10) % 10;
        int d = number % 10;
        int sumOfDigits = a + b + c + d;
        string inReversedOrder = d + "" + c + "" + b + "" + a;
        string lastDigitasFirst = d + "" + a + "" + b + "" + c;
        string secondAsThird = a + "" + c + "" + b + "" + d;

        bool check = (bool)((number > 999) & (number < 10000));

        if (check && (a != 0)) // The number has always exactly 4 digits and cannot start with 0.
        {
            Console.WriteLine("The sum of the digits is: {0}\nThe number in reversed order is: {1}\nLast digit as first: {2}\nSecond digit as third: {3}", sumOfDigits, inReversedOrder, lastDigitasFirst, secondAsThird);
        }

        else
        {
            Console.WriteLine("The input type is incorrect!");
        }

    }
}
}
