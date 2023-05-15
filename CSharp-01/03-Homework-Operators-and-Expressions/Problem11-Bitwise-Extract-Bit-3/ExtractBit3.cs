using System;

namespace Problem11_Bitwise_Extract_Bit_3
{
class ExtractBit3
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        int n = int.Parse(Console.ReadLine());
        int p = 3;
        int mask = 1 << p;        
        int nAndMask = n & mask;  
        int bit = nAndMask >> p;  
        Console.WriteLine("The value of the bit #3 is: " + bit);   
        Console.WriteLine("Binary representation of the number: " + Convert.ToString(n, 2).PadLeft(16, '0'));
    }
}
}
