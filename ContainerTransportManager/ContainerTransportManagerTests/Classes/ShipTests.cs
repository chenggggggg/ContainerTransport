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
        public void MiddleShipSideContainerPilesTest()
        {
            Ship testShip = new Ship();
            testShip.ContainerPiles = testShip.CreateContainerPiles(3, 3);

            ShipSide actual = testShip.ContainerPiles[3].Side;
            ShipSide expected = ShipSide.Middle;


            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CreatedContainerPilesCountTest()
        {
            Ship testShip = new Ship();

            //test for amount of containerpiles
            testShip.ContainerPiles = testShip.CreateContainerPiles(5, 5);
            int actual = testShip.ContainerPiles.Count;
            int expected = 25;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CreateContainerPilesTest()
        {
            Ship testShip = new Ship();

            testShip.ContainerPiles = testShip.CreateContainerPiles(4, 8);
            //test shipside of pile

            ShipSide actual = testShip.ContainerPiles[15].Side;
            ShipSide expected = ShipSide.Left;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void InvalidTotalWeightTest()
        {
            List<Container> testContainers = new List<Container>();

            Ship testShip = new Ship(2, 2);

            Container testContainer1 = new Container(0, 20, ContainerType.Regular);
            Container testContainer2 = new Container(0, 20, ContainerType.Regular);
            Container testContainer3 = new Container(0, 20, ContainerType.Regular);
            testContainers.Add(testContainer1);
            testContainers.Add(testContainer2);
            testContainers.Add(testContainer3);


            bool expected = false;
            bool actual = testShip.ValidateLoadingWeight(testContainers);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ValidTotalWeightTest()
        {
            List<Container> testContainers = new List<Container>();

            Ship testShip = new Ship(2, 2);

            for (int i = 0; i < 10; i++)
            {
                Container testContainer = new Container(i, 30, ContainerType.Regular);
                testContainers.Add(testContainer);
            }

            bool expected = true;
            bool actual = testShip.ValidateLoadingWeight(testContainers);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SortRegularContainersTest()
        {
            Ship testShip = new Ship
            {
                ContainerPiles = new List<ContainerPile>()
            };

            ContainerPile testPile1 = new ContainerPile(0, 0, 0, ShipSide.Left);
            ContainerPile testPile2 = new ContainerPile(1, 1, 0, ShipSide.Left);
            ContainerPile testPile3 = new ContainerPile(2, 2, 0, ShipSide.Right);
            ContainerPile testPile4 = new ContainerPile(3, 3, 0, ShipSide.Right);

            List<ContainerPile> containerPiles = new List<ContainerPile>
            {
                testPile1,
                testPile2,
                testPile3,
                testPile4,
            };
            testShip.ContainerPiles = containerPiles;
            
            List<Container> containers = new List<Container>();
            for (int i = 0; i < 9; i++)
            {
                Container testContainer = new Container(i, 20, ContainerType.Regular);
                containers.Add(testContainer);
            }

            testShip.SortContainersOfTypeInPiles(containerPiles, containers, ContainerType.Regular);
            int expected = 5;
            int actual = testShip.ContainerPiles[0].Containers.Count;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void SortCooledContainersTest()
        {
            Ship testShip = new Ship
            {
                ContainerPiles = new List<ContainerPile>()
            };

            ContainerPile testPile1 = new ContainerPile(0, 0, 0, ShipSide.Left);
            ContainerPile testPile2 = new ContainerPile(1, 1, 0, ShipSide.Left);
            ContainerPile testPile3 = new ContainerPile(2, 2, 0, ShipSide.Right);
            ContainerPile testPile4 = new ContainerPile(3, 3, 0, ShipSide.Right);

            List<ContainerPile> containerPiles = new List<ContainerPile>
            {
                testPile1,
                testPile2,
                testPile3,
                testPile4,
            };
            testShip.ContainerPiles = containerPiles;

            List<Container> containers = new List<Container>();
            for (int i = 0; i < 9; i++)
            {
                Container testContainer = new Container(i, 20, ContainerType.Cooled);
                containers.Add(testContainer);
            }

            testShip.SortContainersOfTypeInPiles(containerPiles, containers, ContainerType.Cooled);
            int expected = 5;
            int actual = testShip.ContainerPiles[0].Containers.Count;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void SortValuableContainersTest()
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

            List<ContainerPile> containerPiles = new List<ContainerPile>
            {
                testPile1,
                testPile2,
                testPile3,
                testPile4,
                testPile5,
                testPile6,
                testPile7,
                testPile8
            };
            testShip.ContainerPiles = containerPiles;

            List<Container> containers = new List<Container>();
            for (int i = 0; i < 9; i++)
            {
                Container testContainer = new Container(i, 20, ContainerType.Valuable);
                containers.Add(testContainer);
            }

            testShip.SortContainersOfTypeInPiles(containerPiles, containers, ContainerType.Valuable);
            int expected = 1;
            int actual = testShip.ContainerPiles[0].Containers.Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ValidateRegularContainerInPileTest()
        {
            ContainerPile testPile = new ContainerPile(0, 0, 0, ShipSide.Left);

            Container testContainer = new Container(0, 20, ContainerType.Regular);

            Ship testShip = new Ship();

            bool expected = false;
            bool actual = testShip.ValidateContainerInPile(testContainer, testPile, 0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ValidateCooledContainerInPileTest()
        {
            ContainerPile testPile = new ContainerPile(0, 0, 0, ShipSide.Left);

            Container testContainer = new Container(0, 20, ContainerType.Cooled);

            Ship testShip = new Ship();

            bool expected = false;
            bool actual = testShip.ValidateContainerInPile(testContainer, testPile, 0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ValidateCooledContainerInNotFirstRowPileTest()
        {
            ContainerPile testPile = new ContainerPile(0, 0, 2, ShipSide.Left);

            Container testContainer = new Container(0, 20, ContainerType.Cooled);

            Ship testShip = new Ship();

            bool expected = true;
            bool actual = testShip.ValidateContainerInPile(testContainer, testPile, 0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ValidateValuableContainerInFirstRowPileTest()
        {
            ContainerPile testPile = new ContainerPile(0, 0, 0, ShipSide.Left);

            Container testContainer = new Container(0, 20, ContainerType.Valuable);

            Ship testShip = new Ship();

            bool expected = false;
            bool actual = testShip.ValidateContainerInPile(testContainer, testPile, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ValidateValuableContainerInLastRowPileTest()
        {
            ContainerPile testPile = new ContainerPile(0, 0, 2, ShipSide.Left);

            Container testContainer = new Container(0, 20, ContainerType.Valuable);

            Ship testShip = new Ship();

            bool expected = false;
            bool actual = testShip.ValidateContainerInPile(testContainer, testPile, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ValidateValuableContainerInNeitherFirstOrLastRowPileTest()
        {
            ContainerPile testPile = new ContainerPile(0, 0, 2, ShipSide.Left);

            Container testContainer = new Container(0, 20, ContainerType.Valuable);

            Ship testShip = new Ship();

            bool expected = true;
            bool actual = testShip.ValidateContainerInPile(testContainer, testPile, 6);

            Assert.AreEqual(expected, actual);
        }
    }
}