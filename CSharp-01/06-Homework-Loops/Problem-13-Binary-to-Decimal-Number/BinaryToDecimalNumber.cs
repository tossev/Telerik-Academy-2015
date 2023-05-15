using System;
using System.Numerics;

//* Using loops write a program that converts a binary integer number to its decimal form.
//* The input is entered as string. The output should be a variable of type long.
//* Do not use the built-in .NET functionality.



namespace Problem_13_Binary_to_Decimal_Number
{
class BinaryToDecimalNumber
{
    static void Main()
    {

        Console.Write("Enter binary representation of number: ");
        string input = Console.ReadLine();
       
        long numInDec = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[input.Length - i - 1] == '0')
            {
                continue;
            }

            numInDec += (long)Math.Pow(2, i);
        }

        Console.WriteLine("Number in binary = {0}\nNumber in decimal = {1}",input,numInDec);

    }
}
}
