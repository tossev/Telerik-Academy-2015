using System;

namespace Problem_16_Print_Long_Sequence
{
class PrintLongSequence
{
    static void Main()
    {
        for (int i = 2; i <= 1001; i++)
        {
            if (i % 2 == 0)   //ако е четно число
            {
                Console.Write(i + ", ");
            }
            else
            {
                Console.Write(-i + ", "); //изписва нечетно
            }
        }
        Console.WriteLine();
    }
}
}
