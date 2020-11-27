using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2_Binary_to_decimal
{
    class BinaryToDecimal
    {
        static void Main()
        {
            Console.Write("Enter your number in binary format: ");
            string bin =Console.ReadLine();
            int num = Convert.ToInt32(bin, 2);
            Console.WriteLine("Your number as decimal ---> " + num);
        }
    }
}
