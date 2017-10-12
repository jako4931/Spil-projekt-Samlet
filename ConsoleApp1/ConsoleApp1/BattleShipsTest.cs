using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace spil
{
    [TestClass]
    public class BattleShipsTest
    {

        // Test setup
        Battleships battleShips = new Battleships();
        BattleShipsMenu battleShipsMenu = new BattleShipsMenu();
        GameMenu gameMenu = new GameMenu();

        [TestMethod]
        public void CanDeployShipOnAllBoards()
        {
            battleShips.Skifttur();
            int shipLength = 4;
            char shipNumber = '4';
            int startx = 2;
            int starty = 2;
            bool horizontal = true;
            battleShips.DeployShip(shipLength, startx, starty, horizontal, shipNumber);
            for (int i = 0; i < shipLength; i++)
            {
                Assert.AreEqual('4', battleShips.board[(startx-1) + i, (starty-1)]);
            }
            battleShips.Skifttur(); battleShips.Skifttur(); battleShips.Skifttur(); battleShips.Skifttur();
            battleShips.Skifttur(); //Skifter tur fem gange for at ændre board.
            battleShips.DeployShip(shipLength, startx, starty, horizontal, shipNumber);
            for (int i = 0; i < shipLength; i++)
            {
                Assert.AreEqual('4', battleShips.board[(startx - 1) + i, (starty - 1)]);
            }


        }

        [TestMethod]
        public void DetectIfShipIsBombed()
        {
            // test setups
            battleShips.turns = 10;
            battleShips.Skifttur();

            int shipLength = 3;
            char shipNumber = '2';
            int startx = 5;
            int starty = 5;
            bool horizontal = false;
            battleShips.DeployShip(shipLength, startx, starty, horizontal, shipNumber);

          battleShips.Skifttur();
            //shooting ship

            battleShips.Shoot(5, 5);
            battleShips.Shoot(5, 6);
            battleShips.Shoot(5, 7);
            Assert.AreEqual(true, battleShips.ShipIsBombed());
        }

        [TestMethod]
        public void DetectIfShipIsAlive()
        {
            battleShips.turns = 10;
            battleShips.Skifttur();
            int shipLength = 3;
            char shipNumber = '2';
            int startx = 5;
            int starty = 5;
            bool horizontal = false;
            battleShips.DeployShip(shipLength, startx, starty, horizontal, shipNumber);
            battleShips.Skifttur();
            battleShips.savedChar = '2';

            Assert.AreEqual(false, battleShips.ShipIsBombed());
        }

        [TestMethod]
        public void CanDetectHit()
        {
            battleShips.turns = 10;

            battleShips.Skifttur();

            int shipLength = 3;
            char shipNumber = '2';
            int startx = 5;
            int starty = 5;
            bool horizontal = false;
            battleShips.DeployShip(shipLength, startx, starty, horizontal, shipNumber);

            battleShips.Skifttur();

            Assert.AreEqual("Ramt!", battleShips.Shoot(5, 5));
        }
        [TestMethod]
        public void CanSwitchTurnAfterDeployingFiveShips()
        {
           
            Assert.AreEqual(null, battleShips.board);
            battleShips.Skifttur();
            Assert.AreEqual(battleShips.board, battleShips.B1);

            //First deployment
            int shipLength = 1;
            char shipNumber = '2';
            int startx = 1;
            int starty = 1;
            bool horizontal = true;
            battleShips.DeployShip(shipLength, startx, starty, horizontal, shipNumber);
            battleShips.Skifttur();
            Assert.AreEqual(battleShips.board, battleShips.B1);

            //Second deployment
            shipLength = 2;
            shipNumber = '1';
            startx = 1;
            starty = 2;
            horizontal = true;
            battleShips.DeployShip(shipLength, startx, starty, horizontal, shipNumber);
            battleShips.Skifttur();
            Assert.AreEqual(battleShips.board, battleShips.B1);

            //Third deployment
            shipLength = 4;shipNumber = '4';startx = 1;starty = 3;horizontal = true;
            battleShips.DeployShip(shipLength, startx, starty, horizontal, shipNumber);
            battleShips.Skifttur();
            Assert.AreEqual(battleShips.board, battleShips.B1);

            //Fourth deployment
            shipLength = 5;shipNumber = '5';startx = 1;starty = 4;horizontal = true;
            battleShips.DeployShip(shipLength, startx, starty, horizontal, shipNumber);
            battleShips.Skifttur();
            Assert.AreEqual(battleShips.board, battleShips.B1);

            //Fifth deployment
            shipLength = 3;shipNumber = '3';startx = 1; starty = 5;horizontal = true;
            battleShips.DeployShip(shipLength, startx, starty, horizontal, shipNumber);
            battleShips.Skifttur();
         //   Assert.AreEqual(battleShips.board, battleShips.B2);

            shipLength = 3;
            shipNumber = '3';
            startx = 1;
            starty = 1;
            horizontal = true;
            //Sixth deployment
            battleShips.DeployShip(shipLength, startx, starty, horizontal, shipNumber);
            battleShips.Skifttur();
          //  Assert.AreEqual(battleShips.board, battleShips.B2);
        }
        [TestMethod]
        
        public void SwitchBetweenPlayers()
        {
            // test setup: Her antager vi, at alle spillere har sat deres skibe og skal til at skyde.
            battleShips.turns = 9;
            // skift tur
            battleShips.Skifttur();
            // B2 starter
            Assert.AreEqual(battleShips.B2, battleShips.board);
            
            battleShips.Skifttur();
            // Efter turskifte skulle "board" være lig med B1
            Assert.AreEqual(battleShips.B1, battleShips.board);
        }

       
    }

}
