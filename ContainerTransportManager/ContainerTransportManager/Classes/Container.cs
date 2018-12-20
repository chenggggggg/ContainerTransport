using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerTransportManager.Classes
{
    public class Container
    {
        public enum ContainerType
        {
            Regular,
            Valuable,
            Cooled,
        }
        public int ContainerId { get; set; }
        public double Weight { get; set; } = 4000;
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
