using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class Table
    {
        public Dealer dealer;
        public Dictionary<int, Player> players;
        public Shoe shoe;

        public Table()
        {
            dealer = new Dealer();
            players = new Dictionary<int, Player>();
            shoe = new Shoe();
        }

        public void AddPlayer(int numChips)
        {
            players.Add(players.Count, new Player(numChips));
        }

        public void GiveChips(int numChips)
        {
            players[0].AddChips(numChips);
        }

        public void StartHand()
        {
            foreach (Player p in players.Values)
            {
                p.StartHand(shoe.DrawCard(), shoe.DrawCard());
            }

            dealer.GiveFirstCard(shoe.DrawCard());
        }


    }
}
