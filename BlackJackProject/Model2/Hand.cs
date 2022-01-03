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

        public Hand()
        {
            pair = false;
            soft = false;
            cards = new Stack<int>();
        }

        public void newHand()
        {
            pair = false;
            soft = false;
            cards.Clear();
        }
    }
}
