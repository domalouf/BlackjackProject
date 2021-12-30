using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class Table
    {
        private Dealer dealer;
        private Dictionary<int, Player> players;
        private Shoe shoe;

        public Table()
        {
            dealer = new Dealer();
            players = new Dictionary<int, Player>();
            shoe = new Shoe();
        }
    }
}
