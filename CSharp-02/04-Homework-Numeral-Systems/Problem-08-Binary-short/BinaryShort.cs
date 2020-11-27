using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_08_Binary_short
{
    class BinaryShort
    {
       
        static void Main()
        {
            Console.Write("Please, enter a 16-bit signed integer (short): ");
            string input = Console.ReadLine();
            short number;
            bool check = Int16.TryParse(input, out number);
            if (check)
            {
                string bin = Convert.ToString(Convert.ToInt16(input, 10), 2);
                Console.WriteLine("The number in binary ---> " + bin);
            }
            else
            {
                if (input == null)
                input = "";
                Console.WriteLine("The input number is not of type \"short\"!");
            }
           
        }
    }
}
