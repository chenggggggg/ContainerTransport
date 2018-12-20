using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContainerTransportManager.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerTransportManager.Classes.Tests
{
    [TestClass()]
    public class ShipTests
    {
        [TestMethod()]
        public void CreateContainerPilesTest()
        {
            Ship testShip = new Ship();
            testShip.ContainerPiles = testShip.CreateContainerPiles(5, 5);
            //testShip.ContainerPiles = testShip.CreateContainerPiles(4, 8);
            /*
            //test for amount of containerpiles
            int actual = testShip.ContainerPiles.Count;
            int expected = 25;
            //int expected = 32;
            */

            //test shipside of pile
            ShipSide actual = testShip.ContainerPiles[10].Side;
            ShipSide expected = ShipSide.Middle;

            Assert.AreEqual(expected, actual);
        }
    }
}