using System;


namespace Problem_19_Spiral_Matrix
{
    class SpiralMatrix
    {
        static void Main()
        {
            int n = 4;
            for (int i = 1; i <= n; i++)
            {
                for (int a = n; a <= i; a--)
                {
                    Console.WriteLine("{0}",a);
                }
                Console.WriteLine("{0} ",i);
            }


        }
    }
}
