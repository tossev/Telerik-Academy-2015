using System;

namespace Problem_9_Print_a_Sequence
{
class PrintASequence
{
static void Main()
{
    for (int i = 2; i <= 11; i++)
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
