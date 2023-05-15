using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that adds two polynomials.
//Represent them as arrays of their coefficients.

namespace Problem_11_Adding_polynomials
{
    class AddingPolynomials
    {
       
        static int[] Sum(int[] firstPoly, int[] secondPoly)
        {
            int maxLength = Math.Max(firstPoly.Length, secondPoly.Length);
            int minLength = Math.Min(firstPoly.Length, secondPoly.Length);
            int[] result = new int[maxLength];

            for (int i = 0; i < minLength; i++)
            {
                result[i] = firstPoly[i] + secondPoly[i];
            }

            if (maxLength != minLength)
            {
                for (int i = minLength; i < maxLength; i++)
                {
                    result[i] = (firstPoly.Length == maxLength) ? firstPoly[i] : secondPoly[i];
                }
            }

            return result;
        }

        static void PrintPoly(int[] poly)
        {
            for (int i = 0; i < poly.Length; i++)
            {
                Console.Write(poly[i] + " * x^" + i);
                if (i < poly.Length - 1) Console.Write(" + ");
            }

            Console.WriteLine();
        }
        static void Main()
        {
            
            int[] firstPoly = { 7, 10, 21 };
            int[] secondPoly = { 12, 9 };

            Console.Write("First polynom: ");
            PrintPoly(firstPoly);
            Console.Write("Second polynom: ");
            PrintPoly(secondPoly);
            Console.Write("Sum: ");
            PrintPoly(Sum(firstPoly, secondPoly));


        }

    }
}
