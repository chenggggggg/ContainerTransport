using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerTransportManager.Classes
{
    public enum ContainerType
    {
        Cooled,
        Regular,
        Valuable
    }
    public class Container
    {

        public int ContainerId { get; set; }
        public int Weight { get; set; } = 4000;
        public ContainerType Type { get; set; } = ContainerType.Regular;
        public int PilePosition { get; set; }

        public Container(int containerid, int weight, ContainerType type, int pileposition)
        {
            ContainerId = containerid;
            Weight = weight;
            Type = type;
            PilePosition = pileposition;
        }
    }
}
