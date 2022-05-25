using System;

namespace BlackJack
{
    public class Controller
    {
        public Table theTable;

        public Controller()
        {
            theTable = new Table();
        }

        public Table GetTable()
        {
            return theTable;
        }
    }
}
