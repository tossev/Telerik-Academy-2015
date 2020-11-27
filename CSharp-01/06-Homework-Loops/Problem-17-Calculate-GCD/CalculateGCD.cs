using System;


namespace Problem_17_Calculate_GCD
{
    class CalculateGCD
    {
        static void Main()
        {
            Console.Write("Enter \"a\": ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter \"b\": ");
            int b = int.Parse(Console.ReadLine());
            int max = Math.Max(a, b);
            int min = Math.Min(a, b);
           // int gcd = max % min;
            int gcd;
            if (a==0)
            {
                Console.Write("\"a\" can't be equal to \"0\"\nPlease enter another value for \"a\": ");
                a = int.Parse(Console.ReadLine());
            }
            else if (b==0)
            {
                 Console.Write("\"b\" can't be equal to \"0\"\nPlease enter another value for \"b\": ");
                b = int.Parse(Console.ReadLine());
            }

            if ( a != b)
            {
                gcd = max % min;
                max = min;
                min = gcd;
                Console.WriteLine("GCD({0}, {1}) = {2}",a,b,gcd);
            }

            else if (a==b)
            {
                Console.WriteLine("GCD({0}, {1}) = {2}", a, b, a);
            }


        }
    }
}
