using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//* Write a program that creates an array containing all letters from the alphabet (A-Z).
//* Read a word from the console and print the index of each of its letters in the array.


namespace Problem_12_Index_of_letters
{
    class IndexOfLetters
    {
        static void Main()
        {

            char[] alpha = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] alphaBIG = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            Console.Write("Write your word ---> ");
            string input = Console.ReadLine();

            for (int j = 0; j < input.Length; j++)
            {
                if (alpha.Contains(input[j]))
                {
                    int index = Array.IndexOf(alpha, input[j]);
                    Console.WriteLine("{0} ---> {1}", input[j], index);

                }
                if (alphaBIG.Contains(input[j]))
                {
                    int index = Array.IndexOf(alphaBIG, input[j]);
                    Console.WriteLine("{0} ---> {1}", input[j], index);
                }
            }

        }
    }
}
