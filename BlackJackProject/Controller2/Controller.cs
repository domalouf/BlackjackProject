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
        public event NewPlayerHandler AddChips;

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
                        AddChips();
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
            theTable.StartHand();
            theTable.players[0].RemoveChips(betSize);
            if (theTable.players[0].GetHand().blackjack)
            {
                theTable.players[0].AddChips(betSize * 2);
            }
        }

        /// <summary>
        /// Calls the table to hit a player
        /// </summary>
        public void HitPlayer()
        {
            theTable.HitPlayer();
            if (theTable.players[0].GetHand().bust)
            {

            }
            else if (theTable.players[0].hands[0].blackjack)
            {
                //TODO
            }
        }
    }
}
