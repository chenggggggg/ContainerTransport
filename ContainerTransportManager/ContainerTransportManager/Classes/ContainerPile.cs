using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerTransportManager.Classes
{
    public enum ShipSide
    {
        Left = 0,
        Right = 1,
        Middle = 2
    }
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
        }
    }
}
