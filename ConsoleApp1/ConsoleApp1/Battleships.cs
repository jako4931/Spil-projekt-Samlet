using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
//    struct shipsLeft
  //  {
    //    public int hangarskibe;
      //  public int slagskibe;
  //      public int destroyers;
      //  public int ubaade;
    //    public int patruljebaade;
   // }

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
