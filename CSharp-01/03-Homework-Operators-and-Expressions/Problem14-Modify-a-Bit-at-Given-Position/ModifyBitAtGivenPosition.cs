using System;

namespace Problem14_Modify_a_Bit_at_Given_Position
{
class ModifyBitAtGivenPosition
{
    static void Main()
    {

        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter a bit value (0 or 1): ");
        int v = int.Parse(Console.ReadLine());
        while (v < 0 || v > 1)
        {
            Console.WriteLine("Wrong \"value\" format! Please try again!");
            v = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter position: ");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("The original number in binary:" + Convert.ToString(n, 2).PadLeft(16, '0'));
        n = n & (~(1 << p));
        n = n | (v<<p);
        Console.WriteLine("Converted number in binary: " + Convert.ToString(n, 2).PadLeft(16, '0'));
        Console.WriteLine("New number = {0}", n);
    }
}
}
