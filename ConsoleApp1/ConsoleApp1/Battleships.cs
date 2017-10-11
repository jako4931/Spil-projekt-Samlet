﻿using System;
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
        }
        public int turns = 0;
        public char[,] board;
        public string GetBoardView()
        {
            Skifttur();
            string resultat = "";
            //
            resultat = resultat + "  -----------------------------------------" + "   |   -----------------------------------------\n";
            resultat = resultat + "10" + "|" + B1[0, 9] + "  |" + B1[1, 9] + "  |" + B1[2, 9] + "  |" + B1[3, 9] + "  |" + B1[4, 9] + "  |" + B1[5, 9] + "  |" + B1[6, 9] + "  |" + B1[7, 9] + "  |" + B1[8, 9] + "  |" + B1[9, 9] + "  |" + "   | 10|" + B2[0, 9] + "  |" + B2[1, 9] + "  |" + B2[2, 9] + "  |" + B2[3, 9] + "  |" + B2[4, 9] + "  |" + B2[5, 9] + "  |" + B2[6, 9] + "  |" + B2[7, 9] + "  |" + B2[8, 9] + "  |" + B2[9, 9] + "  |\n";
            resultat = resultat + "  -----------------------------------------" + "   |   -----------------------------------------\n";
            resultat = resultat + "9 " + "|" + B1[0, 8] + "  |" + B1[1, 8] + "  |" + B1[2, 8] + "  |" + B1[3, 8] + "  |" + B1[4, 8] + "  |" + B1[5, 8] + "  |" + B1[6, 8] + "  |" + B1[7, 8] + "  |" + B1[8, 8] + "  |" + B1[9, 8] + "  |" + "   |  9|" + B2[0, 8] + "  |" + B2[1, 8] + "  |" + B2[2, 8] + "  |" + B2[3, 8] + "  |" + B2[4, 8] + "  |" + B2[5, 8] + "  |" + B2[6, 8] + "  |" + B2[7, 8] + "  |" + B2[8, 8] + "  |" + B2[9, 8] + "  |\n";
            resultat = resultat + "  -----------------------------------------" + "   |   -----------------------------------------\n";
            resultat = resultat + "8 " + "|" + B1[0, 7] + "  |" + B1[1, 7] + "  |" + B1[2, 7] + "  |" + B1[3, 7] + "  |" + B1[4, 7] + "  |" + B1[5, 7] + "  |" + B1[6, 7] + "  |" + B1[7, 7] + "  |" + B1[8, 7] + "  |" + B1[9, 7] + "  |" + "   |  8|" + B2[0, 7] + "  |" + B2[1, 7] + "  |" + B2[2, 7] + "  |" + B2[3, 7] + "  |" + B2[4, 7] + "  |" + B2[5, 7] + "  |" + B2[6, 7] + "  |" + B2[7, 7] + "  |" + B2[8, 7] + "  |" + B2[9, 7] + "  |\n";
            resultat = resultat + "  -----------------------------------------" + "   |   -----------------------------------------\n";
            resultat = resultat + "7 " + "|" + B1[0, 6] + "  |" + B1[1, 6] + "  |" + B1[2, 6] + "  |" + B1[3, 6] + "  |" + B1[4, 6] + "  |" + B1[5, 6] + "  |" + B1[6, 6] + "  |" + B1[7, 6] + "  |" + B1[8, 6] + "  |" + B1[9, 6] + "  |" + "   |  7|" + B2[0, 6] + "  |" + B2[1, 6] + "  |" + B2[2, 6] + "  |" + B2[3, 6] + "  |" + B2[4, 6] + "  |" + B2[5, 6] + "  |" + B2[6, 6] + "  |" + B2[7, 6] + "  |" + B2[8, 6] + "  |" + B2[9, 6] + "  |\n";
            resultat = resultat + "  -----------------------------------------" + "   |   -----------------------------------------\n";
            resultat = resultat + "6 " + "|" + B1[0, 5] + "  |" + B1[1, 5] + "  |" + B1[2, 5] + "  |" + B1[3, 5] + "  |" + B1[4, 5] + "  |" + B1[5, 5] + "  |" + B1[6, 5] + "  |" + B1[7, 5] + "  |" + B1[8, 5] + "  |" + B1[9, 5] + "  |" + "   |  6|" + B2[0, 5] + "  |" + B2[1, 5] + "  |" + B2[2, 5] + "  |" + B2[3, 5] + "  |" + B2[4, 5] + "  |" + B2[5, 5] + "  |" + B2[6, 5] + "  |" + B2[7, 5] + "  |" + B2[8, 5] + "  |" + B2[9, 5] + "  |\n";
            resultat = resultat + "  -----------------------------------------" + "   |   -----------------------------------------\n";
            resultat = resultat + "5 " + "|" + B1[0, 4] + "  |" + B1[1, 4] + "  |" + B1[2, 4] + "  |" + B1[3, 4] + "  |" + B1[4, 4] + "  |" + B1[5, 4] + "  |" + B1[6, 4] + "  |" + B1[7, 4] + "  |" + B1[8, 4] + "  |" + B1[9, 4] + "  |" + "   |  5|" + B2[0, 4] + "  |" + B2[1, 4] + "  |" + B2[2, 4] + "  |" + B2[3, 4] + "  |" + B2[4, 4] + "  |" + B2[5, 4] + "  |" + B2[6, 4] + "  |" + B2[7, 4] + "  |" + B2[8, 4] + "  |" + B2[9, 4] + "  |\n";
            resultat = resultat + "  -----------------------------------------" + "   |   -----------------------------------------\n";
            resultat = resultat + "4 " + "|" + B1[0, 3] + "  |" + B1[1, 3] + "  |" + B1[2, 3] + "  |" + B1[3, 3] + "  |" + B1[4, 3] + "  |" + B1[5, 3] + "  |" + B1[6, 3] + "  |" + B1[7, 3] + "  |" + B1[8, 3] + "  |" + B1[9, 3] + "  |" + "   |  4|" + B2[0, 3] + "  |" + B2[1, 3] + "  |" + B2[2, 3] + "  |" + B2[3, 3] + "  |" + B2[4, 3] + "  |" + B2[5, 3] + "  |" + B2[6, 3] + "  |" + B2[7, 3] + "  |" + B2[8, 3] + "  |" + B2[9, 3] + "  |\n";
            resultat = resultat + "  -----------------------------------------" + "   |   -----------------------------------------\n";
            resultat = resultat + "3 " + "|" + B1[0, 2] + "  |" + B1[1, 2] + "  |" + B1[2, 2] + "  |" + B1[3, 2] + "  |" + B1[4, 2] + "  |" + B1[5, 2] + "  |" + B1[6, 2] + "  |" + B1[7, 2] + "  |" + B1[8, 2] + "  |" + B1[9, 2] + "  |" + "   |  3|" + B2[0, 2] + "  |" + B2[1, 2] + "  |" + B2[2, 2] + "  |" + B2[3, 2] + "  |" + B2[4, 2] + "  |" + B2[5, 2] + "  |" + B2[6, 2] + "  |" + B2[7, 2] + "  |" + B2[8, 2] + "  |" + B2[9, 2] + "  |\n";
            resultat = resultat + "  -----------------------------------------" + "   |   -----------------------------------------\n";
            resultat = resultat + "2 " + "|" + B1[0, 1] + "  |" + B1[1, 1] + "  |" + B1[2, 1] + "  |" + B1[3, 1] + "  |" + B1[4, 1] + "  |" + B1[5, 1] + "  |" + B1[6, 1] + "  |" + B1[7, 1] + "  |" + B1[8, 1] + "  |" + B1[9, 1] + "  |" + "   |  2|" + B2[0, 1] + "  |" + B2[1, 1] + "  |" + B2[2, 1] + "  |" + B2[3, 1] + "  |" + B2[4, 1] + "  |" + B2[5, 1] + "  |" + B2[6, 1] + "  |" + B2[7, 1] + "  |" + B2[8, 1] + "  |" + B2[9, 1] + "  |\n";
            resultat = resultat + "  -----------------------------------------" + "   |   -----------------------------------------\n";
            resultat = resultat + "1 " + "|" + B1[0, 0] + "  |" + B1[1, 0] + "  |" + B1[2, 0] + "  |" + B1[3, 0] + "  |" + B1[4, 0] + "  |" + B1[5, 0] + "  |" + B1[6, 0] + "  |" + B1[7, 0] + "  |" + B1[8, 0] + "  |" + B1[9, 0] + "  |" + "   |  1|" + B2[0, 0] + "  |" + B2[1, 0] + "  |" + B2[2, 0] + "  |" + B2[3, 0] + "  |" + B2[4, 0] + "  |" + B2[5, 0] + "  |" + B2[6, 0] + "  |" + B2[7, 0] + "  |" + B2[8, 0] + "  |" + B2[9, 0] + "  |\n";
            resultat = resultat + "  -----------------------------------------" + "   |   -----------------------------------------\n";
            resultat = resultat + "0   1   2   3   4   5   6   7   8   9   10 " + "   |  0  1   2   3   4   5   6   7   8   9   10 ";


            return resultat;

        }
        public void Skifttur()
        {
            if (turns <= 4)
            {
                board = B1;
                turns++;
            }
            else if(turns <= 10)
            {
                board = B2;
                turns++;
            }
            if (turns > 10 && turns % 2 == 0)
            {
                board = B1;
            }
            else if (turns > 10 && turns % 2 == 1)
            {
                board = B2;
            }
            

            
        }
        public void Error()
        {
            Console.Clear();
            Console.WriteLine("Nix!");
            Console.ReadKey();
            turns--;
        }


        public void DeployShip(char[,] board, int shipLength, int startX, int startY, bool horizontal, char shipNumber)
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
                            else{}
                         
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
        public string Shoot(char[,] board, int xValue, int yValue)
        {
            xValue--;
            yValue--;
            savedChar = ' ';
            string melding = "";
            if (Char.IsDigit(board[xValue, yValue]))
            {
                
                savedChar = board[xValue, yValue];
                board[xValue, yValue] = 'X';
                melding = "Ramt!";
              
            }
            else if (Char.IsWhiteSpace(board[xValue, yValue]))
            {
                
                board[xValue, yValue] = 'O';
                melding = "Plask!";
            }
            else if (char.IsLetter(board[xValue, yValue]))
            {
                melding = "Den har du ramt tidligere";
            }
            return melding;
        }

        public bool ShipIsBombed(char[,] board)
        {
            bool result = true;

             
            foreach (char field in board)
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


