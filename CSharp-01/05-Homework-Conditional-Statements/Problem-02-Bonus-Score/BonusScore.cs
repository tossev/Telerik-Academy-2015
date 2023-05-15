using System;

//Write a program that applies bonus score to given score in the range [1…9] by the following rules:
//If the score is between 1 and 3, the program multiplies it by 10.
//If the score is between 4 and 6, the program multiplies it by 100.
//If the score is between 7 and 9, the program multiplies it by 1000.
//If the score is 0 or more than 9, the program prints “invalid score”.



namespace Problem_02_Bonus_Score
{
    class BonusScore
    {
        static void Main()
        {
            Console.WriteLine("Enter number between 1 and 9: ");
            double number = double.Parse(Console.ReadLine());
            bool check1 = (number >= 1) && (number <=3);
            bool check2 = (number >= 4) && (number <= 6);
            bool check3 = (number >= 7) && (number <= 9);
            bool check4 = (number <= 0) || (number > 9);
           
            if (check1)
            {
                Console.WriteLine(number * 10);
            }
            else if (check2)
            {
                Console.WriteLine(number * 100);
            }
            else if (check3)
            {
                Console.WriteLine(number * 1000);
            }
            else if (check4)
            {
                Console.WriteLine("invalid score");
            }

        }
    }
}
