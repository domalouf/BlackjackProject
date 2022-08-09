using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class Dealer
    {
        public Stack<int> cards;

        public Dealer()
        {
            cards = new Stack<int>();
        }

        public void GiveFirstCard(int firstCard)
        {
            cards.Push(firstCard);
        }

        public Stack<int> getCards()
        {
            return cards;
        }
    }
}
