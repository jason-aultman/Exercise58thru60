using Exercise58thru60.enums;
using System;
using System.Collections.Generic;

namespace Exercise58thru60
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Card> deck = new List<Card>();
            bool again = true;

            CreateDeck(deck);
            while (again)
            {
                ShuffleDeckandDrawCard(deck);
                again = GoAgain(again);
            }

        }

        private static bool GoAgain(bool again)
        {
            Console.WriteLine("Would you like to go again? y/n");
            var userInput = Console.ReadLine();
            if (userInput != "y")
            {
                again = false;
                Console.WriteLine("Goodbye");
            }

            return again;
        }

        private static void ShuffleDeckandDrawCard(List<Card> deck)
        {
            Console.Write("Shuffling..... ");
            var random = new Random().Next(0, 51);
            Console.WriteLine($"You drew a {deck[random].Rank} of {deck[random].Suit}");
        }

        private static void CreateDeck(List<Card> deck)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    deck.Add(new Card((Suit)i, (Rank)j));
                }
            }
        }
    }
}
