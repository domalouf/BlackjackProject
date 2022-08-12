using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class Dealer
    {
        public Hand hand;

        public Dealer()
        {
        }

        /// <summary>
        /// Adds first card to dealer's hand (stack of cards)
        /// </summary>
        /// <param name="firstCard"></param>
        public void GiveFirstCard(int firstCard)
        {
            hand = new Hand(firstCard, secondCard);
        }

        /// <summary>
        /// Returns dealer's cards
        /// </summary>
        /// <returns></returns>
        public Stack<int> getCards()
        {
            return cards;
        }
    }
}
