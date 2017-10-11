﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            battleShips.Skifttur();
            int shipLength = 3;
            char shipNumber = '2';
            int startx = 5;
            int starty = 5;
            bool horizontal = false;
            battleShips.DeployShip(shipLength, startx, starty, horizontal, shipNumber);

            //shooting ship

            battleShips.Shoot(battleShips.board, 5, 5);
            battleShips.Shoot(battleShips.board, 5, 6);
            battleShips.Shoot(battleShips.board, 5, 7);
            Assert.AreEqual(true, battleShips.ShipIsBombed(battleShips.board));
        }

        [TestMethod]
        public void DetectIfShipIsAlive()
        {
            battleShips.Skifttur();
            int shipLength = 3;
            char shipNumber = '2';
            int startx = 5;
            int starty = 5;
            bool horizontal = false;
            battleShips.DeployShip(shipLength, startx, starty, horizontal, shipNumber);

            battleShips.savedChar = '2';

            Assert.AreEqual(false, battleShips.ShipIsBombed(battleShips.board));
        }

        [TestMethod]
        public void CanDetectHit()
        {
            battleShips.Skifttur();
            int shipLength = 3;
            char shipNumber = '2';
            int startx = 5;
            int starty = 5;
            bool horizontal = false;
            battleShips.DeployShip(shipLength, startx, starty, horizontal, shipNumber);

            Assert.AreEqual("Ramt!", battleShips.Shoot(battleShips.board, 5, 5));
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
            Assert.AreEqual(battleShips.board, battleShips.B2);

            shipLength = 3;
            shipNumber = '3';
            startx = 1;
            starty = 1;
            horizontal = true;
            //Sixth deployment
            battleShips.DeployShip(shipLength, startx, starty, horizontal, shipNumber);
            battleShips.Skifttur();
            Assert.AreEqual(battleShips.board, battleShips.B2);
        }
        [TestMethod]
        public void SwitchBetweenPlayersAfterShipDeployment()
        {
            battleShips.Skifttur();
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
            shipLength = 4; shipNumber = '4'; startx = 1; starty = 3; horizontal = true;
            battleShips.DeployShip(shipLength, startx, starty, horizontal, shipNumber);
            battleShips.Skifttur();
            Assert.AreEqual(battleShips.board, battleShips.B1);

            //Fourth deployment
            shipLength = 5; shipNumber = '5'; startx = 1; starty = 4; horizontal = true;
            battleShips.DeployShip(shipLength, startx, starty, horizontal, shipNumber);
            battleShips.Skifttur();
            Assert.AreEqual(battleShips.board, battleShips.B1);

            //Fifth deployment
            shipLength = 3; shipNumber = '3'; startx = 1; starty = 5; horizontal = true;
            battleShips.DeployShip(shipLength, startx, starty, horizontal, shipNumber);
            battleShips.Skifttur();
            Assert.AreEqual(battleShips.board, battleShips.B2);

            shipLength = 3;
            shipNumber = '3';
            startx = 1;
            starty = 1;
            horizontal = true;
            //Sixth deployment
            battleShips.DeployShip(shipLength, startx, starty, horizontal, shipNumber);
            battleShips.Skifttur();
            Assert.AreEqual(battleShips.board, battleShips.B2);

            shipLength = 4;
            shipNumber = '3';
            startx = 1;
            starty = 2;
            horizontal = true;
            //Seventh deployment
            battleShips.DeployShip(shipLength, startx, starty, horizontal, shipNumber);
            battleShips.Skifttur();
            Assert.AreEqual(battleShips.board, battleShips.B2);

            shipLength = 3;
            shipNumber = '3';
            startx = 1;
            starty = 3;
            horizontal = true;
            // 8th Deployment
            battleShips.DeployShip(shipLength, startx, starty, horizontal, shipNumber);
            battleShips.Skifttur();
            Assert.AreEqual(battleShips.board, battleShips.B2);

            shipLength = 3;
            shipNumber = '3';
            startx = 1;
            starty = 4;
            horizontal = true;
            // 9th deployment
            battleShips.DeployShip(shipLength, startx, starty, horizontal, shipNumber);
            battleShips.Skifttur();
            Assert.AreEqual(battleShips.board, battleShips.B2);

            shipLength = 3;
            shipNumber = '3';
            startx = 1;
            starty = 5;
            horizontal = true;
            //10th deployment
            battleShips.DeployShip(shipLength, startx, starty, horizontal, shipNumber);
            battleShips.Skifttur();
            Assert.AreEqual(battleShips.board, battleShips.B1);

            ////Nu skal den skifte efter hver tur.

            shipLength = 3;
            shipNumber = '3';
            startx = 1;
            starty = 8;
            horizontal = true;
            //11th deployment
            battleShips.DeployShip(shipLength, startx, starty, horizontal, shipNumber);
            battleShips.Skifttur();
            Assert.AreEqual(battleShips.board, battleShips.B2);


            shipLength = 3;
            shipNumber = '3';
            startx = 1;
            starty = 7;
            horizontal = true;
            //11th deployment
            battleShips.DeployShip(shipLength, startx, starty, horizontal, shipNumber);
            battleShips.Skifttur();
            Assert.AreEqual(battleShips.board, battleShips.B1);
        }
    }

}
