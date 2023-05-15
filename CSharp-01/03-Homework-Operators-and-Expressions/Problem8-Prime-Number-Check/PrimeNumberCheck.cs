using System;

//Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).

namespace Problem8_Prime_Number_Check
{
class PrimeNumberCheck
{
    static void Main()
    {

        Console.Write("Enter a possitive number between 1 and 100: ");
        int number = int.Parse(Console.ReadLine());

        while (number < 1 || number > 100)
        {
            Console.Write("Wrong input format! Please try again!\nEnter another number: ");
            number = int.Parse(Console.ReadLine());
        }


        if (number == 0 || number == 1)
        {
            Console.WriteLine(number + " is not prime number");
           
        }
        else
        {
            for (int a = 2; a <= number / 2; a++)
            {
                if (number % a == 0)
                {
                    Console.WriteLine(number + " is not prime number");
                    return;
                }

            }
            Console.WriteLine(number + " is a prime number");
           
        }

    }
}
}
