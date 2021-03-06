﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerTransportManager.Classes
{
    public class ContainerPile
    {
        public int PileId { get; set; }
        public ShipSide Side { get; set; }
        public int Column { get; set; }
        public int Row { get; set; }
        public List<Container> Containers { get; set; }

        public ContainerPile(int pileid, int column, int row, ShipSide side)
        {
            PileId = pileid;
            Column = column;
            Row = row;
            Side = side;
            Containers = new List<Container>();
        }

        public int GetTopLoadWeight()
        {
            int totalWeight = 0;
            for (int i = 1; i < Containers.Count; i++)
            {
                totalWeight = totalWeight + this.Containers[i].Weight;
            }
            return totalWeight;
        }
        /// <summary>
        /// Gets the topload weight starting from the given height.
        /// </summary>
        /// <param name="topload"></param>
        /// <returns></returns>
        public int GetTopLoadWeight(int height)
        {
            int totalWeight = 0;
            for (int i = height; i < Containers.Count - height; i++)
            {
                totalWeight = totalWeight + this.Containers[i].Weight;
            }
            return totalWeight;
        }
    }
}
