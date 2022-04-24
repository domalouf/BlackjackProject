using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class Shoe
    {
        static int numDecks = 1;
        int[] deck = new int[numDecks * 52];
        bool[] checkdeck = new bool[numDecks * 52];
        int cardsDrawn;
        Random r = new Random();

        /// <summary>
        /// creates new shoe with amount of decks specified in Shoe Class
        /// </summary>
        public Shoe()
        {
            cardsDrawn = 0;
            for (int p = 0; p < checkdeck.Length; p++)
                checkdeck[p] = true;

            int i = 0;
            for (int n = 0; n < numDecks; n++)
            {
                for (int m = 0; m < 4; m++)
                {
                    for (int j = 2; j < 10; j++)
                    {
                        deck[i] = j;
                        i++;
                    }
                    for (int k = 0; k < 4; k++)
                    {
                        deck[i] = 10;
                        i++;
                    }
                    deck[i] = 11;
                    i++;
                }
            }
        }

        /// <summary>
        /// Puts all cards back into deck
        /// </summary>
        public void ShuffleShoe()
        {
            cardsDrawn = 0;
            for (int p = 0; p < checkdeck.Length; p++)
                checkdeck[p] = true;
        }

        /// <summary>
        /// Draws a random card still in the shoe
        /// returns a 0 if there are no cards left in the shoe
        /// </summary>
        /// <returns></returns>
        public int DrawCard()
        {
            if (cardsDrawn >= deck.Length - 1)
                return 0;

            int rInt = r.Next(0, checkdeck.Length - 1);
            if (checkdeck[rInt])
            {
                cardsDrawn++;
                checkdeck[rInt] = false;
                return deck[rInt];
            }
            else
                return DrawCard();
        }
    }
}
