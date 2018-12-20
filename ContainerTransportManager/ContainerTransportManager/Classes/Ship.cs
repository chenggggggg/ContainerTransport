using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerTransportManager.Classes
{
    public class Ship
    {
        public int MaxColumns { get; set; }
        public int MaxRows { get; set; }
        public List<ContainerPile> ContainerPiles { get; set; }

        public Ship()
        {

        }

        public List<ContainerPile> SortContainersInPiles()
        {

        }

        public List<ContainerPile> CreateContainerPiles(int maxcolumns, int maxrows)
        {
            List<ContainerPile> containerPiles = new List<ContainerPile>();
            int containerId = 0;
            for (int x = 0; x < maxcolumns; x++)
            {
                ShipSide side = ShipSide.Middle;
                int numberOfHalf = maxcolumns / 2;
                if (x < numberOfHalf)
                {
                    side = ShipSide.Left;
                }
                else if (x > numberOfHalf)
                {
                    side = ShipSide.Right;
                }
                for (int y = 0; y < maxrows; y++)
                {
                    ContainerPile containerPileWithPosition = new ContainerPile(containerId, x, y, side);
                    containerPiles.Add(containerPileWithPosition);
                    containerId++;
                }
            }
            return containerPiles;
        }

    }
}
