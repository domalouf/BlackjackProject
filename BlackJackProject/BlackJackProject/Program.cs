//Author: Dominic Malouf
//Started: November 2021
//Translated from c++ (old project)
using System;
using System.IO;

namespace BlackJackProject
{
    /// <summary>
    /// Class that holds values for basic strategy
    /// </summary>
    class StrategyType
    {
        // first bracket is player hand, second is dealer [p][d]
        public char[,] htotals = new char[21, 12];
        public char[,] stotals = new char[10, 12];
        public char[,] pairs = new char[12, 12];

        /// <summary>
        /// Initializes arrays with '?' for every value
        /// </summary>
        public StrategyType()
        {
            //initializes hard totals
            for (int j = 0; j < 21; j++)
            {
                for (int k = 0; k < 12; k++)
                {
                    htotals[j, k] = '?';
                }
            }

            //initializes soft totals
            for (int j = 0; j < 10; j++)
            {
                for (int k = 0; k < 12; k++)
                {
                    stotals[j, k] = '?';
                }
            }

            //initializes pairs
            for (int j = 0; j < 12; j++)
            {
                for (int k = 0; k < 12; k++)
                {
                    pairs[j, k] = '?';
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StrategyType strategy = new StrategyType();
            // filepath needs to be changed based on which computer is running program
            string filePath = @"C:\Users\malou\source\repos\BlackjackProject\BlackJackProject";

            Console.WriteLine("Hello World!");
            Console.WriteLine(strategy.htotals[2, 2]);
            // stops program from closing
            Console.ReadLine();
        }
    }
}