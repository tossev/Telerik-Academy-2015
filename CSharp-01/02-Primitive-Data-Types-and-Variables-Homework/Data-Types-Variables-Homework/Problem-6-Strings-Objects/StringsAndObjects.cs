using System;


namespace Problem_6_Strings_Objects
{
class StringsAndObjects
{
    static void Main(string[] args)
    {
        string a = "Hello";
        string b = "World";
        object concatenation = a + " " + b;
        string converted = (string)concatenation;
        Console.WriteLine(converted);
    }
}
}
