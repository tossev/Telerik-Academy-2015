using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02_Maximal_sum
{
    class MaximalSum
    {
        static void Main()
        {
            //Console.Write("Enter the number of rows: ");
            //int rows = int.Parse(Console.ReadLine());
            //Console.Write("Enter the number of cols: ");
            //int cols = int.Parse(Console.ReadLine());
            //int[,] matrix = new int[rows, cols];
            //String inputNumber;
            //for (int row = 0; row < rows; row++)
            //{
            //    for (int column = 0; column < cols; column++)
            //    {
            //        Console.Write("matrix[{0},{1}] = ", row, column);
            //        inputNumber = Console.ReadLine();
            //        matrix[row, column] = int.Parse(inputNumber);
            //    }
            //}
            int[,] matrix =
            {
                { 0, 2, 4, 0, 9, 5 },
                { 7, 1, 3, 3, 2, 1 },
                { 1, 3, 9, 8, 5, 6 },
                { 4, 6, 7, 9, 1, 0 }
            };

            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                        matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }

            Console.WriteLine("The elements in square 3 x 3 that have maximal sum are: ");
            for (int row = bestRow; row < bestRow + 3; row++)
            {
                for (int col = bestCol; col < bestCol + 3; col++)
                {
                    Console.Write("{0,-4}", matrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("The sum is: " + bestSum);
        }
    }
}
