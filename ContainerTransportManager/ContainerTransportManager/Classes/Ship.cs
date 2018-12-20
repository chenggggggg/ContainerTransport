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
        public Ship(int maxcolumns, int maxrows)
        {
            MaxColumns = maxcolumns;
            MaxRows = maxrows;
        }
        /*
        public List<ContainerPile> SortContainersInPiles()
        {

        }
        */
        /// <summary>
        /// Runs a check if the total weight of loading containers are above 50% of maximum loading weight of the ship. Returns a bool.
        /// </summary>
        /// <param name="containers"></param>
        /// <returns></returns>
        public bool ValidateLoadingWeight(List<Container> containers)
        {
            int maximumWeight = MaxColumns * MaxRows * 150; //30 ton max. container weight, + 120 ton topload weight.

            int totalWeightOfLoad = 0;
            foreach (Container c in containers)
            {
                totalWeightOfLoad = totalWeightOfLoad + c.Weight;
            }

            if (totalWeightOfLoad >= maximumWeight / 2)
            {
                return true;
            }
            else
            {
                return false;
            }
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
