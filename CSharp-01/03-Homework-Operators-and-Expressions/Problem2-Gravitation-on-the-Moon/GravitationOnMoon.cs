using System;

namespace Problem2_Gravitation_on_the_Moon
{
class GravitationOnMoon
{
    static void Main(string[] args)
    {
        Console.Write("Enter your weight: ");
        double weightOnEarth = int.Parse(Console.ReadLine());
        double weightOnMoon = weightOnEarth * 0.17;
        Console.WriteLine("Your weight on Earth is: {0}.\nYour weight ot the Moon is: {1}.",weightOnEarth,weightOnMoon);
    }
}
}
