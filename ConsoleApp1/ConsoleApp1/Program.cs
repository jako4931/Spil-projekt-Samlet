using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//dette er en git test
namespace spil
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }

        private void Run()
        {
            TicTacToeMenu ticTacToeMenu = new TicTacToeMenu();
            ticTacToeMenu.MainMenuTicTacToe(); // kalder hovedmenuen
        }
    }
}
