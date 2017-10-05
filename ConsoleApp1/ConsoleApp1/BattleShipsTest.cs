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
        public void CanDeployShipOnBoardOne()
        {
            int shipLength = 3;
            int startx = 5;
            int starty = 5;
            bool horizontal = true;
            battleShips.DeployShip(shipLength, startx, starty, horizontal);
            for (int i = 0; i > shipLength; i++)
            {
                Assert.AreEqual('X', battleShips.B1[startx + i, starty]);
            }
            
        }
        [TestMethod]
        public void CanDeployShipOnBoardTwo()
        {
            int shipLength = 3;
            int startx = 5;
            int starty = 5;
            bool horizontal = false;
            battleShips.DeployShip(shipLength, startx, starty, horizontal);
            for (int i = 0; i > shipLength; i++)
            {
                Assert.AreEqual('X', battleShips.B2[startx, starty + i]);
            }
        }
        //[TestMethod]
        //public void CantDeployShipOutsideBoard()
        //{
         //   int shipLength = 5;
          //  int startx = 10;
           // int starty = 10;
         //   bool horizontal = false;

        
       // }

    }

}
