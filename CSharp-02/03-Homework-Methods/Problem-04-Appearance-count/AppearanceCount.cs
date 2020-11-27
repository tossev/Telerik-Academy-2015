using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04_Appearance_count
{
    class AppearanceCount
    {
        static void FindCount(int input,int[] numbers)
        {
            Array.Sort(numbers);

            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (input == numbers[i])
                {
                    count++;
                }
               
            }
         
                Console.WriteLine("The number you're looking for is repeated {0} times!", count);
            
        }


        static void Main()
        {
            Console.Write("Enter the lenght of the array: ");
            int lenght = int.Parse(Console.ReadLine());
            int[] numbers = new int[lenght];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter number #{0}: ",i+1);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the number you are looking for: ");
            int num = int.Parse(Console.ReadLine());

            FindCount(num, numbers);
        }
    }
}
