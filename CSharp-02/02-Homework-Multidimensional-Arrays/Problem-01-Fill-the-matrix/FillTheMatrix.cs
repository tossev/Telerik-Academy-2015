using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01_Fill_the_matrix
{
    class FillTheMatrix
    {
        static void Main()
        {

            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("There are {0} rows and {0} cols in you matrix!\n", n);
            int count = 1;

            int[,] matrix = new int[n, n];


            // -----> A <-----
            Console.WriteLine("Matrix A\n");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = count;
                    count++;
                }
            }
            count = 1;
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                for (int row = 0; row < matrix.GetLength(1); row++)
                {
                    Console.Write(string.Format("{0,-4}", matrix[row, col])); ;
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }


            // -----> B <-----

            Console.WriteLine("Matrix B\n");


            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    if (col % 2 == 0)
                    {
                        matrix[row, col] = row + col * n + 1;
                    }
                    else
                    {
                        matrix[row, col] = col * n + n - row;
                    }
                    {
                        Console.Write(string.Format("{0,-4}", matrix[row, col])); 
                    }
                }
                Console.Write(Environment.NewLine + Environment.NewLine);

            }

            // -----> C <-----

            Console.WriteLine("Matrix C\n");

            //int tempC = 1;

            for (int row = n - 1; row >= 0; row--)
            {
                for (int col = 0; col <= n - row - 1; col++)
                {
                    if (col > 0)
                    {
                        matrix[row + col, col] = count;
                        count++;
                    }
                    else
                    {
                        matrix[row, col] = count;
                        count++;
                    }
                }
            }
            for (int col = 1; col < n; col++)
            {
                for (int row = 0; row < n - col; row++)
                {
                    if (row > 0)
                    {
                        matrix[row, col + row] = count;
                        count++;
                    }
                    else
                    {
                        matrix[row, col] = count;
                        count++;
                    }
                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(string.Format("{0,-4}", matrix[row, col])); 
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
      
        }
    }
}
