using System;

namespace Problem_5_Print_Your_Name
{
class PrintMyName
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello {0}!",name);
    }
}
}
