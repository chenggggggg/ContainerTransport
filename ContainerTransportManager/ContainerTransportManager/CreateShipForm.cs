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
    public partial class CreateShipForm : Form
    {
        public CreateShipForm()
        {
            InitializeComponent();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            int columns = (int)ColumnNumUpDown.Value;
            int rows = (int)RowNumUpDown.Value;
            Ship NewShip = new Ship(columns, rows);
            ContainerManagerForm containerForm = new ContainerManagerForm(NewShip);
            containerForm.ShowDialog();
            this.Close();
        }
    }
}
