using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class Table
    {
        public Dealer dealer;
        public Player player;
        public Shoe shoe;

        public Table()
        {
            dealer = new Dealer();
            player = null;
            shoe = new Shoe();
        }

        /// <summary>
        /// Adds a new player to the table
        /// </summary>
        /// <param name="numChips"></param>
        public void AddPlayer(int numChips)
        {
            // key is 1 for player1
            player = new Player(numChips);
        }

        /// <summary>
        /// Adds amount of chips to a player's count
        /// </summary>
        /// <param name="numChips"></param>
        public void GiveChips(int numChips)
        {
            player.AddChips(numChips);
        }

        /// <summary>
        /// Gives the dealer 2 cards,
        /// gives each player 2 cards for each hand
        /// </summary>
        public void StartHands(int numHands, int betSize)
        {
            dealer.StartHand(shoe.DrawCard(), shoe.DrawCard());
            for (int i = 0; i < numHands; i++)
                player.StartHand(shoe.DrawCard(), shoe.DrawCard(), betSize);
        }

        /// <summary>
        /// Sets all hands to empty
        /// </summary>
        public void ResetHand()
        {
            player.hands.Clear();
            player.bets.Clear();
            dealer.hand.newHand();
        }

        /// <summary>
        /// Gives player a card and updates hand attributes
        /// </summary>
        public void HitHand(int currentHand)
        {
            player.Hit(currentHand, shoe.DrawCard());
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
            int temp = player.GetHand(numHand).cards[0];
            player.hands[numHand] = new Hand(temp);

            // moves all hands above in dictionary up one
            // done so split hands play consecutively
            for (int i = player.hands.Count; i > numHand; i--)
            {
                player.hands[i + 1] = player.hands[i];
                player.bets[i + 1] = player.bets[i];
            }
            player.hands[numHand + 1] = new Hand(temp);
            player.bets[numHand + 1] = player.bets[numHand];
            HitHand(numHand);
            HitHand(numHand + 1);
        }
    }
}
