using System;

// Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N


namespace Problem_05_Calculate
{
class Calculate
{
    static void Main()
    {
        Console.Write("Enter \"n\": ");
        int n = int .Parse(Console.ReadLine());
        Console.Write("Enter \"x\": ");
        int x = int.Parse(Console.ReadLine());
        decimal factorial = 1;
        decimal resultX = 1;
        decimal sum = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            resultX *= x;
            sum += (factorial / resultX);

        }
        Console.WriteLine("The sum \"S = 1 + 1!/x + 2!/x2 + … + n!/x^n\" is: {0:F5}", sum);

    }
}
}
