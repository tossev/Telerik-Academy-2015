using System;

//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.


namespace Problem_9_Sum_of_n_Numbers
{
class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("For how many numbers you want to find the sum? : ");
        double number = double.Parse(Console.ReadLine());
        double sum = 0;
        if (number == 0)
        {
            Console.WriteLine("Nothing + nothing = NOTHING! SHERLOCK!! ");
        }
        else if (number < 0)
        {
            Console.WriteLine("You can't find the sum of negative amount of things! DUH!!");
        }
        else
        {
            for (double i = 1; i <= number; i++)
            {
                Console.Write("Enter number #{0}: ", i);
                double numberNew = double.Parse(Console.ReadLine());
                sum += numberNew;
            }

            Console.WriteLine("The sum of your numbers is: {0}", sum);
        }
    
    }
}
}
