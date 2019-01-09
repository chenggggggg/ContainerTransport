using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContainerTransportManager.Classes;

namespace ContainerTransportManager
{
    public partial class ShipResultForm : Form
    {
        Ship ResultShip = new Ship();
        public ShipResultForm(Ship createdShip, List<Classes.Container> allcontainers)
        {
            InitializeComponent();
            createdShip.SortAllContainersInShip(allcontainers);
            ResultShip = createdShip;
        }

        private void ShipResultForm_Load(object sender, EventArgs e)
        {
            //id, column, row, height
            foreach (ContainerPile pile in ResultShip.ContainerPiles)
            {
                for (int i = 0; i < pile.Containers.Count; i++)
                {
                    string[] row =
                        { pile.Containers[i].ContainerId.ToString(),
                        pile.Column.ToString(), pile.Row.ToString(),
                        i.ToString(),
                        pile.Containers[i].Type.ToString(),
                        pile.GetTopLoadWeight(0).ToString(),
                        pile.Side.ToString()
                    };
                    var shipListViewRow = new ListViewItem(row);
                    ShipListView.Items.Add(shipListViewRow);
                }
            }
        }
    }
}
