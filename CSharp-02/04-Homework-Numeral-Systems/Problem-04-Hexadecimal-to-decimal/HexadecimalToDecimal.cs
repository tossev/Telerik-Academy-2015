using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04_Hexadecimal_to_decimal
{
    class HexadecimalToDecimal
    {
        static void Main()
        {
            Console.Write("Enter your number in hexadecimal format: ");
            string hex = Console.ReadLine();
            int dec = Convert.ToInt32(hex, 16);
            Console.WriteLine("Your number in decimal ---> " + dec);
            
        }
    }
}
