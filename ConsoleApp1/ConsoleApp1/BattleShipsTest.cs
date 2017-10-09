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
            int shipLength = 4;
            char shipNumber = '4';
            int startx = 2;
            int starty = 2;
            bool horizontal = true;
            battleShips.DeployShip(battleShips.B1, shipLength, startx, starty, horizontal, shipNumber);
            for (int i = 0; i < shipLength; i++)
            {
                Assert.AreEqual('4', battleShips.B1[(startx-1) + i, (starty-1)]);
            }
            
            battleShips.DeployShip(battleShips.B2, shipLength, startx, starty, horizontal, shipNumber);
            for (int i = 0; i < shipLength; i++)
            {
                Assert.AreEqual('4', battleShips.B2[(startx - 1) + i, (starty - 1)]);
            }


        }

        [TestMethod]
        public void DetectIfShipIsBombed()
        { 
            int shipLength = 3;
            char shipNumber = '2';
            int startx = 5;
            int starty = 5;
            bool horizontal = false;
            battleShips.DeployShip(battleShips.B1, shipLength, startx, starty, horizontal, shipNumber);

            //shooting ship

            battleShips.Shoot(battleShips.B1, 5, 5);
            battleShips.Shoot(battleShips.B1, 5, 6);
            battleShips.Shoot(battleShips.B1, 5, 7);
            Assert.AreEqual(true, battleShips.ShipIsBombed(battleShips.B1));
        }

        [TestMethod]
        public void DetectIfShipIsAlive()
        {
            int shipLength = 3;
            char shipNumber = '2';
            int startx = 5;
            int starty = 5;
            bool horizontal = false;
            battleShips.DeployShip(battleShips.B1, shipLength, startx, starty, horizontal, shipNumber);

            battleShips.savedChar = '2';

            Assert.AreEqual(false, battleShips.ShipIsBombed(battleShips.B1));
        }

        [TestMethod]
        public void CanDetectHit()
        {
            int shipLength = 3;
            char shipNumber = '2';
            int startx = 5;
            int starty = 5;
            bool horizontal = false;
            battleShips.DeployShip(battleShips.B1, shipLength, startx, starty, horizontal, shipNumber);

            Assert.AreEqual("Ramt!", battleShips.Shoot(battleShips.B1, 5, 5));
        }
    }

}
