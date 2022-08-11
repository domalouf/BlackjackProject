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
        /// Gives all players 2 cards and the dealer 1 card
        /// </summary>
        public void StartHand()
        {
            foreach (Player p in players.Values)
            {
                p.StartHand(shoe.DrawCard(), shoe.DrawCard());
            }

            dealer.GiveFirstCard(shoe.DrawCard());
        }

        public void HitPlayer()
        {
            players[0].Hit
        }
    }
}
