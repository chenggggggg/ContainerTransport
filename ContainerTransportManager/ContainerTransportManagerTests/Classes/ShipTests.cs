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

        [TestMethod()]
        public void ValidateLoadingWeightTest()
        {
            List<Container> testContainers = new List<Container>();

            Container testContainer1 = new Container(0, 20, Container.ContainerType.Regular, 0);
            Container testContainer2 = new Container(0, 20, Container.ContainerType.Regular, 0);
            Container testContainer3 = new Container(0, 20, Container.ContainerType.Regular, 0);
            testContainers.Add(testContainer1);
            testContainers.Add(testContainer2);
            testContainers.Add(testContainer3);

            Ship testShip = new Ship();

            bool expected = true;
            bool actual = testShip.ValidateLoadingWeight(testContainers);
            Assert.AreEqual(expected, actual);
        }
    }
}