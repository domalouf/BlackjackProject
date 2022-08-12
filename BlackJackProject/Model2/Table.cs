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

        /// <summary>
        /// Adds a new player to the table
        /// </summary>
        /// <param name="numChips"></param>
        public void AddPlayer(int numChips)
        {
            players.Add(players.Count, new Player(numChips));
        }

        /// <summary>
        /// Adds amount of chips to a player's count
        /// </summary>
        /// <param name="numChips"></param>
        public void GiveChips(int numChips)
        {
            players[0].AddChips(numChips);
        }

        /// <summary>
        /// Gives the players and dealer 2 cards
        /// </summary>
        public void StartHand()
        {
            dealer.StartHand(shoe.DrawCard(), shoe.DrawCard());
            dealer.Get
            foreach (Player p in players.Values)
            {
                p.StartHand(shoe.DrawCard(), shoe.DrawCard());
                p.hands[0].CheckHand();
            }
        }

        /// <summary>
        /// Gives player a card and updates hand attributes
        /// </summary>
        public void HitPlayer()
        {
            players[0].Hit(shoe.DrawCard());
            players[0].hands[0].CheckHand();
        }
    }
}
