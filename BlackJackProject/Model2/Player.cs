using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    /// <summary>
    /// Represents the player
    /// </summary>
    public class Player
    {
        public Dictionary<int, Hand> hands;
        public int chips;
        public int bet;

        public Player(int _numChips)
        {
            chips = _numChips;
            hands = new Dictionary<int, Hand>();
            bet = 0;
        }

        /// <summary>
        /// returns player chip count
        /// </summary>
        /// <returns></returns>
        public int GetChips()
        {
            return chips;
        }

        /// <summary>
        /// Adds chips to player's stack
        /// </summary>
        /// <param name="_numChips"></param>
        public void AddChips(int _numChips)
        {
            chips += _numChips;
        }

        /// <summary>
        /// Removes chips from player's stack
        /// </summary>
        /// <param name="_numChips"></param>
        public void RemoveChips(int _numChips)
        {
            chips -= _numChips;
        }

        /// <summary>
        /// Adds a hand to a player's list of hands,
        /// Just one hand at the moment
        /// </summary>
        /// <param name="firstCard"></param>
        /// <param name="secondCard"></param>
        public void StartHand(int firstCard, int secondCard, int betSize)
        {
            hands.Add(hands.Count + 1, new Hand(firstCard, secondCard));
            hands[hands.Count].CheckHand();
            bet = betSize;
        }

        /// <summary>
        /// adds a card to a player's stack, checks for bust
        /// </summary>
        public void Hit(int activeHand, int hitCard)
        {
            hands[activeHand].Hit(hitCard);
        }

        /// <summary>
        /// Returns the player's hand
        /// </summary>
        /// <returns></returns>
        public Hand GetHand(int hand)
        {
            return hands[hand];
        }

        /// <summary>
        /// Clears hand dictionary
        /// </summary>
        public void ClearHand()
        {
            hands.Clear();
        }
    }
}
