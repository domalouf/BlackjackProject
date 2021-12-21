using System;
using System.IO;

namespace BlackJack
{
    /// <summary>
    /// Class that holds values for basic strategy
    /// </summary>
    public class Strategy
    {
        // arrays to hold values for basic strategy moves
        // first bracket is player hand, second is dealer [p][d]
        private char[,] htotals = new char[21, 12];
        private char[,] stotals = new char[10, 12];
        private char[,] pairs = new char[12, 12];

        public char GetMove(int playerHand, int dealerHand)
        {
            return 'A';
        }

        /// <summary>
        /// Initializes arrays with correct basic strategy move
        /// and '?' for every invalid hand
        /// Reads in basic strategy from chart
        /// </summary>
        public Strategy(string filePath)
        {
            // makes all values '?'
            for (int j = 0; j < 21; j++)
                for (int k = 0; k < 12; k++)
                    htotals[j, k] = '?';

            for (int j = 0; j < 10; j++)
                for (int k = 0; k < 12; k++)
                    stotals[j, k] = '?';

            for (int j = 0; j < 12; j++)
                for (int k = 0; k < 12; k++)
                    pairs[j, k] = '?';

            // reads in hardtotals, softtotals, and pairs from filePath (BasicStrategyChart.txt)
            try
            {
                // ASCII Values: Space = 13, New Line = 10, Carriage Return = 13
                using (StreamReader sr = new StreamReader(filePath))
                {
                    for (int i = 0; i < 3; i++)
                    {
                        //hard totals
                        if (i == 0)
                        {
                            // goes from title to first row
                            // first row in hard totals starts at spot 59
                            for (int j = 0; j < 59; j++)
                                sr.Read();

                            //totals 20 to 17
                            for (int p = 20; p > 16; p--)
                            {
                                for (int r = 2; r < 12; r++)
                                {
                                    htotals[p, r] = 'S';
                                }
                            }
                            //rows 16 to 9 from hard totals chart
                            for (int k = 16; k > 8; k--)
                            {
                                sr.Read();
                                for (int m = 2; m < 12; m++)
                                {
                                    sr.Read();
                                    sr.Read();
                                    sr.Read();
                                    htotals[k, m] = (char)sr.Read();
                                }
                                sr.Read();
                                sr.Read();
                            }
                            //totals from 8 to 4
                            for (int s = 8; s > 3; s--)
                            {
                                for (int r = 2; r < 12; r++)
                                {
                                    htotals[s, r] = 'H';
                                }
                            }
                        }


                        //soft totals
                        //ace with 2 - 9
                        if (i == 1)
                        {
                            // goes from title to first row
                            // first row in soft totals starts at spot 65 (after previous reads)
                            for (int j = 0; j < 65; j++)
                                sr.Read();

                            for (int k = 9; k > 1; k--)
                            {
                                sr.Read();
                                for (int m = 2; m < 12; m++)
                                {
                                    sr.Read();
                                    sr.Read();
                                    sr.Read();
                                    stotals[k, m] = (char)sr.Read();
                                }
                                sr.Read();
                                sr.Read();
                            }
                        }


                        //pairs
                        //pairs 2 - aces
                        if (i == 2)
                        {
                            // goes from title to first row
                            // first row in pairs starts at spot 60 (after previous reads)
                            for (int j = 0; j < 60; j++)
                                sr.Read();

                            for (int k = 11; k > 1; k--)
                            {
                                sr.Read();
                                for (int m = 2; m < 12; m++)
                                {
                                    sr.Read();
                                    sr.Read();
                                    sr.Read();
                                    pairs[k, m] = (char)sr.Read();
                                }
                                sr.Read();
                                sr.Read();
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            StrategyPrint();
        }

        /// <summary>
        /// prints out arrays to StrategyTestingChart.txt
        /// for troubleshooting purposes
        /// </summary>
        public void StrategyPrint()
        {
            // Write file using StreamWriter  
            using (StreamWriter writer = new StreamWriter(@"..\..\..\..\Resources\StrategyTestingChart.txt"))
            {
                // Hard Totals
                writer.WriteLine("Hard Totals");
                writer.WriteLine();
                // prints top row of numbers as labels
                for (int a = 0; a < 12; a++)
                    writer.Write("\t" + a);
                writer.WriteLine();
                for (int j = 20; j >= 0; j--)
                {
                    writer.Write(j + "\t");
                    for (int k = 0; k < 12; k++)
                    {
                        writer.Write(htotals[j, k] + "\t");
                    }
                    writer.WriteLine();
                }
                writer.WriteLine();
                writer.WriteLine();

                // Soft Totals
                writer.WriteLine("Soft Totals");
                writer.WriteLine();
                // prints top row of numbers as labels
                for (int a = 0; a < 12; a++)
                    writer.Write("\t" + a);
                writer.WriteLine();
                for (int j = 9; j >= 0; j--)
                {
                    writer.Write(j + "\t");
                    for (int k = 0; k < 12; k++)
                    {
                        writer.Write(stotals[j, k] + "\t");
                    }
                    writer.WriteLine();
                }
                writer.WriteLine();
                writer.WriteLine();

                // Pairs
                writer.WriteLine("The Pairs");
                writer.WriteLine();
                // prints top row of numbers as labels
                for (int a = 0; a < 12; a++)
                    writer.Write("\t" + a);
                writer.WriteLine();
                for (int j = 11; j >= 0; j--)
                {
                    writer.Write(j + "\t");
                    for (int k = 0; k < 12; k++)
                    {
                        writer.Write(pairs[j, k] + "\t");
                    }
                    writer.WriteLine();
                }
                writer.WriteLine();
                writer.WriteLine();
            }
        }
    }
}