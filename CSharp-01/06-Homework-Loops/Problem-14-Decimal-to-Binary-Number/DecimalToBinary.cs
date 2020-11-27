using System;

//* Using loops write a program that converts an integer number to its binary representation.
//* The input is entered as long. The output should be a variable of type string.
//* Do not use the built-in .NET functionality.


namespace Problem_14_Decimal_to_Binary_Number
{
class DecimalToBinary
{
    static void Main()
    {


        Console.Write("Enter decimal number: ");
        int decNum = int.Parse(Console.ReadLine());
        
        int remainder;
        string result = string.Empty;

        do
        {

            remainder = decNum % 2;
            decNum /= 2;
            result = remainder.ToString() + result;

        } while (decNum > 0);

        Console.WriteLine("Binary representation of your number is:  {0}", result);


    }
}
}
