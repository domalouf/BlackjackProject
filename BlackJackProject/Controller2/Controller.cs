using System;

namespace BlackJack
{
    public class Controller
    {
        public Table theTable;
        public Strategy strategy;

        public Controller()
        {
            theTable = new Table();
            strategy = new Strategy();
        }

        public Table GetTable()
        {
            return theTable;
        }

        /// <summary>
        /// Adds a player to the tables dictionary at spot 0
        /// Does nothing if there's already a player in spot 0
        /// </summary>
        public void StartSession()
        {
            if (theTable.players.ContainsKey(0))
                return;
            theTable.players.Add(0, new Player());
        }
    }
}
