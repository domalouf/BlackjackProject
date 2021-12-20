//Author: Dominic Malouf
//Started: November 2021
//Translated from c++ (old project)

using System;
using System.IO;

namespace BlackJack
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string filePath = @"..\..\..\..\Resources\BasicStrategyChart.txt";
            //string filePath = @"..\..\..\..\Resources\README.txt";
            Strategy strategy = new Strategy(filePath);

            // stops program from closing
            Console.ReadLine();
        }
    }
}