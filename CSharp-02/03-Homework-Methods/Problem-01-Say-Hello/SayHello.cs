using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 //Write a method that asks the user for his name and prints “Hello, <name>”
 //Write a program to test this method.


namespace Problem_01_Say_Hello
{
    class SayHello
    {
        static void Say(string name)
        {
            Console.WriteLine("Hello, {0}!",name);
        }
        static void Main()
        {

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Say(name);
           
        }
    }
}
