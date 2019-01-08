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
    public class ContainerPileTests
    {
        [TestMethod()]
        public void GetTopLoadWeightTest()
        {
            ContainerPile testPile = new ContainerPile(0, 0, 0, ShipSide.Left)
            {
                Containers = new List<Container>()
            };

            Container testContainer1 = new Container(0, 20, ContainerType.Regular, 0);
            Container testContainer2 = new Container(0, 20, ContainerType.Regular, 0);
            Container testContainer3 = new Container(0, 20, ContainerType.Regular, 0);
            Container testContainer4 = new Container(0, 50, ContainerType.Regular, 0);

            testPile.Containers.Add(testContainer1);
            testPile.Containers.Add(testContainer2);
            testPile.Containers.Add(testContainer3);
            testPile.Containers.Add(testContainer4);

            int expected = testPile.GetTopLoadWeight();
            int actual = 90;

            Assert.AreEqual(expected, actual);
        }
    }
}