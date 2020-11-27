using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.

namespace Problem_01_Leap_year
{
    class LeapYear
    {
        static void Main()
        {
            Console.Write("Choose an year: ");
            DateTime currerntYear = new DateTime(int.Parse(Console.ReadLine()), 2, 1);
            Console.WriteLine("{0} is leap year: {1}!", currerntYear.Year, DateTime.IsLeapYear(currerntYear.Year));

        }
    }
}
