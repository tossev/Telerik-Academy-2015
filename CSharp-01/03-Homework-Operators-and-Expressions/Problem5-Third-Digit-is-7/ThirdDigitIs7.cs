using System;


namespace Problem5_Third_Digit_is_7
{
class ThirdDigitIs7
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int thirdDigit = (number / 100) % 10;
        bool result = thirdDigit == 7;
        Console.WriteLine(result ? "True" : "False");

    }
}
}
