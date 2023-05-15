using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 //* Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
 //* Print the obtained array on the console.

namespace Problem_01_Allocate_array
{
    class AlocateArray
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[20];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i * 5;
                Console.WriteLine("{0} --- {1}",i,myArray[i]);
            }

        }
    }
}
