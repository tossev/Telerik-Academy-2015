using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01_Decimal_to_binary
{
    class DecimalToBinary
    {
       
        static void Main()
    {
        Console.Write("Enter your number in decimal format: ");
        int dec = int.Parse(Console.ReadLine());
        string bin = Convert.ToString(dec, 2);
        Console.WriteLine("The number in binary ---> " + bin);

    }

  
    }
}

