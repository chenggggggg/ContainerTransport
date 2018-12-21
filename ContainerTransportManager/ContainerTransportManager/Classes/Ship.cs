using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContainerTransportManager.Classes;

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

        public List<ContainerPile> SortAllContainersInShip(List<Container> containers)
        {
            List<ContainerPile> containerPilesOfShip = CreateContainerPiles(this.MaxColumns, this.MaxRows);

            if (ValidateLoadingWeight(containers))
            {
                containerPilesOfShip = SortCooledContainersInPiles(containerPilesOfShip, GetContainersOfType(containers, ContainerType.Cooled));

                containerPilesOfShip = SortRegularContainersInPiles(containerPilesOfShip, GetContainersOfType(containers, ContainerType.Cooled));

                containerPilesOfShip = SortValuableContainersInPiles(containerPilesOfShip, GetContainersOfType(containers, ContainerType.Cooled));
            }
            return containerPilesOfShip;
        }

        public List<ContainerPile> SortValuableContainersInPiles(List<ContainerPile> containerpiles, List<Container> containers)
        {
            List<Container> valuableContainers = containers;

            foreach (Container c in valuableContainers)
            {
                int weightOfLeftSide = GetWeightOfShipSide(ShipSide.Left, containerpiles);
                int weightOfRightSide = GetWeightOfShipSide(ShipSide.Right, containerpiles);
                if (weightOfLeftSide < weightOfRightSide)
                {
                    foreach (ContainerPile pile in containerpiles)
                    {
                        int topLoadWeight = pile.GetTopLoadWeight();
                        if (pile.Side == ShipSide.Left && topLoadWeight + c.Weight <= 120)
                        {
                            pile.Containers.Add(c);
                            break;
                        }
                    }
                }
                else
                {
                    foreach (ContainerPile pile in containerpiles)
                    {
                        int topLoadWeight = pile.GetTopLoadWeight();
                        if ((pile.Side == ShipSide.Right || pile.Side == ShipSide.Middle) && topLoadWeight + c.Weight <= 120)
                        {
                            pile.Containers.Add(c);
                            break;
                        }
                    }
                }
            }
            return containerpiles;
        }

        public List<ContainerPile> SortRegularContainersInPiles(List<ContainerPile> containerpiles, List<Container> containers)
        {
            List<Container> regularContainers = containers;

            foreach (Container c in regularContainers)
            {
                int weightOfLeftSide = GetWeightOfShipSide(ShipSide.Left, containerpiles);
                int weightOfRightSide = GetWeightOfShipSide(ShipSide.Right, containerpiles);
                if (weightOfLeftSide < weightOfRightSide)
                {
                    foreach (ContainerPile pile in containerpiles)
                    {
                        int topLoadWeight = pile.GetTopLoadWeight();
                        if (pile.Side == ShipSide.Left && topLoadWeight + c.Weight <= 120)
                        {
                            pile.Containers.Add(c);
                            break;
                        }
                    }
                }
                else
                {
                    foreach (ContainerPile pile in containerpiles)
                    {
                        int topLoadWeight = pile.GetTopLoadWeight();
                        if ((pile.Side == ShipSide.Right || pile.Side == ShipSide.Middle) && topLoadWeight + c.Weight <= 120)
                        {
                            pile.Containers.Add(c);
                            break;
                        }
                    }
                }
            }
            return containerpiles;
        }


        public List<ContainerPile> SortCooledContainersInPiles(List<ContainerPile> containerpiles, List<Container> containers)
        {
            List<Container> cooledContainers = containers;

            foreach (Container c in cooledContainers)
            {
                int weightOfLeftSide = GetWeightOfShipSide(ShipSide.Left, containerpiles);
                int weightOfRightSide = GetWeightOfShipSide(ShipSide.Right, containerpiles);
                if (weightOfLeftSide < weightOfRightSide)
                {
                    foreach (ContainerPile pile in containerpiles)
                    {
                        int topLoadWeight = pile.GetTopLoadWeight();
                        if (pile.Side == ShipSide.Left && pile.Row == 0 && topLoadWeight + c.Weight <= 120)
                        {
                            pile.Containers.Add(c);
                            break;
                        }
                    }
                }
                else
                {
                    foreach (ContainerPile pile in containerpiles)
                    {
                        int topLoadWeight = pile.GetTopLoadWeight();
                        if (pile.Side == ShipSide.Right && pile.Row == 0 && topLoadWeight + c.Weight <= 120)
                        {
                            pile.Containers.Add(c);
                            break;
                        }
                    }
                }
            }
            return containerpiles;
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
