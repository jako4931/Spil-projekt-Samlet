using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil

{
    class BattleShipsMenu : GameMenu
    {
        Battleships battleships { get; set; }
        public int Turns = 0;
        public void BattleshipsMenu()
        {
            bool running = true;
            do
            {
                Console.WriteLine("Battle Ships Menu \n");
                Console.WriteLine("1. Start new game \n2. Deploy ship. \n0. Exit ");
                string choice = GetUserChoice();
                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        battleships = new Battleships();
                        battleships.Skifttur();
                        Console.WriteLine(battleships.GetBoardView(battleships.board, battleships.board2));
                        break;
                    case "2":
                        DeployMenu();
                        battleships.Skifttur();
                        Console.WriteLine(battleships.GetBoardView(battleships.board, battleships.board2));
                        break;
                    case "0": running = false; break;
                    default: ShowMenuSelectionError(); break;
                }
                
            } while (running);

        }
        public void DeployMenu()
        {
            Console.WriteLine("Selected a ship to deploy\n");
            Console.WriteLine("5. Aircraft carrier \n4. Battleship \n3. Destroyer \n2. Submarine \n1. Rambo");
            int shipLength = 0;
            char shipNumber = ' ';
            string choice = GetUserChoice();

            switch (choice)
            {
                case "1": shipLength = 2; shipNumber = '1'; break;
                case "2": shipLength = 3; shipNumber = '2'; break;
                case "3": shipLength = 3; shipNumber = '3'; break;
                case "4": shipLength = 4; shipNumber = '4'; break;
                case "5": shipLength = 5; shipNumber = '5'; break;
                default: ShowMenuSelectionError(); break;
            }
            Console.WriteLine("Fra hvilket felt skal dit skib gå?\n");
            Console.WriteLine("x-værdi: ");
            int xValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Indtast y-værdi: ");
            int yValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Skal skkibet placeres lodret eller vanret");
            Console.WriteLine("1. Vandret \n2. Lodret");
            bool horizontal = true;
            choice = GetUserChoice();
            switch (choice)
            {
                case "1": horizontal = true; break;
                case "2": horizontal = false; break;
                default: ShowMenuSelectionError(); break;
            }
            battleships.DeployShip(shipLength, xValue, yValue, horizontal, shipNumber);
            Console.Clear();
            Turns++;
            {
                if (Turns > 9)
                {
                    Console.WriteLine(battleships.GetBoardView(battleships.board, battleships.board2));
                    ShootBattleShipsMenu();
                }
            }

        }
        public void ShootShipMenu()
        {
            Console.WriteLine("Hvilket felt vil du skyde? \n"); ;
            Console.WriteLine("x-værdi: ");
            int xValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Indtast y-værdi: ");
            int yValue = int.Parse(Console.ReadLine());

            Console.WriteLine(battleships.Shoot(battleships.board, xValue, yValue));
            Console.ReadKey();
            Console.Clear();
        }


        public void ShootBattleShipsMenu()
        {
            bool running = true;
            do
            {
                
                Console.WriteLine("Skyde Menu \n");
                Console.WriteLine("1. Start new game \n2. Affyr Skud\n0. Exit ");
                string choice = GetUserChoice();
                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        battleships = new Battleships();
                        Console.WriteLine(battleships.GetBoardView(battleships.board, battleships.board2));
                        break;
                    case "2":
                        ShootShipMenu();
                        Console.WriteLine(battleships.GetBoardView(battleships.board, battleships.board2));
                        break;
                    case "0": running = false; break;
                    default: ShowMenuSelectionError(); break;
                }

            } while (running);

        }

    }
}
