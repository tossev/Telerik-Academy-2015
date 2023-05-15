using System;

//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.


namespace Problem_11_Numbers_In__Interval_Dividable_by_Number
{
class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        Console.Write("Enter \"a\": ");
        uint a = uint.Parse(Console.ReadLine());
        Console.Write("Enter \"b\": ");
        uint b = uint.Parse(Console.ReadLine());
        uint check = 0;
        for (uint i = a; i <= b; i++)
        {
            if (i % 5 == 0)
            {

                check++;
            }
        }

        Console.WriteLine("The numbers between {0} and {1} devidible by 5 are: {2}.",a,b,check);


    }
}
}
