using System;

//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

namespace Problem7_Point_in_a_Circle
{
class PointInACircle
{
    static void Main()
    {
        Console.Write("Enter width (X): ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter high (Y): ");
        double y = double.Parse(Console.ReadLine());
        bool inACircle = Math.Pow((x - 0), 2) + Math.Pow((y - 0), 2) < Math.Pow(2, 2) ? true : false;  //Формулата в действителност е (x - h)*(x - h) + (y - k)*(y - k) = r * r , където h и k са началните координати на центъра на кръга!
        if (inACircle)
        {
            Console.WriteLine("The point is inside a circle \"K({0, 0}, 2)\"");
        }

        else ;
        {
            Console.WriteLine("The point is inside a circle \"K({0, 0}, 2)\"");
        }

        
    }
}
}
