using System;


//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

namespace Problem15_Bits_Exchange
{
class BitsExchangeAdvanced
{
    static void Main()
    {
        // ============= ВАРИАНТ 2 ===== работи с по-големи, но положителни числа!

        Console.Write("Enter a positive integer number: ");
        uint num = uint.Parse(Console.ReadLine());
        uint smallBits = num & 56; // 56 = 0011 1000 in binary (bits 3,4,5 = 1)
        uint largeBits = num & 117440512; // bits 24,25,26 = 1
        uint result = num & ~(56 | (uint)117440512);
        result |= smallBits << 21; // местим с 21 позиции, за да преместим първата група битове на мястото на втората (3 отива на позиция 24 и тн.)
        result |= largeBits >> 21; // аналогично с горното

        Console.WriteLine("The integer in binary before the bits exchange is: {0}",
            Convert.ToString(num, 2).PadLeft(32, '0'));
        Console.WriteLine("The integer in binary after bits exchange is: {0}",
            Convert.ToString(result, 2).PadLeft(32, '0'));
        Console.WriteLine("The integer after conversion is: {0}", result);
        Console.WriteLine();


        // ============= ВАРИАНТ 1 ===== работи и с отрицателни, но с по-малка стойност числа!

        //Console.Write("Enter a number: ");
        //int n = int.Parse(Console.ReadLine());
        //int positionOne = 3;
        //int positionTwo = 24;
        //int maskOne = (7 << positionOne); // 7 = 111 in binary
        //int maskTwo = 7 << positionTwo;
        //int numbersFrom3To5 = n & maskOne;
        //int numbersFrom24to26 = n & maskTwo;
        //int check = (n & ~maskOne) & ~maskTwo;
        //int newMaskOne = (numbersFrom3To5 >> positionOne) << positionTwo;
        //int newMaskTwo = (numbersFrom24to26 >> positionTwo) << positionOne;
        //int result = (check | newMaskOne) | newMaskTwo;
        //Console.WriteLine("The result is: {0}\nResult in binary: {1}", result, Convert.ToString(result, 2).PadRight(16, '0'));

    }
}
}
