using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03_Decimal_to_hexadecimal
{
    class DecimalToHexadecimal
    {
        static void Main()
        {
            Console.Write("Enter your number in decimal format: ");
            int dec = int.Parse(Console.ReadLine());
            string hex = dec.ToString("X");
            Console.WriteLine("Your number in hexadecimal ---> " + hex);

        }
    }
}
