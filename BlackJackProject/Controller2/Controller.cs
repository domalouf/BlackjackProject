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
    }
}
