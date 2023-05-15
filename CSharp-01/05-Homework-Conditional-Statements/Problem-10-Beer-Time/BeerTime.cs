using System;
using System.Globalization;
using System.Threading;


//A beer time is after 1:00 PM and before 3:00 AM.
//Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. Note: You may need to learn how to parse dates and times.



namespace Problem_10_Beer_Time
{
class BeerTime
{
    static void Main()
    {

        CultureInfo bg = new CultureInfo("bg-BG");
        Thread.CurrentThread.CurrentCulture = bg;

        Console.Write("Enter an hour in format \"hh:mm AM/PM\": ");
        string input = Console.ReadLine();
        DateTime start = DateTime.Parse("1:00 PM");
        DateTime end = DateTime.Parse("3:00 AM");

        // Проверяваме дали входните данни отговарят на запитването в условието и дали са в желаният формат.

        try
        {
            DateTime beer = DateTime.ParseExact(input, "h:mm tt", CultureInfo.InvariantCulture);

            if (beer >= start)
            {
                Console.WriteLine("beer time");
            }
            else 
            {
                Console.WriteLine("non-beer time");
            }
            
        }
        catch (Exception)
        {

            Console.WriteLine("Invalid time!");
        }

    }
}
}
