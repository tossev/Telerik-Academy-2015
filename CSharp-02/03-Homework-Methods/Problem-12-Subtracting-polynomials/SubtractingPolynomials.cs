using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12_Subtracting_polynomials
{
    class SubtractingPolynomials
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

        static int[] Subtract(int[] firstPoli, int[] secondPoly)
        {
            int maxLength = Math.Max(firstPoli.Length, secondPoly.Length);
            int minLength = Math.Min(firstPoli.Length, secondPoly.Length);
            int[] result = new int[maxLength];

            for (int i = 0; i < minLength; i++)
            {
                result[i] = firstPoli[i] - secondPoly[i];
            }

            if (maxLength != minLength)
            {
                for (int i = minLength; i < maxLength; i++)
                {
                    result[i] = (firstPoli.Length == maxLength) ? firstPoli[i] : secondPoly[i];
                }
            }

            return result;
        }

        static int[] Multiply(int[] firstPoly, int[] secondPoly)
        {
            int[] result = new int[firstPoly.Length + secondPoly.Length - 1];

            for (int id1 = 0; id1 < firstPoly.Length; id1++)
            {
                for (int id2 = 0; id2 < secondPoly.Length; id2++)
                {
                    result[id1 + id2] += (firstPoly[id1] * secondPoly[id2]);

                }
            }

            return result;
        }

        static void PrintPoly(int[] poly)
        {
            for (int i = 0; i < poly.Length; i++)
            {
                if (i != 0)
                {
                    Console.Write("{0,2} * x^{1}", poly[i], i);
                }
                else
                {
                    Console.Write("{0,2}", poly[i]);
                }

                if (i < poly.Length - 1) Console.Write(" + ");
            }

            Console.WriteLine();
        }
        static void Main()
        {
            int[] poly1 = { 7, 5 };
            int[] poly2 = { 6, 3, 4 };

            Console.Write("Dirst polynom: ");
            PrintPoly(poly1);
            Console.Write("Second polynom: ");
            PrintPoly(poly2);
            Console.Write("Sum: ");
            PrintPoly(Sum(poly1, poly2));
            Console.Write("Subtraction: ");
            PrintPoly(Subtract(poly1, poly2));
            Console.Write("Multiplication: ");
            PrintPoly(Multiply(poly1, poly2));

        }

    }
}
