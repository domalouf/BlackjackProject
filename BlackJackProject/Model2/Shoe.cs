using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    class Shoe
    {
        static int numDecks = 1;
        int[] deck = new int[numDecks * 52];
        bool[] checkdeck = new bool[numDecks * 52];
        Random r = new Random();

        public Shoe()
        {
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
            for (int p = 0; p < checkdeck.Length; p++)
                checkdeck[p] = true;
        }

        /// <summary>
        /// Draws a random card still in the shoe
        /// </summary>
        /// <returns></returns>
        public int DrawCard()
        {
            int rInt = r.Next(0, checkdeck.Length - 1);
            if (checkdeck[rInt])
            {
                checkdeck[rInt] = false;
                return deck[rInt];
            }
            else
                return DrawCard();
        }
    }
}
