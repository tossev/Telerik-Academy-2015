using System;
using System.Globalization;
using System.Threading;

namespace Problem_15_Age_after_10_Years
{
class AgeAfterTenYears
{
    static void Main()
    {

        CultureInfo bg = new CultureInfo("bg-BG");
        Thread.CurrentThread.CurrentCulture = bg;
       
        Console.Write("Enter your birthday in format \"dd/MM/yyyy\": ");
        DateTime myBirthDay = DateTime.Parse(Console.ReadLine());
        DateTime dateToday = DateTime.Now;
        int myAge = (int)((DateTime.Now - myBirthDay).TotalDays / 365.242199);
        Console.WriteLine("My age is: " + myAge);
        int myFutureAge = (int)(myAge + 10);
        Console.WriteLine("My age after 10 year will be: " + myFutureAge);

    }
}
}
