using System;
using System.Collections.Generic;


namespace TaskNo18
{
    internal class Program
    {
        List<string> deck = new List<string>();
        Random random = new Random();

        
        static List<string> GenerateDeck()
        {
            string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
            string[] ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            List<string> deck = new List<string>();

            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    deck.Add(rank + " of " + suit);
                }
            }
            return deck;


             void ShuffleDeck()
            {
                
                Random random = new Random();

                int n = deck.Count;

                if (n == 0)
                {
                    Console.WriteLine("\n No card in deck");
                }
                else
                {
                    Console.WriteLine("\nDock Shuffle Successfully...");
                }

                while (n > 0)
                {

                    n--;
                    int k = random.Next(n + 1);
                    string card = deck[k];
                    deck[k] = deck[n];
                    deck[n] = card;
                }

                for (int i = 0; i < deck.Count; i++)
                {
                    Console.WriteLine(deck[i] + ",");
                }
                Console.WriteLine();
            }


                string DealCard()
            {
                if (deck.Count > 0)
                {
                    string card = deck[0];
                    deck.RemoveAt(0);
                    return card;

                }
                else
                {
                    return null;
                }
            }


            
            
        }
    }
}

