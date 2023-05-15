using System;

namespace Problem12_Extract_Bit_from_Integer
{
class ExtractBitFromInteger
{
    static void Main()
    {

        Console.Write("Enter an integer number: ");
        uint n = uint.Parse(Console.ReadLine());
        Console.Write("Enter bit position: ");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int bit = mask & 1;
        Console.WriteLine("The value of the bit is: " + bit);
        Console.WriteLine("Binary representation of the number: " + Convert.ToString(n, 2).PadLeft(16, '0'));

    }
}
}
