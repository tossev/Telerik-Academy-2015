using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_07_One_system_to_any_other
{
    class OneSystem
    {
        static string SystemConvert(string value, int baseOne, int baseTwo)
        {
            ulong decRepresentation = 0;

            for (int i = value.Length - 1; i >= 0; i--)
            {
                if (Char.IsDigit(value[i]))
                {
                    decRepresentation += (ulong)((value[i] - '0') * Math.Pow(baseOne, value.Length - i - 1));
                }
                else
                {
                    int num = 0;

                    switch (value[i])
                    {
                        case 'a':
                        case 'A':
                            num = 10;
                            break;
                        case 'b':
                        case 'B':
                            num = 11;
                            break;
                        case 'c':
                        case 'C':
                            num = 12;
                            break;
                        case 'd':
                        case 'D':
                            num = 13;
                            break;
                        case 'e':
                        case 'E':
                            num = 14;
                            break;
                        case 'f':
                        case 'F':
                            num = 15;
                            break;
                        default:
                            break;
                    }

                    decRepresentation += (ulong)(num * Math.Pow(baseOne, value.Length - i - 1));
                }
            }

            ulong remainder;
            string result = string.Empty;

            while (decRepresentation > 0)
            {
                remainder = (ulong)(decRepresentation % (ulong)baseTwo);
                decRepresentation /= (ulong)baseTwo;

                if (remainder < 10)
                {
                    result = remainder.ToString() + result;
                }
                else
                {
                    switch (remainder)
                    {
                        case 10:
                            result = "A" + result;
                            break;
                        case 11:
                            result = "B" + result;
                            break;
                        case 12:
                            result = "C" + result;
                            break;
                        case 13:
                            result = "D" + result;
                            break;
                        case 14:
                            result = "E" + result;
                            break;
                        case 15:
                            result = "F" + result;
                            break;
                        default:
                            break;
                    }
                }
            }
            return result;
        }

        static void Main()
        {
            Console.Write("Choose the type of num system in range 2-16: ");
            int s = int.Parse(Console.ReadLine());
            Console.Write("Enter the number: ");
            string number = Console.ReadLine();
            Console.Write("Choose the type of num system you want to convert the number in range 1-16: ");
            int d = int.Parse(Console.ReadLine());
           

            if ((s < 2) || (d > 16))
            {
                Console.WriteLine("Invalid value!");
            }
            else
            {
                Console.WriteLine("Number {0} in num system with base {1} = {2} ", number, d, SystemConvert(number, s, d));
            }
        }
    }
}
