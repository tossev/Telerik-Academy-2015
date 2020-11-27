using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// * ite a program that compares two char arrays lexicographically (letter by letter).

namespace Problem_03_Compare_char_arrays
{
    class CompareCharArrays
    {
        static void Main()
        {

            Console.Write("Enter your first word: ");
            string word1 = Console.ReadLine();
            Console.Write("Enter the second word: ");
            string word2 = Console.ReadLine();

            if (word1.Length == word2.Length)
            {
                for (int i = 0; i < word1.Length; i++) //
                {
                    if (word1[i] > word2[i])
                    {
                        Console.WriteLine("1. {0}\n2. {1}", word2, word1);
                        break;
                    }
                    if (word1[i] < word2[i])
                    {
                        Console.WriteLine("1. {0}\n2. {1}", word1, word2);
                        break;
                    }
                    if (word1[i] == word2[i])
                    {
                        Console.WriteLine("The words are the same!");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("The lenght is not equal");
            }

        
        }
    }
}
