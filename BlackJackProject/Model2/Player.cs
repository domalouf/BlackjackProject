using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    /// <summary>
    /// Represents the hand someone is playing
    /// </summary>
    public class Player
    {
        public bool pair;
        public bool soft;
        public Stack<char> cards;

        public Player()
        {

        }
    }
}
