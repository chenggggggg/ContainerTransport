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

            Ship testShip = new Ship(2, 2);
            for (int i = 0; i < 10; i++)
            {
                Container testContainer = new Container(i, 30, ContainerType.Regular, 0);
                testContainers.Add(testContainer);
            }
            /*
            //First test for 3 containers.
            Container testContainer1 = new Container(0, 20, ContainerType.Regular, 0);
            Container testContainer2 = new Container(0, 20, ContainerType.Regular, 0);
            Container testContainer3 = new Container(0, 20, ContainerType.Regular, 0);
            testContainers.Add(testContainer1);
            testContainers.Add(testContainer2);
            testContainers.Add(testContainer3);
            Ship testShip = new Ship(5, 5);
            */

            bool expected = true;
            bool actual = testShip.ValidateLoadingWeight(testContainers);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SortContainersOfTypeInPilesTest()
        {
            Ship testShip = new Ship
            {
                ContainerPiles = new List<ContainerPile>()
            };

            ContainerPile testPile1 = new ContainerPile(0, 0, 0, ShipSide.Left);
            ContainerPile testPile2 = new ContainerPile(1, 1, 0, ShipSide.Left);
            ContainerPile testPile3 = new ContainerPile(2, 2, 0, ShipSide.Right);
            ContainerPile testPile4 = new ContainerPile(3, 3, 0, ShipSide.Right);
            ContainerPile testPile5 = new ContainerPile(4, 0, 1, ShipSide.Left);
            ContainerPile testPile6 = new ContainerPile(5, 1, 1, ShipSide.Left);
            ContainerPile testPile7 = new ContainerPile(6, 2, 1, ShipSide.Right);
            ContainerPile testPile8 = new ContainerPile(7, 3, 1, ShipSide.Right);
            ContainerPile testPile9 = new ContainerPile(8, 0, 2, ShipSide.Left);
            ContainerPile testPile10 = new ContainerPile(9, 1, 2, ShipSide.Left);
            ContainerPile testPile11 = new ContainerPile(10, 2, 2, ShipSide.Right);
            ContainerPile testPile12 = new ContainerPile(11, 3, 2, ShipSide.Right);

            List<ContainerPile> containerPiles = new List<ContainerPile>
            {
                testPile1,
                testPile2,
                testPile3,
                testPile4,
                testPile5,
                testPile6,
                testPile7,
                testPile8,
                testPile9,
                testPile10,
                testPile11,
                testPile12
            };
            testShip.ContainerPiles = containerPiles;
            /*
            Container testContainer1 = new Container(0, 20, ContainerType.Cooled, 0);
            Container testContainer2 = new Container(1, 20, ContainerType.Cooled, 0);
            Container testContainer3 = new Container(2, 20, ContainerType.Cooled, 0);
            Container testContainer4 = new Container(3, 20, ContainerType.Cooled, 0);
            Container testContainer5 = new Container(4, 20, ContainerType.Cooled, 0);
            Container testContainer6 = new Container(5, 20, ContainerType.Cooled, 0);
            Container testContainer7 = new Container(6, 20, ContainerType.Cooled, 0);
            Container testContainer8 = new Container(7, 20, ContainerType.Cooled, 0);
            Container testContainer9 = new Container(8, 20, ContainerType.Cooled, 0);
            */
            Container testContainer1 = new Container(0, 20, ContainerType.Regular, 0);
            Container testContainer2 = new Container(1, 20, ContainerType.Regular, 0);
            Container testContainer3 = new Container(2, 20, ContainerType.Regular, 0);
            Container testContainer4 = new Container(3, 20, ContainerType.Regular, 0);
            Container testContainer5 = new Container(4, 20, ContainerType.Regular, 0);
            Container testContainer6 = new Container(5, 20, ContainerType.Regular, 0);
            Container testContainer7 = new Container(6, 20, ContainerType.Regular, 0);
            Container testContainer8 = new Container(7, 20, ContainerType.Regular, 0);
            Container testContainer9 = new Container(8, 20, ContainerType.Regular, 0);
            
            List<Container> containers = new List<Container>
            {
                testContainer1,
                testContainer2,
                testContainer3,
                testContainer4,
                testContainer5,
                testContainer6,
                testContainer7,
                testContainer8,
                testContainer9
            };

            //testShip.SortContainersOfTypeInPiles(containerPiles, containers, ContainerType.Cooled);
            testShip.SortContainersOfTypeInPiles(containerPiles, containers, ContainerType.Regular);
            int expected = 5;
            int actual = testShip.ContainerPiles[0].Containers.Count;
            Assert.AreEqual(expected, actual);
        }
    }
}