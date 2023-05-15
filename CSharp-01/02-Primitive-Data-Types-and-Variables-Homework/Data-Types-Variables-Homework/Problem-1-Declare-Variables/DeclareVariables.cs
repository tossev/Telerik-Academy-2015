using System;

namespace Problem_1_Declare_Variables
{
class DeclareVariables
{
    static void Main()
    {
        sbyte a = -115;
        byte b = 97;
        short c = -10000;
        ushort d = 52130;
        int e = 4825932;
        int num1, num2;

        //Program that compare the numbers.

        Console.WriteLine("You have the numbers: {0}, {1}, {2}, {3}, {4}.",a,b,c,d,e);
        Console.WriteLine("Here you can compare these numbers.");
        Console.Write("Enter the first number\t");
        num1 = Convert.ToInt32(Console.ReadLine()); // <--- Converts the specified String representation of a number to an equivalent 32-bit signed integer.
        Console.Write("Enter the second number\t");
        num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 < num2)
        { Console.WriteLine("{1} is greater than {0}",num1,num2); }
        else if (num2 < num1)
        { Console.WriteLine("{0} is greater than {1}",num1,num2); }
        else
        { Console.WriteLine("The numbers are equal."); }


    }
}
}
