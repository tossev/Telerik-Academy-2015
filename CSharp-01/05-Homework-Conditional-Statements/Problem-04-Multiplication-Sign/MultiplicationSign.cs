using System;

//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.


namespace Problem_04_Multiplication_Sign
{
class MultiplicationSign
{
    static void Main()
    {
        Console.Write("Enter \"a\": ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter \"b\": ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter \"c\": ");
        double c = double.Parse(Console.ReadLine());


        // ========================== METHOD 1 ====================

        //double check1 = a * b * c;
        //bool check2 = check1 > 0;
        //if (check2)

        //{
        //    Console.WriteLine("Result: \"+\"");
        //}
        //else if (check1 == 0)
        //{
        //    Console.WriteLine("Result: 0");
        //}
        //else
        //{
        //    Console.WriteLine("Resilt: \"-\"");
        //}



        //=================== METHOD  2 ============

        bool positive = a > 0 && b > 0 && c > 0;
        bool zero = (a == 0) || (b == 0) || (c == 0);
        bool check =(a<0 && b<0 && c>0)||(a>0 && b<0 && c<0)|| (a<0 && b>0 && c<0); //Ако има само едно положелно число.
        bool check2 = (a < 0 && b > 0 && c > 0) || (a > 0 && b < 0 && c > 0) || (a > 0 && b > 0 && c < 0); //Ако има само едно отрицателно число.




        if (positive)
        {
            Console.WriteLine("+");
        }
        else if (zero)
        {
            Console.WriteLine("0");
        }
        else if (check)
        {
            Console.WriteLine("+");
        }
        else if (check2)
        {
            Console.WriteLine("-");
        }
        else if (!positive)
        {
            Console.WriteLine("-");
        }
    }
}
}
