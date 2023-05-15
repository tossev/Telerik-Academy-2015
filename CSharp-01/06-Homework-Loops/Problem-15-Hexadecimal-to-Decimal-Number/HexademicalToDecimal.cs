using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//* Using loops write a program that converts a hexadecimal integer number to its decimal form.
//* The input is entered as string. The output should be a variable of type long.
//* Do not use the built-in .NET functionality.

namespace Problem_15_Hexadecimal_to_Decimal_Number
{
class HexademicalToDecimal
{
    static void Main()
    {
        Console.Write("Enter a \"hex\" number: ");
        string inputHex = Console.ReadLine();
        string[] hexArray = new string[] { }; // създаваме празен масив
        hexArray = inputHex.Select(c => c.ToString()).ToArray(); // вкарваме данните от input'a в масива
        for (int i = 0; i < hexArray.Length; i++)
        {
            switch (hexArray[i])  // заместваме буквените означения с отговарящите им числа
            {
                case "A":
                    hexArray[i] = "10";
                    break;
                case "B":
                    hexArray[i] = "11";
                    break;
                case "C":
                    hexArray[i] = "12";
                    break;
                case "D":
                    hexArray[i] = "13";
                    break;
                case "E":
                    hexArray[i] = "14";
                    break;
                case "F":
                    hexArray[i] = "15";
                    break;
                default:
                    break;
            }
        }

        long decResult = 0;
        long check1 = 0;
        long check2 = 0;
        long a;
        int b = 0;
        for (int m = hexArray.Length-1; m >= 0; m--) //обикаляме елементите на масива
        {
            a = Convert.ToInt64(Math.Pow(16, m)); //16^n
            check1 = long.Parse(hexArray[b]) * a; //умножава даденото число в масива с 16^n
            check2 += check1; //сборът на всички числа
            b++;
 
        }

        decResult = check2;
        Console.WriteLine("Number in decimal: {0}",decResult);

    }
}
}
