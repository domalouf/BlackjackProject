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
        public void StartHand(int firstCard, int secondCard)
        {
            hand = new Hand(firstCard, secondCard);
            hand.CheckHand();
        }

        /// <summary>
        /// Gives dealer a card
        /// </summary>
        public void HitHand(int hitCard)
        {
            hand.Hit(hitCard);
            hand.CheckHand();
        }

        /// <summary>
        /// Returns dealer's cards
        /// </summary>
        /// <returns></returns>
        public Hand GetHand()
        {
            return hand;
        }
        
        /// <summary>
        /// Returns dealer's first card
        /// </summary>
        /// <returns></returns>
        public int GetFirstCard()
        {
            return hand.cards[0];
        }
    }
}
