using System;


//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.



namespace Problem_11_Number_аs_Words
{
class NumbersAsWords
{
static void Main()
{
    Console.Write("Enter an integer number in the range [0…999]: ");
    int number = int.Parse(Console.ReadLine());
    if (number < 0 || number > 999)
    {
        Console.WriteLine("Invalid input. Enter another integer:");
        number = int.Parse(Console.ReadLine());
    }
    int digits = number % 10;
    int tens = (number / 10) % 10;
    int hundreads = number / 100;
    int special = 10 + digits;
    string[] digitsAsWords = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
    string[] tensAsWords = { "", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninty" };
    string[] specialAsWords = {"ten", "eleven","twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","nineteen"};
    string words = "";

    if ((number > 119) && (number < 1000))
    {
        words = digitsAsWords[hundreads] + " hundred " + tensAsWords[tens-1] + " " + digitsAsWords[digits];
        Console.WriteLine(words);
    }
    else if ((number > 99) && (number < 120))
    {
        words = digitsAsWords[hundreads] + " hundred " + "and " + specialAsWords[digits] ;
        Console.WriteLine(words);
    }
    else if ((number > 19) && (number < 100))
    {
        words = tensAsWords[tens-1] + " " + digitsAsWords[digits];
        Console.WriteLine(words);
    }
    else if ((number >= 10) && (number < 20))
    {
        words = specialAsWords[digits] ;
        Console.WriteLine(words);
    }
    else if ((number > 0) && (number < 10))
    {
        words = digitsAsWords[digits];
        Console.WriteLine(words);
    }
    else if (number == 0)
    {
        Console.WriteLine("zero");
    }

   
}


}
}
