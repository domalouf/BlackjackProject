using System;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Controller
    {
        public Table theTable;

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

        public void DealHand(int betSize)
        {
                theTable.StartHand();

        }
    }
}
