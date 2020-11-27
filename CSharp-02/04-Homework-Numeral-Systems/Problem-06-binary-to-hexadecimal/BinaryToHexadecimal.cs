using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_06_binary_to_hexadecimal
{
    class BinaryToHexadecimal
    {
        static void Main()
        {
            Console.Write("Enter your number in binary format: ");
            string bin = Console.ReadLine();
            string hex = Convert.ToInt32(bin, 2).ToString("X");
            Console.WriteLine("Your number in hexadecimal ---> " + hex);

        }
    }
}
