using System;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Controller
    {
        public Table theTable;
        public int currentHand;
        public int chipPayout;

        // Controller events that the view can subscribe to
        public delegate void ErrorHandler(string err);
        public event ErrorHandler Error;

        public delegate void NewPlayerHandler();
        public event NewPlayerHandler NewPlayerJoined;

        public delegate void AddChipsHandler();
        public event AddChipsHandler UpdateChips;

        public delegate void UpdateHandHandler(int currentHand);
        public event UpdateHandHandler UpdateHand;

        public delegate void PlayerActionHandler();
        public event PlayerActionHandler PlayerAction;

        public delegate void NextHandHandler(string result);
        public event NextHandHandler NextHand;

        public delegate void FinishedRoundHandler();
        public event FinishedRoundHandler FinishedRound;

        public delegate void ShoeShuffledHandler();
        public event ShoeShuffledHandler ShoeShuffled;

        public Controller()
        {
            theTable = new Table();
            currentHand = 0;
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
                if (theTable.player == null)
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
        /// Called by the view,
        /// Checks how many hands are being played,
        /// Calls the table to start the hand,
        /// Checks for a blackjack for player and dealer
        /// </summary>
        /// <param name="betSize"></param>
        public void DealHands(int numHands, int betSize)
        {
            // checks if shoe needs to be shuffled
            if (theTable.shoe.ShoePercentage() < 0.70)
            {
                theTable.shoe.ShuffleShoe();
                ShoeShuffled();
            }
            currentHand = 1;
            chipPayout = 0;

            // How many hands
            theTable.StartHands(numHands, betSize);
            theTable.player.RemoveChips(betSize * numHands);
            chipPayout -= betSize * numHands;

            // if dealer has blackjack
            if (theTable.dealer.hand.blackjack)
            {
                // check each of player's hands for blackjack
                foreach (Hand hand in theTable.player.hands.Values)
                    // if player also has blackjack, bet is pushed
                    if (hand.blackjack)
                    {
                        theTable.player.AddChips(betSize);
                        chipPayout += betSize;
                    }
                FinishedRound();
            }
            // check for player blackjack first hand before asking for action
            else if (theTable.player.hands[currentHand].blackjack)
            {
                theTable.player.AddChips(betSize * 5/2);
                chipPayout += betSize * 5/2;
                NextHand("blackjack");
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
            theTable.SplitHand(currentHand);
            theTable.player.RemoveChips(theTable.player.bets[currentHand]);
            chipPayout -= theTable.player.bets[currentHand];
            PlayerAction();
        }

        /// <summary>
        /// Calls the table to hit current hand,
        /// checks for bust or 21,
        /// 
        /// </summary>
        public void HitHand()
        {
            theTable.HitHand(currentHand);
            // if player busts after hitting
            if (theTable.player.GetHand(currentHand).bust)
            {
                // if there are more hands still to play
                if (theTable.player.hands.Count > currentHand)
                {
                    currentHand++;
                    NextHand("bust");
                }
                // if that is the last hand
                else
                {
                    HitDealer();
                }
            }
            // if player hits a 21
            else if (theTable.player.hands[currentHand].total == 21)
            {
                // if there are more hands still to play
                if (theTable.player.hands.Count > currentHand)
                {
                    currentHand++;
                    NextHand("hit 21");
                }
                // if that is the last hand
                else
                {
                    HitDealer();
                }
            }
        }

        /// <summary>
        /// Calls table to double down on a hand,
        /// checks for bust or 21
        /// </summary>
        public void DoubleHand()
        {
            theTable.player.RemoveChips(theTable.player.bets[currentHand]);
            chipPayout -= theTable.player.bets[currentHand];
            theTable.player.bets[currentHand] *= 2;
            theTable.HitHand(currentHand);
            UpdateHand(currentHand);
            currentHand++;
            NextHand("double");
        }

        /// <summary>
        /// Check dealer hand and hit until 17+,
        /// moves to next hand and
        /// (hits soft 17)
        /// </summary>
        public void HitDealer()
        {
            // while dealer is below 17 or at soft 17 they hit
            while (theTable.dealer.GetHand().total < 17 ||
                (theTable.dealer.GetHand().soft && theTable.dealer.GetHand().total == 17))
            {
                theTable.HitDealer();
            }
            // each of player's hands compared to dealer
            // money is already taken, so only checks for player beating the dealer
            for (int i = 1; i <= theTable.player.hands.Count; i++)
            {
                // player is closer to 21 than dealer
                if (theTable.player.GetHand(i).total <= 21 &&
                    theTable.player.GetHand(i).total > theTable.dealer.GetHand().total)
                {
                    theTable.GiveChips(theTable.player.bets[currentHand] * 2);
                    chipPayout += theTable.player.bets[currentHand] * 2;
                }
                // dealer busts and player doesn't
                if (!theTable.player.GetHand(i).bust &&
                    theTable.dealer.GetHand().bust)
                {
                    theTable.GiveChips(theTable.player.bets[currentHand] * 2);
                    chipPayout += theTable.player.bets[currentHand] * 2;
                }
                // same hand as dealer
                else if (theTable.dealer.GetHand().total == theTable.player.GetHand(i).total)
                {
                    theTable.GiveChips(theTable.player.bets[currentHand]);
                    chipPayout += theTable.player.bets[currentHand];
                }
                // here after Player is paid or they lose
                FinishedRound();
            }
        }
    }
}
