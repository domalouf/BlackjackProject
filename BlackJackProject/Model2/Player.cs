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
        private int chips;

        public Player(int _numChips)
        {
            chips = _numChips;
            hands = new Dictionary<int, Hand>();
        }

        public int GetChips()
        {
            return chips;
        }

        public void AddChips(int _numChips)
        {
            chips += _numChips;
        }

        public void StartHand(int firstCard, int secondCard)
        {
            hands.Add(0, new Hand(firstCard, secondCard));
        }

        public Hand GetHand()
        {
            return hands[0];
        }
    }
}
