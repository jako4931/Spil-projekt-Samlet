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
                        Console.WriteLine(battleships.GetBoardView());
                        break;
                    case "2":
                        Console.Clear();
                        DeployMenu();
                        Console.WriteLine(battleships.GetBoardView());
                        break;
                    case "0": running = false; break;
                    default: ShowMenuSelectionError(); break;
                }

            } while (running);

        }
        public void DeployMenu()
        {
            Console.WriteLine("Selected a ship to deploy\n");
            Console.WriteLine("1. Aircraft carrier \n2. Battleship \n3. Destroyer \n4. Submarine \n5. Rambo");
            int shipLength = 0;
            string choice = GetUserChoice();

            switch (choice)
            {
                case "1": shipLength = 5; break;
                case "2": shipLength = 4; break;
                case "3": shipLength = 3; break;
                case "4": shipLength = 3; break;
                case "5": shipLength = 2; break;
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
            battleships.DeployShip(shipLength, xValue, yValue, horizontal);
            Console.Clear();

        }


    }
}
