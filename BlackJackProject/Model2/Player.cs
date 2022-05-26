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
    }
}
