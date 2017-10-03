using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    struct shipsLeft
    {
        public int hangarskibe = 1;
        public int slagskibe = 2;
        public int destroyers = 2;
        public int ubaade = 1;
        public int patruljebaade = 3;
    }

    class Battleships
    {
        public char[,] GameBoard { get; set; }
        public Battleships()
        {
            GameBoard = new char[10, 10];
        }
        public string GetGameBoardView()
        {
            string board = "";
            board += "\n";
            board += "\n";
            board += "\n";
            board += "\n";
            board += "\n";
            board += "\n";
            board += "\n";
            board += "\n";
            board += "\n";
            board += "\n";
            board += "\n";
            board += "\n";
            board += "\n";
            board += "\n";
            board += "\n";
            board += "\n";
            board += "\n";
            board += "\n";
            board += "\n";
            board += "\n";
            board += "\n";
            board += "\n";
            board += "\n";
            board += "\n";
            return board;
        }

       

       

    }
}
