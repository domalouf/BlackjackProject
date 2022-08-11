using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class Hand
    {
        /// <summary>
        /// what the cards add up to
        /// </summary>
        public int total;

        /// <summary>
        /// if the hand is over 21
        /// </summary>
        public bool bust;

        /// <summary>
        /// if the hand is a blackjack
        /// </summary>
        public bool blackjack;

        /// <summary>
        /// if the first 2 cards are paired
        /// </summary>
        public bool pair;

        /// <summary>
        /// if the hand has an ace as 11
        /// </summary>
        public bool soft;

        /// <summary>
        /// list of cards in hand
        /// </summary>
        public List<int> cards;

        public Hand(int firstCard, int secondCard)
        {
            pair = false;
            soft = false;
            bust = false;
            blackjack = false;
            cards = new List<int>();
            cards.Add(firstCard);
            cards.Add(secondCard);
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

        /// <summary>
        /// Adds new card to hand
        /// </summary>
        /// <param name="hitCard"></param>
        public void Hit(int hitCard)
        {
            cards.Add(hitCard);
        }

        /// <summary>
        /// Checks condition of hand,
        /// what hand total is,
        /// if hand is a blackjack,
        /// if hand is over 21,
        /// if hand is soft,
        /// if hand is a pair
        /// </summary>
        public void CheckHand()
        {
            int numCards = cards.Count;
            total = 0;

            // counts each card in the hand
            foreach (int card in cards)
            {
                total += card;
                // if an ace comes hand is soft
                if (card == 11 && !soft) soft = true;
                // if an ace comes with an ace already there, second ace is 1
                else if (card == 11 && soft) total -= 10;
            }
            // if first 2 cards are 21, hand is blackjack
            if (numCards == 2 && total == 21) blackjack = true;
            // if first 2 cards are the same, hand is a pair
            if (numCards == 2 && cards[0] == cards[1]) pair = true;
            // can't have pair with 3+ cards
            else if (numCards != 2) pair = false;
            // if hand is soft and over 21, ace is now a 1
            if (total > 21 && soft)
            {
                soft = false;
                total -= 10;
            }
            else if (total > 21 && !soft) bust = true;
        }

        public override string ToString()
        {
            string ans = "";
            foreach (int card in cards)
            {
                ans += card.ToString() + ", ";
            }
            return ans;
        }
    }
}
