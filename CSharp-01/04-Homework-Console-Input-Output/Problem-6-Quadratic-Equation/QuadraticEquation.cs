using System;

////Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
//Значи първо декларираш трите променливи a, b и c . С тях ще четеш три числа от конзолата.
//След това декларираш друга променлива discriminant. Това е дискриминантата в е едно квадратно уравнение.
//Тя се намира по следната формула D = b*b - 4.a.c 
//следкато намериш дискриминатата D с нея трябва да намериш и корените :

//Ако дискриминантата D е по-голяма от 0 имаш два корена
//Ако дискриминантата D е по-малка от 0 нямаш реални корени
//И ако е равна на 0 имаш един и същ отговор за двата корена. 

//Тези три варианта ги разработваш с if else


//След това формулите за намиране на двата корена са следните :
//x1 =((-b) - Math.Sqrt(discriminant)) / (2 * a);

//x2 =((-b) + Math.Sqrt(discriminant)) / (2 * a);

//С Math.Sqrt слагаш под корен дискриминантата. 





namespace Problem_6_Quadratic_Equation
{
class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter \"a\": ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter \"b\": ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter \"c\": ");
        double c = double.Parse(Console.ReadLine());
        double discriminant = (b * b) - (4 * a * c);
        double x1 = ((-b) - Math.Sqrt(discriminant)) / (2 * a);
        double x2 = ((-b) + Math.Sqrt(discriminant)) / (2 * a);
        
        if (discriminant > 0)
        {
            Console.WriteLine("X1= {0}, X2= {1}",x1,x2);
        }
        else if (discriminant < 0 )
        {
            Console.WriteLine("no real roots");
        }
        else if (discriminant == 0)
        {
            x1 = x2;
            Console.WriteLine("X1=X2= {0}", x1);
        } 
       
    }
}
}
