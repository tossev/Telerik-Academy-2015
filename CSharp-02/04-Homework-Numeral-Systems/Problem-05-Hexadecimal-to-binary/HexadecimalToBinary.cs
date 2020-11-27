using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_05_Hexadecimal_to_binary
{
    class HexadecimalToBinary
    {
        static void Main()
        {
            Console.Write("Enter your number in hexadecimal format: ");
            string hex = Console.ReadLine();
            string bin = Convert.ToString(Convert.ToInt32(hex, 16), 2);
            Console.WriteLine("Your number in binary ---> " + bin);


        }
    }
}
