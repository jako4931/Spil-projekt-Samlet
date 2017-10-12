using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    class Battleships
    {
        GameMenu gameMenu = new GameMenu();
        public char[,] B1 { get; set; }
        public char[,] B2 { get; set; }
        public char[,] B3 { get; set; }
        public char[,] B4 { get; set; }
        public int player1 = 0;
        public char currentplayer = 'h';



        // public char[,] GameBoard2 { get; set; }


        public Battleships()

        {
            B1 = new char[10, 10]         { {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '} };

            B2 = new char[10, 10]         { {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '} };

            B3 = new char[10, 10]         { {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '} };

            B4 = new char[10, 10]         { {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '} };
        }
        public int turns = 0;
        public char[,] board;
        public char[,] board2;
        public char[,] targetBoard;
        public string GetBoardView(char[,] board, char[,] board2)
        {
            string resultat = "";
            //
            resultat = resultat + "  -----------------------------------------" + "   |   -----------------------------------------\n";
            resultat = resultat + "10" + "| " + board[0, 9] + " | " + board[1, 9] + " | " + board[2, 9] + " | " + board[3, 9] + " | " + board[4, 9] + " | " + board[5, 9] + " | " + board[6, 9] + " | " + board[7, 9] + " | " + board[8, 9] + " | " + board[9, 9] + " | " + "  | 10| " + board2[0, 9] + " | " + board2[1, 9] + " | " + board2[2, 9] + " | " + board2[3, 9] + " | " + board2[4, 9] + " | " + board2[5, 9] + " | " + board2[6, 9] + " | " + board2[7, 9] + " | " + board2[8, 9] + " | " + board2[9, 9] + " |\n";
            resultat = resultat + "  -----------------------------------------" + "   |   -----------------------------------------\n";
            resultat = resultat + "9 " + "| " + board[0, 8] + " | " + board[1, 8] + " | " + board[2, 8] + " | " + board[3, 8] + " | " + board[4, 8] + " | " + board[5, 8] + " | " + board[6, 8] + " | " + board[7, 8] + " | " + board[8, 8] + " | " + board[9, 8] + " | " + "  | 9 | " + board2[0, 8] + " | " + board2[1, 8] + " | " + board2[2, 8] + " | " + board2[3, 8] + " | " + board2[4, 8] + " | " + board2[5, 8] + " | " + board2[6, 8] + " | " + board2[7, 8] + " | " + board2[8, 8] + " | " + board2[9, 8] + " |\n";
            resultat = resultat + "  -----------------------------------------" + "   |   -----------------------------------------\n";
            resultat = resultat + "8 " + "| " + board[0, 7] + " | " + board[1, 7] + " | " + board[2, 7] + " | " + board[3, 7] + " | " + board[4, 7] + " | " + board[5, 7] + " | " + board[6, 7] + " | " + board[7, 7] + " | " + board[8, 7] + " | " + board[9, 7] + " | " + "  | 8 | " + board2[0, 7] + " | " + board2[1, 7] + " | " + board2[2, 7] + " | " + board2[3, 7] + " | " + board2[4, 7] + " | " + board2[5, 7] + " | " + board2[6, 7] + " | " + board2[7, 7] + " | " + board2[8, 7] + " | " + board2[9, 7] + " |\n";
            resultat = resultat + "  -----------------------------------------" + "   |   -----------------------------------------\n";
            resultat = resultat + "7 " + "| " + board[0, 6] + " | " + board[1, 6] + " | " + board[2, 6] + " | " + board[3, 6] + " | " + board[4, 6] + " | " + board[5, 6] + " | " + board[6, 6] + " | " + board[7, 6] + " | " + board[8, 6] + " | " + board[9, 6] + " | " + "  | 7 | " + board2[0, 6] + " | " + board2[1, 6] + " | " + board2[2, 6] + " | " + board2[3, 6] + " | " + board2[4, 6] + " | " + board2[5, 6] + " | " + board2[6, 6] + " | " + board2[7, 6] + " | " + board2[8, 6] + " | " + board2[9, 6] + " |\n";
            resultat = resultat + "  -----------------------------------------" + "   |   -----------------------------------------\n";
            resultat = resultat + "6 " + "| " + board[0, 5] + " | " + board[1, 5] + " | " + board[2, 5] + " | " + board[3, 5] + " | " + board[4, 5] + " | " + board[5, 5] + " | " + board[6, 5] + " | " + board[7, 5] + " | " + board[8, 5] + " | " + board[9, 5] + " | " + "  | 6 | " + board2[0, 5] + " | " + board2[1, 5] + " | " + board2[2, 5] + " | " + board2[3, 5] + " | " + board2[4, 5] + " | " + board2[5, 5] + " | " + board2[6, 5] + " | " + board2[7, 5] + " | " + board2[8, 5] + " | " + board2[9, 5] + " |\n";
            resultat = resultat + "  -----------------------------------------" + "   |   -----------------------------------------\n";
            resultat = resultat + "5 " + "| " + board[0, 4] + " | " + board[1, 4] + " | " + board[2, 4] + " | " + board[3, 4] + " | " + board[4, 4] + " | " + board[5, 4] + " | " + board[6, 4] + " | " + board[7, 4] + " | " + board[8, 4] + " | " + board[9, 4] + " | " + "  | 5 | " + board2[0, 4] + " | " + board2[1, 4] + " | " + board2[2, 4] + " | " + board2[3, 4] + " | " + board2[4, 4] + " | " + board2[5, 4] + " | " + board2[6, 4] + " | " + board2[7, 4] + " | " + board2[8, 4] + " | " + board2[9, 4] + " |\n";
            resultat = resultat + "  -----------------------------------------" + "   |   -----------------------------------------\n";
            resultat = resultat + "4 " + "| " + board[0, 3] + " | " + board[1, 3] + " | " + board[2, 3] + " | " + board[3, 3] + " | " + board[4, 3] + " | " + board[5, 3] + " | " + board[6, 3] + " | " + board[7, 3] + " | " + board[8, 3] + " | " + board[9, 3] + " | " + "  | 4 | " + board2[0, 3] + " | " + board2[1, 3] + " | " + board2[2, 3] + " | " + board2[3, 3] + " | " + board2[4, 3] + " | " + board2[5, 3] + " | " + board2[6, 3] + " | " + board2[7, 3] + " | " + board2[8, 3] + " | " + board2[9, 3] + " |\n";
            resultat = resultat + "  -----------------------------------------" + "   |   -----------------------------------------\n";
            resultat = resultat + "3 " + "| " + board[0, 2] + " | " + board[1, 2] + " | " + board[2, 2] + " | " + board[3, 2] + " | " + board[4, 2] + " | " + board[5, 2] + " | " + board[6, 2] + " | " + board[7, 2] + " | " + board[8, 2] + " | " + board[9, 2] + " | " + "  | 3 | " + board2[0, 2] + " | " + board2[1, 2] + " | " + board2[2, 2] + " | " + board2[3, 2] + " | " + board2[4, 2] + " | " + board2[5, 2] + " | " + board2[6, 2] + " | " + board2[7, 2] + " | " + board2[8, 2] + " | " + board2[9, 2] + " |\n";
            resultat = resultat + "  -----------------------------------------" + "   |   -----------------------------------------\n";
            resultat = resultat + "2 " + "| " + board[0, 1] + " | " + board[1, 1] + " | " + board[2, 1] + " | " + board[3, 1] + " | " + board[4, 1] + " | " + board[5, 1] + " | " + board[6, 1] + " | " + board[7, 1] + " | " + board[8, 1] + " | " + board[9, 1] + " | " + "  | 2 | " + board2[0, 1] + " | " + board2[1, 1] + " | " + board2[2, 1] + " | " + board2[3, 1] + " | " + board2[4, 1] + " | " + board2[5, 1] + " | " + board2[6, 1] + " | " + board2[7, 1] + " | " + board2[8, 1] + " | " + board2[9, 1] + " |\n";
            resultat = resultat + "  -----------------------------------------" + "   |   -----------------------------------------\n";
            resultat = resultat + "1 " + "| " + board[0, 0] + " | " + board[1, 0] + " | " + board[2, 0] + " | " + board[3, 0] + " | " + board[4, 0] + " | " + board[5, 0] + " | " + board[6, 0] + " | " + board[7, 0] + " | " + board[8, 0] + " | " + board[9, 0] + " | " + "  | 1 | " + board2[0, 0] + " | " + board2[1, 0] + " | " + board2[2, 0] + " | " + board2[3, 0] + " | " + board2[4, 0] + " | " + board2[5, 0] + " | " + board2[6, 0] + " | " + board2[7, 0] + " | " + board2[8, 0] + " | " + board2[9, 0] + " |\n";
            resultat = resultat + "  -----------------------------------------" + "   |   -----------------------------------------\n";
            resultat = resultat + "0   1   2   3   4   5   6   7   8   9   10 " + "   |  0  1   2   3   4   5   6   7   8   9   10 ";


            return resultat;

        }
     
        public void Skifttur()
        {
            if (turns <= 4)
            {
                board = B1;
                board2 = B3;
                targetBoard = B2;
                currentplayer = '1';
                turns++;
            }
            else if(turns <= 9)
            {
                board = B2;
                board2 = B4;
                targetBoard = B1;
                currentplayer = '2';
                turns++;
            }

            else if (turns <= 10)
            {
                board = B1;
                board2 = B3;
                targetBoard = B2;
                currentplayer = '1';
                turns++;
            }
            else if (turns <= 11)
            {
                board = B2;
                board2 = B4;
                targetBoard = B1;
                currentplayer = '2';
                turns--;
            }



        }
        public void Error()
        {
            Console.Clear();
            Console.WriteLine("Nix!");
            Console.ReadKey();
            turns--;
        }


        public void DeployShip(int shipLength, int startX, int startY, bool horizontal, char shipNumber)
        {
            
             
            startX--;
            startY--;
            bool fieldsOccupied = false;
                switch (horizontal)
                {
                    case true: // vandret tjek og placering
                        for (int i = 0; i < shipLength; i++)
                        {
                            if (Char.IsDigit(board[startX + i, startY]))
                            {
                                fieldsOccupied = true;
                            }
                            else { }

                        }
                        if (fieldsOccupied == true)
                        {
                            Error();
                        }
                        else
                        {
                            for (int i = 0; i < shipLength; i++)
                            {
                                board[startX + i, startY] = shipNumber;
                            }
                        }
                        break;
                    case false: //lodret tjek og placering
                        for (int i = 0; i < shipLength; i++)
                        {
                            if (Char.IsDigit(board[startX, startY + i]))
                            {
                                fieldsOccupied = true;
                            }
                            else { }
                        }
                        if (fieldsOccupied == true)
                        {
                            Error();
                        }
                        else
                        {
                            for (int i = 0; i < shipLength; i++)
                            {
                                board[startX, startY + i] = shipNumber;
                            }
                        }
                        break;
                
                }

        }
        public char savedChar = ' ';
        public string Shoot(int xValue, int yValue)
        {
            xValue--;
            yValue--;
            savedChar = 'p';
            string melding = "";
            if (Char.IsDigit(targetBoard[xValue, yValue]))
            {
                
                savedChar = targetBoard[xValue, yValue];
                board2[xValue, yValue] = 'X';
                targetBoard[xValue, yValue] = 'X';
                melding = "";
                Console.Clear();
                Console.WriteLine("Ramt !");
                Console.WriteLine("Player " + currentplayer + " tur");
                

            }
            else if (Char.IsWhiteSpace(targetBoard[xValue, yValue]))
            {
                
                board2[xValue, yValue] = 'O';
                targetBoard[xValue, yValue] = 'O';
                melding = "";
                Console.Clear();
                Console.WriteLine("Plask !");
                Console.WriteLine("Player " + currentplayer + " tur");
            }
            else if (char.IsLetter(board2[xValue, yValue]))
            {
                melding = "Den har du ramt tidligere";
            }
            return melding;
        }

        public bool ShipIsBombed()
        {
            bool result = true;
            foreach (char field in targetBoard)
            {
                if (field == savedChar)
                {
                    result = false;
                }
                else { }
            }
            return result;
        }
        

        
    }
}


