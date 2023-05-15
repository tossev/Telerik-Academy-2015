﻿using System;

// * Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
// * The card faces should start from 2 to A.
// * Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.



namespace Problem_04_Print_a_Deck_of_52_Cards
{
class PrintADeckOf52Cards
{
    static void Main()
    {
        //================================== METHOD #1 =====================


        //for (int i = 2; i < 15; i++)
        //{
        //    for (int s = 1; s <= 4; s++)
        //    {
        //        switch (i)
        //        {
        //            case 2:
        //            case 3:
        //            case 4:
        //            case 5:
        //            case 6:
        //            case 7:
        //            case 8:
        //            case 9: Console.Write(i);
        //                break;
        //            case 10: Console.Write(10);
        //                break;
        //            case 11: Console.Write("Q");
        //                break;
        //            case 12: Console.Write("J");
        //                break;
        //            case 13: Console.Write("K");
        //                break;
        //            case 14: Console.Write("A");
        //                break;
        //        }
        //        switch (s)
        //        {
        //            case 1:
        //                Console.Write(" of spades, ");
        //                break;
        //            case 2:
        //                Console.Write(" of clubs, ");
        //                break;
        //            case 3: 
        //                Console.Write(" of hearts, "); 
        //                break;
        //            case 4: 
        //                Console.Write(" of diamonds\n"); 
        //                break;
        //        }

        //    }
            
        //}



        //================================== METHOD #2 =====================

        string[] value = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        string[] suit = { "spades", "clubs", "hearts", "diamonds" };

        for (int i = 0; i < value.Length; i++)
        {
            for (int s = 0; s < suit.Length; s++)
            {
                Console.Write("{0} of {1}", value[i], suit[s]);
                if (s < suit.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }

    }
}
}
