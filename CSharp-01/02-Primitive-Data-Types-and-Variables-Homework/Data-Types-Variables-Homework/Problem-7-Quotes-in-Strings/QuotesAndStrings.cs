using System;


namespace Problem_7_Quotes_in_Strings
{
class QuotesAndStrings
{
    static void Main()
    {
        string quote1 = "The \"use\" of quotations causes difficulties."; // escaping with "\"
        string quote2 = @"The ""use"" of quotations causes difficulties."; // escaping with @ + ""
        Console.WriteLine("Method 1: {0}\nMethod 2: {1}",quote1,quote2);
    }
}
}
