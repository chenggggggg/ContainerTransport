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
    public partial class ContainerManagerForm : Form
    {
        Ship CustomShip = new Ship();
        int TotalShipWeight;
        int MaxShipWeight = 0;

        public ContainerManagerForm(Ship createdship)
        {
            InitializeComponent();
            this.CustomShip = createdship;
            AddedContainersListBox.DisplayMember = "Type";
            MaxShipWeight = CustomShip.GetMaxShipWeight();
            MaxWeightTextBox.Text = MaxShipWeight.ToString();
        }

        private void AddContainerButton_Click(object sender, EventArgs e)
        {
            int containerId = AddedContainersListBox.Items.Count;
            ContainerType containerType = ContainerType.Regular;
            if (RegularRadioButton.Checked)
            {
                containerType = ContainerType.Regular;
            }
            else if (CooledRadioButton.Checked)
            {
                containerType = ContainerType.Cooled;
            }
            else if (ValuableRadioButton.Checked)
            {
                containerType = ContainerType.Valuable;
            }

            Classes.Container newContainer = new Classes.Container(containerId, (int)WeightNumUpDown.Value, containerType);
            AddedContainersListBox.Items.Add(newContainer);
            TotalShipWeight = TotalShipWeight + (int)WeightNumUpDown.Value;
            if (TotalShipWeight >= MaxShipWeight / 2 && TotalShipWeight <= MaxShipWeight)
            {
                CreateShipButton.Enabled = true;
            }
            else
            {
                if (TotalShipWeight == MaxShipWeight)
                {
                    AddContainerButton.Enabled = false;
                }
                CreateShipButton.Enabled = false;
            }
            CurrentWeightTextBox.Text = TotalShipWeight.ToString();
        }

        private void CreateShipButton_Click(object sender, EventArgs e)
        {
            List<Classes.Container> addedContainers = new List<Classes.Container>();

            for (int i = 0; i < AddedContainersListBox.Items.Count; i++)
            {
                addedContainers.Add((Classes.Container)AddedContainersListBox.Items[i]);
            }

            ShipResultForm resultForm = new ShipResultForm(this.CustomShip, addedContainers);
            resultForm.ShowDialog();
        }
    }
}
