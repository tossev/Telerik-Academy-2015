using System;


//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.



namespace Problem_09_Int_Double_String
{
class IntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1---> Int");
        Console.WriteLine("2---> Double");
        Console.WriteLine("3---> String");
        Console.Write("Your choice is: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Please enter an Integer: ");
                int integer = int.Parse(Console.ReadLine());
                Console.WriteLine(integer + 1);
                break;
            case 2:
                Console.Write("Please enter a Double: ");
                double d = double.Parse(Console.ReadLine());
                Console.WriteLine(d + 1);
                break;
            case 3:
                Console.Write("Please enter a String: ");
                string s = Console.ReadLine();
                Console.WriteLine("{0}*",s);
                break;

            default: Console.WriteLine("Not a valid choice!");
                break;
        }



    }
}
}
