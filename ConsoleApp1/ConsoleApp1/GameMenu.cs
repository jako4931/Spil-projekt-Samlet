using System;

namespace spil
{
    public class GameMenu
    {
        TicTacToe ticTacToe { get; set; }

        int turns = 0; //variable til at tælle ture

        public void MainMenu()
        {
            bool running = true; // køre i et bool while loop så længe at bool er true
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Chose a game");
                    Console.WriteLine("1. Tic tac toe");
                    Console.WriteLine("2. Battleship");
                    Console.WriteLine("");
                    Console.WriteLine("0. Exit");
                    string choice = GetUserChoice();
                    switch (choice) //switch til at køre det valgte spil
                    {
                        case "1":
                            MainMenuTicTacToe(); break;
                        case "2":
                            BattleShipsMenu bsm = new BattleShipsMenu();
                             bsm.BattleshipsMenu(); break;
                        case "0":
                            running = false; break;
                        default:
                            ShowMenuSelectionError(); break;
                    }
                }
                catch
                {
                    ShowMenuSelectionError();
                }
            } while (running);
    
           
        }

       
        public void MainMenuTicTacToe()
        {
            bool running = true; // køre i et bool while loop så længe at bool er true
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Standard eller Variation? \n");
                    Console.WriteLine("1. Standard  --->  man spiller indtil at pladen er fyldt");
                    Console.WriteLine("2. Variation --->  man må kun placere 3 brikker herefter skal man flytte på dem ");
                    Console.WriteLine("X starter Altid");
                    Console.WriteLine("");

                    Console.WriteLine("0. Exit");
                    string choice = GetUserChoice();
                    switch (choice) //switch til at køre det valgte spil
                    {
                        case "1": ShowStandard(); break;
                        case "2": ShowVariation(); break;
                        case "0": running = false; break;
                        default: ShowMenuSelectionError(); break;
                    }
                }
                catch
                {
                    ShowMenuSelectionError();
                }
            } while (running);
        }

        public void ShowVariation()
        {
            bool running = true;
            do
            {
                try
                {
                    Console.Clear();
                    ShowMenuVariation();
                    string choice = GetUserChoice();
                    switch (choice) // gøre det samme bare med menu i spiltypen variation
                    {
                        case "1": DoActionFor1(); break;
                        case "2": DoActionFor2(); break;
                        case "3": DoActionFor3(); break;
                        case "0": running = false; break;
                        default: ShowMenuSelectionError(); break;
                    }
                    ticTacToe.Validate();

                }
                catch
                {
                    ShowMenuSelectionError();
                }

            } while (running);
        }
        public void ShowStandard()
        {
            bool running = true;

            do
            {
                try
                {
                    Console.Clear();
                    ShowMenuStandard();
                    string choice = GetUserChoice();
                    switch (choice) // gør det samme bare med standard spillet
                    {
                        case "0": running = false; break;
                        case "1": DoActionFor1(); break;
                        case "2": DoActionFor2(); break;
                        default: ShowMenuSelectionError(); break;
                    }
                    ticTacToe.Validate();
                    turns++; // hver gang loopet køre en omgang pluses turns med 1
                    if (turns == 10) // max antal ture er sat til 10

                    {// hvis turnes er lig med 10 udskriver den besked Draw
                        Console.Clear();
                        Console.WriteLine("draw");
                        Console.ReadKey();
                    }
                }

                catch
                {
                    ShowMenuSelectionError();
                }

            } while (running);
        }
        private void ShowMenuStandard()
        {
            if (ticTacToe != null)
            {
                Console.WriteLine(ticTacToe.GetGameBoardView());
            } //udskriver standard menu i consolen
            Console.WriteLine("tic tac toe - standard");
            Console.WriteLine();
            Console.WriteLine("1. Opret nyt spil");
            Console.WriteLine("2. Sæt en brik");
            Console.WriteLine();
            Console.WriteLine("0. Exit");

        }
        private void ShowMenuVariation()
        {
            Console.Clear();
            if (ticTacToe != null)
            {
                Console.WriteLine(ticTacToe.GetGameBoardView());
            }

            Console.WriteLine("tic tac toe - variation");
            Console.WriteLine();
            Console.WriteLine("1. Opret nyt spil");
            Console.WriteLine("2. Sæt en brik");
            Console.WriteLine("3. Flyt en brik");
            Console.WriteLine();
            Console.WriteLine("0. Exit");
        }

        protected string GetUserChoice()//kaldes for at få input fra user
        {
            Console.WriteLine();
            Console.Write("Indtast dit valg: ");
            return Console.ReadLine();
        }

        protected void ShowMenuSelectionError()
        {
            turns--; //der ikke bliver sat en brik skal turnes ikke plusses med en så derfor minuser vi med 1 her
            Console.WriteLine("Ugyldigt valg.");
            Console.ReadKey();
        }

        private void DoActionFor1()//stater et spil
        {
            ticTacToe = new TicTacToe();
        }
        private void DoActionFor2()//sætter en brik

        {
            try
            {
                Console.WriteLine("Indtast en værdi (mellem 1 og 9)");
                int x = int.Parse(Console.ReadLine());
                ticTacToe.PutPiece(x);

            }
            catch
            {
                ShowMenuSelectionError();
            }
        }

        private void DoActionFor3()//flytter en brik
        {
            try
            {
                Console.WriteLine("Fra hvilket felt vil ønsker du at flytte din brik? \n");
                Console.WriteLine("Indtast en værdi for X (mellem 1 og 9)");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Hvortil ønsker du at flytte din brik? \n");
                Console.WriteLine("Indtast en værdi for X (mellem 1 og 9)");
                int z = int.Parse(Console.ReadLine());
                ticTacToe.RemovePiece(x, z);
            }
            catch
            {
                ShowMenuSelectionError();
            }
        }
      
}
}