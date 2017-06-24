﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZestyBrain
{
    public partial class FrmOpciones : Form
    {
        public FrmOpciones()
        {
            InitializeComponent();
        }

        private void pcbSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pcbSalir_MouseHover(object sender, EventArgs e)
        {
            pcbSalir.Size = new Size(55, 55);
        }

        private void pcbSalir_MouseLeave(object sender, EventArgs e)
        {
            pcbSalir.Size = new Size(50, 50);
        }
    }
}