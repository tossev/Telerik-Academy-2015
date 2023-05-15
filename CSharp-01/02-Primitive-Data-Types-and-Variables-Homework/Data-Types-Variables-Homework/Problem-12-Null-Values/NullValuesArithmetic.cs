using System;

namespace Problem_12_Null_Values
{
class NullValuesArithmetic
{
static void Main()
{
    int? var1 = null;
    double? var2 = null;
    Console.WriteLine("First variable is: {0}\nSecond variable is: {1}", var1, var2);
    var1 += 3;
    var2 += 7;
    Console.WriteLine("First variable is: {0}\nSecond variable is: {1}", var1, var2);

}
}
}
