using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it;
//Three sides;
//Two sides and an angle between them;
//Use System.Math.

namespace Problem_04_Triangle_surface
{
    class TriangleSurface
    {
        static void Main()
        {Console.WriteLine("How do you want to calculate the surface of a triangle:");
        Console.WriteLine("Press 1 for side and an altitude to it,");
        Console.WriteLine("Press 2 for three sides.");
        Console.WriteLine("Press 3 for two sides and an angle between them.");
        int choice = int.Parse(Console.ReadLine());
        double area = 0;

        if (choice == 1)
        {
            Console.Write("Enter a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter h = ");
            double h = double.Parse(Console.ReadLine());

            area = AtitudeSurface(a, h);
        }
        else if (choice == 2)
        {
            Console.Write("Enter a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter c = ");
            double c = double.Parse(Console.ReadLine());

            area = SurfaceThreeSides(a, b, c);
        }
        else if (choice == 3)
        {
            Console.Write("Enter a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter c = ");
            double angle = double.Parse(Console.ReadLine());

            area = CalculateSurface(a, b, angle);
        }

        Console.WriteLine("Area = {0:F2}", area);
    }


    private static double AtitudeSurface(double side, double h)
    {
        return 0.5 * side * h;
    }

    private static double SurfaceThreeSides(double a, double b, double c)
    {
        double p = (a + b + c) / 2;

        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    private static double CalculateSurface(double a, double b, double angle)
    {
        return (a * b * Math.Sin(Math.PI * angle / 180)) / 2;
    }
        }
    }

