using System;

namespace Problem13_Check_a_Bit_at_Given_Position
{
class CheckBitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter bit position: ");
        int p = int.Parse(Console.ReadLine());
        bool isOne = (n & (1 << p)) > 0;
        Console.WriteLine("Has the bit value of 1: " + isOne);
        Console.WriteLine("Binary representation of the number: " + Convert.ToString(n, 2).PadLeft(16, '0'));

    }
}
}
