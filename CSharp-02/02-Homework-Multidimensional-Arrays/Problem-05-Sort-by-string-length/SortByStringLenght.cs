using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


 //* You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

namespace Problem_05_Sort_by_string_length
{
    class SortByStringLenght
    {
        static void Main()
        {
            Console.Write("Enter your words ---> ");
            string input = Console.ReadLine();
            string[] splitInput = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            Array.Sort(splitInput);
            Array.Sort(splitInput, (x, y) => x.Length.CompareTo(y.Length));

            for (int i = 0; i < splitInput.Length; i++)
            {
               
                Console.WriteLine("{0}.{1} --- > has {2} signs",i+1,splitInput[i],splitInput[i].Length);
            }



        }
    }
}
