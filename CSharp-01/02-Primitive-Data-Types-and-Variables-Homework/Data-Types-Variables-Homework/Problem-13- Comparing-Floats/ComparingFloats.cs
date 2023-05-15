using System;

namespace Problem_13__Comparing_Floats
{
class ComparingFloats
{
    static void Main()
    {
        Console.Write("Enter a float number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter a another float number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        double difference = Math.Abs(firstNumber * .00001); //Define the tolerance for variation in their values.

        if (Math.Abs(firstNumber - secondNumber) <= difference)

            Console.WriteLine("{0} and {1} are equal.",firstNumber,secondNumber);
        else
            Console.WriteLine("{0} and {1} are unequal.", firstNumber, secondNumber);

        if (firstNumber > secondNumber)
            Console.WriteLine("{0} > {1}",firstNumber,secondNumber);
        else
            Console.WriteLine("{0} < {1}", firstNumber, secondNumber);

    }
}
}
