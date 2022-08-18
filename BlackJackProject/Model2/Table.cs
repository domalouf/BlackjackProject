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
            // key is 1 for player1
            players.Add(players.Count + 1, new Player(numChips));
        }

        /// <summary>
        /// Adds amount of chips to a player's count
        /// </summary>
        /// <param name="numChips"></param>
        public void GiveChips(int numChips)
        {
            players[1].AddChips(numChips);
        }

        /// <summary>
        /// Gives the dealer 2 cards,
        /// gives each player 2 cards for each hand
        /// </summary>
        public void StartHands(int numHands, int betSize)
        {
            dealer.StartHand(shoe.DrawCard(), shoe.DrawCard());
            foreach (Player p in players.Values)
            {
                for (int i = 0; i < numHands; i++)
                p.StartHand(shoe.DrawCard(), shoe.DrawCard(), betSize);
            }
        }

        /// <summary>
        /// Sets all hands to empty
        /// </summary>
        public void ResetHand()
        {
            players[1].hands.Clear();
            dealer.hand.newHand();
        }

        /// <summary>
        /// Gives player a card and updates hand attributes
        /// </summary>
        public void HitHand(int currentHand)
        {
            players[1].Hit(currentHand, shoe.DrawCard());
        }

        /// <summary>
        /// Hits dealer until they have 17+ (hits soft 17)
        /// </summary>
        public void HitDealer()
        {
            if (dealer.GetHand().total < 17)
            {
                dealer.HitHand(shoe.DrawCard());
            }
        }

        /// <summary>
        /// Splits player's hand in two,
        /// creates it 1 after in dictionary,
        /// </summary>
        public void SplitHand(int numHand)
        {
            int temp = players[1].GetHand(numHand).cards[0];
            players[1].hands[numHand] = new Hand(temp);
            
            // moves all hands above in dictionary up one
            // done so split hands play consecutively
            for (int i = players[1].hands.Count; i > numHand; i--)
            {
                players[1].hands[i + 1] = players[1].hands[i];
            }
            players[1].hands[numHand + 1] = new Hand(temp);
            HitHand(numHand);
        }
    }
}
