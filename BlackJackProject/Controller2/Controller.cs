using System;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Controller
    {
        public Table theTable;
        public bool inHand;

        // Controller events that the view can subscribe to
        public delegate void ErrorHandler(string err);
        public event ErrorHandler Error;

        public delegate void NewPlayerHandler();
        public event NewPlayerHandler NewPlayerJoined;

        public delegate void AddChipsHandler();
        public event AddChipsHandler UpdateChips;

        public delegate void PlayerWinHandler();
        public event PlayerWinHandler PlayerWin;

        public delegate void PlayerBustHandler();
        public event PlayerBustHandler PlayerBust;

        public delegate void PlayerBlackJackHandler();
        public event PlayerBlackJackHandler PlayerBlackJack;

        public delegate void PushBetHandler();
        public event PushBetHandler PushBet;

        public delegate void PlayerActionHandler();
        public event PlayerActionHandler PlayerAction;

        public delegate void ResetViewHandler();
        public event ResetViewHandler ResetView;

        public delegate void EnableSplitHandler();
        public event EnableSplitHandler EnableSplit;

        public Controller()
        {
            theTable = new Table();
        }

        public Table GetTable()
        {
            return theTable;
        }

        /// <summary>
        /// Called when buy button is clicked in the view
        /// </summary>
        public void GiveChips(int numChips)
        {
            if (numChips > 0)
            {
                // first time buying chips
                if (theTable.players.Count == 0)
                {
                    theTable.AddPlayer(numChips);
                    NewPlayerJoined();
                }

                // buying more chips
                else
                {
                    theTable.GiveChips(numChips);
                    UpdateChips();
                }
            }
        }

        /// <summary>
        /// Calls the table to start the hand,
        /// Checks for a blackjack for player and dealer
        /// </summary>
        /// <param name="betSize"></param>
        public void DealHand(int betSize)
        {
            theTable.StartHand(betSize);
            theTable.players[0].RemoveChips(betSize);
            // if dealer has blackjack
            if (theTable.dealer.hand.blackjack)
            {
                if (theTable.players[0].GetHand().blackjack)
                {
                    theTable.players[0].AddChips(betSize);
                    PushBet();
                }
                else
                {
                    PlayerBust();
                }
            }
            // if player has a blackjack
            if (theTable.players[0].GetHand().blackjack)
            {
                theTable.players[0].AddChips(betSize * 5 / 2);
                PlayerBlackJack();
            }
            // checks for a pair and tells player to act
            else
            {
                if (theTable.players[0].GetHand().pair)
                {
                    EnableSplit();
                }
                PlayerAction();
            }
        }

        /// <summary>
        /// Sets all hands to blank
        /// </summary>
        public void ResetHand()
        {
            theTable.ResetHand();
        }

        /// <summary>
        /// Splits hand for a pair, 
        /// adds a hand to players list,
        /// makes current hand and other have 1 card,
        /// </summary>
        public void SplitHand()
        {
            theTable.ResetHand();
        }

        /// <summary>
        /// Calls the table to hit a player,
        /// checks for bust or 21
        /// </summary>
        public void HitPlayer()
        {
            theTable.HitPlayer();
            if (theTable.players[0].GetHand().bust)
            {
                PlayerBust();
            }
            else if (theTable.players[0].hands[0].total == 21)
            {
                StandPlayer();
            }
        }

        /// <summary>
        /// Calls table to double down on a hand,
        /// checks for bust or 21
        /// </summary>
        public void DoublePlayer()
        {
            theTable.players[0].RemoveChips(theTable.players[0].bet);
            theTable.players[0].bet *= 2;
            theTable.HitPlayer();
            if (theTable.players[0].GetHand().bust)
            {
                PlayerBust();
            }
            else StandPlayer();
        }

        /// <summary>
        /// When a player stands or hits a 21,
        /// Check dealer hand and hit until 17+,
        /// (hits soft 17)
        /// </summary>
        public void StandPlayer()
        {
            // while dealer is below 17 or at soft 17 they hit
            while (theTable.dealer.GetHand().total < 17 ||
                (theTable.dealer.GetHand().soft && theTable.dealer.GetHand().total < 17))
            {
                theTable.HitDealer();
            }
            // dealer stands and hand is checked against player's
            if (theTable.dealer.GetHand().total <= 21 &&
                theTable.dealer.GetHand().total > theTable.players[0].GetHand().total)
            {
                PlayerBust();
            }
            else if (theTable.dealer.GetHand().total == theTable.players[0].GetHand().total)
            {
                theTable.GiveChips(theTable.players[0].bet);
                PushBet();
            }
            else
            {
                theTable.GiveChips(theTable.players[0].bet * 2);
                PlayerWin();
            }
        }
    }
}
