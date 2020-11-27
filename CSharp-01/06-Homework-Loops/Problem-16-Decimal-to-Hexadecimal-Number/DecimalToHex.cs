using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//* Using loops write a program that converts an integer number to its hexadecimal representation.
//* The input is entered as long. The output should be a variable of type string.
//* Do not use the built-in .NET functionality.

namespace Problem_16_Decimal_to_Hexadecimal_Number
{
class DecimalToHex
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        long input = long.Parse(Console.ReadLine());
        string hex = "";

        do
        {
            switch (input % 16)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    hex += input % 16;
                    break;
                case 10:
                    hex += "A";
                    break;
                case 11:
                    hex += "B";
                    break;
                case 12:
                    hex += "C";
                    break;
                case 13:
                    hex += "D";
                    break;
                case 14:
                    hex += "E";
                    break;
                case 15:
                    hex += "F";
                    break;
            }
            input /= 16;
            
        } while (input>0);


        string result = "";
        for (int i = hex.Length - 1; i >= 0; i--)
        {
            result += hex[i];
        }
        Console.WriteLine("Hexadecimalrepresentation of your number: {0}", result);

    }
}
}
