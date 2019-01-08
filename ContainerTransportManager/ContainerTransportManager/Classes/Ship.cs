using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContainerTransportManager.Classes;

namespace ContainerTransportManager.Classes
{
    public enum ShipSide
    {
        Left = 0,
        Right = 1,
        Middle = 2
    }
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
            this.MaxColumns = maxcolumns;
            this.MaxRows = maxrows;
            this.ContainerPiles = CreateContainerPiles(this.MaxColumns, this.MaxRows); 
        }

        public List<ContainerPile> SortAllContainersInShip(List<Container> containers)
        {
            List<ContainerPile> containerPilesOfShip = this.ContainerPiles;

            if (ValidateLoadingWeight(containers))
            {
                //There are 3 types of containers, and must all be sorted separately.
                for (int i = 0; i < 2; i++)
                {
                    ContainerType type = (ContainerType)i;
                    containerPilesOfShip = SortContainersOfTypeInPiles(containerPilesOfShip, containers, type);
                }
            }
            return containerPilesOfShip;
        }

        public List<ContainerPile> SortContainersOfTypeInPiles(List<ContainerPile> containerpiles, List<Container> containers, ContainerType containertype)
        {            
            List<Container> containersOfType = GetContainersOfType(containers, containertype);

            foreach (Container c in containersOfType)
            {
                int weightOfLeftSide = GetWeightOfShipSide(ShipSide.Left, containerpiles);
                int weightOfRightSide = GetWeightOfShipSide(ShipSide.Right, containerpiles);

                ShipSide shipSide = ShipSide.Left;
                if (weightOfLeftSide > weightOfRightSide)
                {
                    shipSide = ShipSide.Right;
                }

                foreach (ContainerPile pile in containerpiles)
                {
                    int topLoadWeight = pile.GetTopLoadWeight();

                    if (pile.Side == shipSide && topLoadWeight + c.Weight <= 120)
                    {
                        bool exitLoop = ValidateContainerInPile(c, pile, containerpiles.Last().Row); 
                        if (exitLoop)
                        {
                            break;
                        }

                        pile.Containers.Add(c);
                        containersOfType.Remove(c);
                        break;
                    }
                }
            }
            return containerpiles;
        }

        public bool ValidateContainerInPile(Container container, ContainerPile containerpile, int lastPileRow)
        {
            bool IsContainerInvalid = false;
            switch (container.Type)
            {
                case ContainerType.Cooled:
                    {
                        if (containerpile.Row != 0)
                        {
                            IsContainerInvalid = true;
                        }
                        break;
                    }
                case ContainerType.Valuable:
                    {
                        if (containerpile.Row != 0 && containerpile.Row != lastPileRow)
                        {
                            IsContainerInvalid = true;
                        }
                        break;
                    }
            }
            return IsContainerInvalid;
        }
        /// <summary>
        /// Returns a list of containers with the specified containertype.
        /// </summary>
        /// <param name="containers"></param>
        /// <param name="containertype"></param>
        /// <returns></returns>
        public List<Container> GetContainersOfType(List<Container> containers, ContainerType containertype)
        {
            List<Container> containerOfType = new List<Container>();
            foreach (Container c in containers)
            {
                if (c.Type == containertype)
                {
                    containerOfType.Add(c);
                }
            }
            return containerOfType;
        }
        /// <summary>
        /// Returns the total weight of the specified side of the ship.
        /// </summary>
        /// <param name="side"></param>
        /// <param name="containerpiles"></param>
        /// <returns></returns>
        public int GetWeightOfShipSide(ShipSide side, List<ContainerPile> containerpiles)
        {
            int weight = 0;
            foreach (ContainerPile pile in containerpiles)
            {
                if (pile.Side == side)
                {
                    foreach (Container c in pile.Containers)
                    {
                        weight = weight + c.Weight;
                    }
                }
            }
            return weight;
        }
        /// <summary>
        /// Runs a check if the total weight of loading containers are above 50% of maximum loading weight of the ship. Returns true if valid.
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
