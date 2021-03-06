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
    public partial class FrmPortada : Form
    {
        public FrmPortada()
        {
            InitializeComponent();
        }

        private void progres()
        {
            pgbBarra.Increment(1);
            if (pgbBarra.Value == pgbBarra.Maximum)
            {
                timer1.Stop();
                pgbBarra.Dispose();
                pnlBorde.Dispose();
                PantallaPrincipal.FrmInicio objInicio = new PantallaPrincipal.FrmInicio();
                objInicio.Show();
                this.Visible = false;
            }

        }
               
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            progres();
        }       
    }
}
