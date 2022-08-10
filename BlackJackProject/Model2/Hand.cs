using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class Hand
    {
        public bool pair;
        public bool soft;
        public Stack<int> cards;

        public Hand(int firstCard, int secondCard)
        {
            pair = false;
            soft = false;
            cards = new Stack<int>();
            cards.Push(firstCard);
            cards.Push(secondCard);
        }

        /// <summary>
        /// Clears all cards in hand
        /// </summary>
        public void newHand()
        {
            pair = false;
            soft = false;
            cards.Clear();
        }

        public override string ToString()
        {
            string ans = "";
            foreach (int card in cards)
            {
                ans += card.ToString() + " ";
            }
            return ans;
        }
    }
}
