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

        public delegate void UpdateHandHandler(int hand);
        public event UpdateHandHandler UpdateHand;

        public delegate void PlayerActionHandler();
        public event PlayerActionHandler PlayerAction;

        public delegate void NextHandHandler();
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
        /// Gives player and dealer cards,
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

            // removes chips, gives players and dealers cards
            theTable.player.RemoveChips(betSize * numHands);
            UpdateChips();
            chipPayout -= betSize * numHands;
            theTable.StartHands(numHands, betSize);

            // updates hands in view
            for (int i = 1; i <= theTable.player.hands.Count; i++)
                UpdateHand(i);

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
            // if no dealer blackjack, checks all of players hands for blackjack
            else if (theTable.player.hands[currentHand].blackjack)
            {
                currentHand++;
                NextHand();
            }
            else PlayerAction();
        }

        /// <summary>
        /// Sets all hands and bets to blank
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
            UpdateHand(currentHand);
            // if player busts after hitting
            if (theTable.player.GetHand(currentHand).bust)
            {
                currentHand++;
                NextHand();
            }
            // if player hits a 21
            else if (theTable.player.hands[currentHand].total == 21)
            {
                currentHand++;
                NextHand();
            }
        }

        /// <summary>
        /// Calls table to double down on a hand,
        /// checks for bust or 21
        /// </summary>
        public void DoubleHand()
        {
            theTable.player.RemoveChips(theTable.player.bets[currentHand]);
            UpdateChips();
            chipPayout -= theTable.player.bets[currentHand];
            theTable.player.bets[currentHand] *= 2;
            theTable.HitHand(currentHand);
            UpdateHand(currentHand);
            currentHand++;
            NextHand();
        }

        /// <summary>
        /// Hit dealer hand until 17+,
        /// called once all hands are done,
        /// ends game,
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
                // player has a blackjack
                if (theTable.player.GetHand(i).blackjack)
                {
                    theTable.GiveChips(theTable.player.bets[i] * 5/2);
                    chipPayout += theTable.player.bets[i] * 5/2;
                }
                // dealer busts and player doesn't
                if (theTable.dealer.GetHand().bust &&
                    !theTable.player.GetHand(i).bust)
                {
                    theTable.GiveChips(theTable.player.bets[i] * 2);
                    chipPayout += theTable.player.bets[i] * 2;
                }
                // player is closer to 21 than dealer
                else if (theTable.player.GetHand(i).total <= 21 &&
                    theTable.player.GetHand(i).total > theTable.dealer.GetHand().total)
                {
                    theTable.GiveChips(theTable.player.bets[i] * 2);
                    chipPayout += theTable.player.bets[i] * 2;
                }
                // same hand as dealer with no bust
                else if (theTable.dealer.GetHand().total == theTable.player.GetHand(i).total
                    && !theTable.player.GetHand(i).bust)
                {
                    theTable.GiveChips(theTable.player.bets[i]);
                    chipPayout += theTable.player.bets[i];
                }
                // here after Player is paid or they lose
                FinishedRound();
            }
        }
    }
}
