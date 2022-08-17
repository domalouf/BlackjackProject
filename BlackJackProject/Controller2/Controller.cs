using System;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Controller
    {
        public Table theTable;
        public int currentHand;
        public int currentPlayer;
        public int chipPayout;

        // Controller events that the view can subscribe to
        public delegate void ErrorHandler(string err);
        public event ErrorHandler Error;

        public delegate void NewPlayerHandler();
        public event NewPlayerHandler NewPlayerJoined;

        public delegate void AddChipsHandler();
        public event AddChipsHandler UpdateChips;

        public delegate void PlayerActionHandler();
        public event PlayerActionHandler PlayerAction;

        public delegate void NextHandHandler(string result);
        public event NextHandHandler NextHand;

        public delegate void FinishedRoundHandler();
        public event FinishedRoundHandler FinishedRound;

        public Controller()
        {
            theTable = new Table();
            currentHand = 0;
            currentPlayer = 0;
            chipPayout = 0;
        }

        public Table GetTable()
        {
            return theTable;
        }

        /// <summary>
        /// Called when buy button is clicked in the view
        /// </summary>
        public void BuyChips(int numChips)
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
        /// Checks how many hands are being played,
        /// Calls the table to start the hand,
        /// Checks for a blackjack for player and dealer
        /// </summary>
        /// <param name="betSize"></param>
        public void DealHands(int numHands, int betSize)
        {
            currentHand = 1;
            currentPlayer = 1;
            chipPayout = 0;

            // How many hands
            theTable.StartHands(numHands, betSize);
            theTable.players[0].RemoveChips(betSize * numHands);
            chipPayout -= betSize * numHands;

            // if dealer has blackjack
            if (theTable.dealer.hand.blackjack)
            {
                // check each of player's hands for blackjack
                foreach (Hand hand in theTable.players[0].hands.Values)
                    // if player also has blackjack, bet is pushed
                    if (hand.blackjack)
                    {
                        theTable.players[0].AddChips(betSize);
                        chipPayout += betSize;
                    }
                FinishedRound();
            }
            else PlayerAction();
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
            theTable.SplitPlayer(currentHand);
        }

        /// <summary>
        /// Calls the table to hit current hand,
        /// checks for bust or 21
        /// </summary>
        public void HitHand()
        {
            theTable.HitHand(currentHand);
            // if player busts after hitting
            if (theTable.players[0].GetHand(currentHand).bust)
            {
                // if there are more hands still to play
                if (theTable.players[0].hands.Count > currentHand)
                {
                    currentHand++;
                    NextHand("bust");
                }
                // if that is the last hand
                else
                {
                    FinishedRound();
                }
            }
            else if (theTable.players[0].hands[0].total == 21)
            {
                currentHand++;
            }
        }

        /// <summary>
        /// Calls table to double down on a hand,
        /// checks for bust or 21
        /// </summary>
        public void DoubleHand()
        {
            theTable.players[0].RemoveChips(theTable.players[0].bet);
            theTable.players[0].bet *= 2;
            theTable.HitHand(currentHand);
            if (theTable.players[0].GetHand(currentHand).bust)
            {
                //PlayerBust();
            }
            //else //StandPlayer();
        }

        /// <summary>
        /// When a player stands or hits a 21,
        /// Check dealer hand and hit until 17+,
        /// (hits soft 17)
        /// </summary>
        public void StandHand()
        {
            // while dealer is below 17 or at soft 17 they hit
            while (theTable.dealer.GetHand().total < 17 ||
                (theTable.dealer.GetHand().soft && theTable.dealer.GetHand().total < 17))
            {
                theTable.HitDealer();
            }
            // dealer stands and hand is checked against player's
            if (theTable.dealer.GetHand().total <= 21 &&
                theTable.dealer.GetHand().total > theTable.players[0].GetHand(currentHand).total)
            {
                //PlayerBust();
            }
            else if (theTable.dealer.GetHand().total == theTable.players[0].GetHand(currentHand).total)
            {
                theTable.GiveChips(theTable.players[0].bet);
                //PushBet();
            }
            else
            {
                theTable.GiveChips(theTable.players[0].bet * 2);
                //PlayerWin();
            }
        }
    }
}
