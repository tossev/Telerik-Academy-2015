using System;

namespace Problem_9_Exchange_Values
{
class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int temp = a;
        Console.WriteLine("Original values: a = {0}, b = {1}",a,b);
        a = b;
        b = temp;
        Console.WriteLine("Exchanged values: a = {0}, b = {1}", a, b);

    }
}
}
