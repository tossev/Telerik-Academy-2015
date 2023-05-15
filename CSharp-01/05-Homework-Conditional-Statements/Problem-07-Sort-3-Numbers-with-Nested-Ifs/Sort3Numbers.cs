using System;


//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.



namespace Problem_07_Sort_3_Numbers_with_Nested_Ifs
{
class Sort3Numbers
{
    static void Main()
    {
        Console.Write("Enter \"a\": ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter \"b\": ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter \"c\": ");
        double c = double.Parse(Console.ReadLine());
        
        if (a>b)
        {
            if (b>c)
            {
                Console.WriteLine("Result: {0}, {1}, {2}.",a,b,c);
            }
            else if (a>c)
            {
                Console.WriteLine("Result: {0}, {1}, {2}.", a, c, b);
            }
        }

        if (b>a)
        {
            if (a>c)
            {
                Console.WriteLine("Result: {0}, {1}, {2}.",b,a,c);
            }
            else if (b>c)
            {
                Console.WriteLine("Result: {0}, {1}, {2}.",b,c,a);
            }
        }

        if (c>a)
        {
            if (a>b)
            {
                Console.WriteLine("Result: {0}, {1}, {2}.", c, a, b);
            }
            else if (c>b)
            {
                Console.WriteLine("Result: {0}, {1}, {2}.",c,b,a);
            }

        }
        if (a==b)
        {
            if (b==c)
            {
                Console.WriteLine("Result: {0}, {1}, {2}.",a,a,a);
            }
            else if (a==c)
            {
                Console.WriteLine("Result: {0}, {1}, {2}.",a,a,a);
            }
        }



    }
}
}
