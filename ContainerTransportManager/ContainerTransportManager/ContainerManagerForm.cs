﻿using System;
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
        public ContainerManagerForm(Ship createdship)
        {
            InitializeComponent();
            this.CustomShip = createdship;
        }

    }
}
