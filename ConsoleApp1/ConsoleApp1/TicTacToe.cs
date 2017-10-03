
using System;

namespace spil
{
    public class TicTacToe
    {
        public char[] GameBoard { get; set; }
        public TicTacToe()
        {
            GameBoard = new char[10] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
        }
        public int player1 = 0; // variable for player som vi bruger til at skifte mellem spillere
        public char currentplayer = 'h'; // char til at difinere current spillers tegn (X/O)
        public string GetGameBoardView() // metode for at print brættet 
        {
            string resultat = "";

            resultat = resultat + "  *******************       - - - - - - -\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "  *  " + GameBoard[7] + "  *  " + GameBoard[8] + "  *  " + GameBoard[9] + "  *       | 7 | 8 | 9 |\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "  *******************       - - - - - - -\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "  *  " + GameBoard[4] + "  *  " + GameBoard[5] + "  *  " + GameBoard[6] + "  *       | 4 | 5 | 6 |\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "  *******************       - - - - - - -\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "  *  " + GameBoard[1] + "  *  " + GameBoard[2] + "  *  " + GameBoard[3] + "  *       | 1 | 2 | 3 |\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "  *******************       - - - - - - -\n";
            resultat = resultat + "                      \n";

            return resultat;
        }
        public char skiftplayer() // metode til at difinere currentplayers tegn
        {
            if (player1 % 2 == 0)
            { currentplayer = 'X'; }
            else { currentplayer = 'O'; }

            return currentplayer;
        }
        public void Validate() // udregner hvem der vinder
                               // alle felterne på brættet difineres som vaiabler

        {

            char one = GameBoard[1];
            char two = GameBoard[2];
            char three = GameBoard[3];
            char four = GameBoard[4];
            char five = GameBoard[5];
            char six = GameBoard[6];
            char seven = GameBoard[7];
            char eight = GameBoard[8];
            char nine = GameBoard[9];

            // sætter felterne på brættet lig hinanden indtil den finder på 3 stribe
            if (one == two && two == three && one == currentplayer ||
                    four == five && five == six && four == currentplayer ||
                    seven == eight && eight == nine && seven == currentplayer ||
                    one == four && four == seven && one == currentplayer ||
                    two == five && five == eight && two == currentplayer ||
                    three == six && six == nine && nine == currentplayer ||
                    three == five && five == seven && three == currentplayer || //diagonal 1
                    nine == five && five == one && nine == currentplayer) //diagonal 2
            {
                Console.Clear();
                Console.WriteLine("******************************************************************************** \n");
                Console.WriteLine("            " + currentplayer + " vinder spillet! \n");
                Console.WriteLine("********************************************************************************");

                Console.ReadKey();
            }

        }
        public void PutPiece(int x) // metde til at sætte en brik
        {

            if (Char.IsLetter(GameBoard[x])) //tjekker om felter er i brug
            {
                Console.Clear();
                Console.WriteLine(" ######  ##    ## ##    ## ########  ######## ########");
                Console.WriteLine("##    ## ###   ##  ##  ##  ##     ## ##       ##     ##");
                Console.WriteLine("##       ####  ##   ####   ##     ## ##       ##     ##");
                Console.WriteLine(" ######  ## ## ##    ##    ##     ## ######   ######## ");
                Console.WriteLine("      ## ##  ####    ##    ##     ## ##       ##   ##  ");
                Console.WriteLine("##    ## ##   ###    ##    ##     ## ##       ##    ## ");
                Console.WriteLine(" ######  ##    ##    ##    ########  ######## ##     ##");
                Console.WriteLine("Man må ikke overskrive en andens brik!");
                Console.ReadKey();

            }
            else
            {
                skiftplayer();
                GameBoard[x] = currentplayer; //brik placeres 
                player1++;
            }

        }
        public void RemovePiece(int x, int z)
        {
            char movingChar = GameBoard[x]; //Gemmer brikken der i forvejen står på feltet, hvorfra spilleren øsnker at flytte en brik.
            GameBoard[x] = ' '; // Erstatter brikken med et tomt felt.
            if (Char.IsLetter(GameBoard[z]))
            {
                Console.Clear();
                Console.WriteLine(" ######  ##    ## ##    ## ########  ######## ########");
                Console.WriteLine("##    ## ###   ##  ##  ##  ##     ## ##       ##     ##");
                Console.WriteLine("##       ####  ##   ####   ##     ## ##       ##     ##");
                Console.WriteLine(" ######  ## ## ##    ##    ##     ## ######   ######## ");
                Console.WriteLine("      ## ##  ####    ##    ##     ## ##       ##   ##  ");
                Console.WriteLine("##    ## ##   ###    ##    ##     ## ##       ##    ## ");
                Console.WriteLine(" ######  ##    ##    ##    ########  ######## ##     ##");
                Console.WriteLine("Man må ikke overskrive en andens brik!");
                Console.ReadKey();
                GameBoard[x] = movingChar;
            }
            else
            {
                GameBoard[z] = movingChar; //Indsætter den gemte brik på det nyangivne felt.
            }
        }
    }
}
