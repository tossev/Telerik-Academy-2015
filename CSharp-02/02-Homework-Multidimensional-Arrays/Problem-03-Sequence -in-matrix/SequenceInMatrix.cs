using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03_Sequence__in_matrix
{
    class SequenceInMatrix
    {
        static void Main()
        {
            //verticaly
            //string[,] matrix = {
            //                       {"s","qq","s"},
            //                       {"pp","pp","s"},
            //                       {"pp","qq","s"}

            //                   };

            //diagonaly
            //string[,] matrix = {
            //                       {"ha","fifi","ho","hi"},
            //                       {"fo","ha","hi","xx"},
            //                       {"xxx","ho","ha","xx"}

            //                   };

            //horizont
            string[,] matrix = {
                                   {"gg","gg","ho","hi"},
                                   {"fo","ha","hi","xx"},
                                   {"xxx","gg","gg","gg"}

                               };


            int currentIndex = 0;
            int maxIndex = 0;
            string bestSeq = "";

            //verticaly

            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                for (int row = 0; row < matrix.GetLength(1)-1; row++)
                {
                    if ((matrix[row, col] == matrix[row, col+1]))
                    {
                        currentIndex++;
                    }
                    else
                    {
                        currentIndex = 1;
                    }
                    if (currentIndex > maxIndex)
                    {
                        maxIndex = currentIndex;
                        bestSeq = matrix[row, col];
                    }
                }
                currentIndex = 1;
            }

            // diagonaly
            for (int row = 0, col = 0; row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1; row++, col++)
            {
                if ((matrix[row, col] == matrix[row + 1, col + 1]))
                {
                    currentIndex++;
                }
                else
                {
                    currentIndex = 1;
                }
                if (currentIndex > maxIndex)
                {
                    maxIndex = currentIndex;
                    bestSeq = matrix[row, col];
                }
            }
           

            // horizont


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if ((matrix[row, col] == matrix[row, col + 1]))
                    {
                        currentIndex++;
                    }
                    else
                    {
                        currentIndex = 1;
                    }
                    if (currentIndex > maxIndex)
                    {
                        maxIndex = currentIndex;
                        bestSeq = matrix[row, col];
                    }
                }
                currentIndex = 1;
            }



            Console.Write("The longest sequence with equal strings is: ");
            for (int i = 0; i < maxIndex; i++)
            {
                if (i == maxIndex - 1)
                {
                    Console.WriteLine(bestSeq);
                }
                else
                {
                    Console.Write(bestSeq + ", ");
                }
            }
            Console.WriteLine();


        }
    }
}
