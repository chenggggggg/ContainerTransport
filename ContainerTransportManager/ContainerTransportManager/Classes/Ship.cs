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

        public void SortAllContainersInShip(List<Container> containers)
        {
            List<ContainerPile> containerPilesOfShip = this.ContainerPiles;

            if (ValidateLoadingWeight(containers))
            {
                //There are 3 types of containers, and must all be sorted separately.
                containerPilesOfShip = SortContainersOfTypeInPiles(containerPilesOfShip, containers, ContainerType.Cooled);
                containerPilesOfShip = SortContainersOfTypeInPiles(containerPilesOfShip, containers, ContainerType.Regular);
                containerPilesOfShip = SortContainersOfTypeInPiles(containerPilesOfShip, containers, ContainerType.Valuable);
            }
            this.ContainerPiles = containerPilesOfShip;
        }
        /// <summary>
        /// Sorts the containers of specified type into container piles. Returns the containerpiles with sorted containers.
        /// </summary>
        /// <param name="containerpiles"></param>
        /// <param name="containers"></param>
        /// <param name="containertype"></param>
        /// <returns></returns>
        public List<ContainerPile> SortContainersOfTypeInPiles(List<ContainerPile> containerpiles, List<Container> containers, ContainerType containertype)
        {
            List<Container> containersOfType = GetContainersOfType(containers, containertype);

            foreach (Container c in containersOfType.ToList())
            {
                if (c.Weight >= 4 && c.Weight <= 30)
                {
                    ShipSide shipSide = ShipSide.Left;
                    if (GetWeightOfShipSide(ShipSide.Left, containerpiles) > GetWeightOfShipSide(ShipSide.Right, containerpiles))
                    {
                        shipSide = ShipSide.Right;
                    }

                    foreach (ContainerPile pile in containerpiles)
                    {
                        int topLoadWeight = pile.GetTopLoadWeight();

                        if (pile.Side == shipSide && topLoadWeight <= 120)
                        {
                            bool goNextPile = ValidateContainerInPile(c, pile, containerpiles.Last().Row);
                            if (!goNextPile)
                            {
                                pile.Containers.Add(c);
                                containersOfType.Remove(c);
                                break;
                            }
                        }
                        else if (pile.Side == ShipSide.Middle && topLoadWeight <= 120)
                        {
                            bool goNextPile = ValidateContainerInPile(c, pile, containerpiles.Last().Row);
                            if (!goNextPile)
                            {
                                pile.Containers.Add(c);
                                containersOfType.Remove(c);
                                break;
                            }
                        }
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
                        if ((containerpile.Row != 0) && (containerpile.Row != lastPileRow))
                        {
                            IsContainerInvalid = true;
                            break;
                        }
                        if (containerpile.Containers.Count > 0)
                        {
                            if (containerpile.Containers.Last().Type == ContainerType.Valuable)
                            {
                                IsContainerInvalid = true;
                                break;
                            }
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
            int maximumWeight = GetMaxShipWeight();

            int totalWeightOfLoad = 0;
            foreach (Container c in containers)
            {
                totalWeightOfLoad = totalWeightOfLoad + c.Weight;
            }

            if (totalWeightOfLoad >= maximumWeight / 2 && totalWeightOfLoad <= maximumWeight)
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
        public int GetMaxShipWeight()
        {
            return this.MaxRows * this.MaxColumns * 150; //30 ton max. container weight, + 120 ton topload weight.
        }
    }
}
