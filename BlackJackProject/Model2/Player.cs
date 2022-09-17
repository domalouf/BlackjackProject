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
        public Dictionary<int, int> bets;
        public int chips;

        public Player(int _numChips)
        {
            chips = _numChips;
            hands = new Dictionary<int, Hand>();
            bets = new Dictionary<int, int>();
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
        /// Adds a hand to a player's list of hands
        /// </summary>
        /// <param name="firstCard"></param>
        /// <param name="secondCard"></param>
        public void StartHand(int firstCard, int secondCard, int betSize)
        {
            hands.Add(hands.Count + 1, new Hand(firstCard, secondCard));
            bets.Add(bets.Count + 1, betSize);
        }

        /// <summary>
        /// adds a card to a player's stack, checks for bust
        /// </summary>
        public void Hit(int numHand, int hitCard)
        {
            hands[numHand].Hit(hitCard);
            hands[numHand].CheckHand();
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

        /// <summary>
        /// gives amount of hands player has,
        /// may increase with splits
        /// </summary>
        /// <returns></returns>
        public int GetNumHands()
        {
            return hands.Count;
        }
    }
}
