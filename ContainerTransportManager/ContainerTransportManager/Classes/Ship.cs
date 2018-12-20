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

    }
}
