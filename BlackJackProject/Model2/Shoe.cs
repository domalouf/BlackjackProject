using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class Shoe
    {
        /// <summary>
        /// Number of decks in each shoe
        /// </summary>
        static int numDecks = 1;
        /// <summary>
        /// an array containing the n
        /// </summary>
        int[] shoe = new int[numDecks * 52];
        /// <summary>
        /// 
        /// </summary>
        bool[] checkShoe = new bool[numDecks * 52];
        int cardsDrawn;
        Random r = new Random();

        /// <summary>
        /// creates new shoe with amount of decks specified in Shoe Class
        /// </summary>
        public Shoe()
        {
            cardsDrawn = 0;
            for (int p = 0; p < checkShoe.Length; p++)
                checkShoe[p] = true;

            int i = 0;
            for (int n = 0; n < numDecks; n++)
            {
                for (int m = 0; m < 4; m++)
                {
                    for (int j = 2; j < 10; j++)
                    {
                        shoe[i] = j;
                        i++;
                    }
                    for (int k = 0; k < 4; k++)
                    {
                        shoe[i] = 10;
                        i++;
                    }
                    shoe[i] = 11;
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
            for (int p = 0; p < checkShoe.Length; p++)
                checkShoe[p] = true;
        }

        /// <summary>
        /// Draws a random card still in the shoe
        /// returns a 0 if there are no cards left in the shoe
        /// </summary>
        /// <returns></returns>
        public int DrawCard()
        {
            if (cardsDrawn >= shoe.Length - 1)
                return 0;

            int rInt = r.Next(0, checkShoe.Length - 1);
            if (checkShoe[rInt])
            {
                cardsDrawn++;
                checkShoe[rInt] = false;
                return shoe[rInt];
            }
            else
                return DrawCard();
        }

        /// <summary>
        /// returns amount of cards left in shoe
        /// </summary>
        /// <returns></returns>
        public int ShoeCount()
        {
            return shoe.Length - cardsDrawn;
        }
    }
}
