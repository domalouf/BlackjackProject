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
        //public int chips;
        public Hand hand;

        public Player()
        {
            //chips = numChips;
            hand = new Hand();
        }
    }
}
