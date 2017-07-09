using System;
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
    public partial class FrmLeccionTiposdeReproducion : Form
    {
        public FrmLeccionTiposdeReproducion()
        {
            InitializeComponent();
        }

        private void pcbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.ExitThread();
        }

        private void pcbHome_Click(object sender, EventArgs e)
        {
            PantallaPrincipal.FrmInicio FMAT = new PantallaPrincipal.FrmInicio();
            FMAT.Show();
            this.Visible=false;
        }

        private void pcbSalir_MouseHover(object sender, EventArgs e)
        {
            pcbSalir.Size = new Size(47,47);
        }

        private void pcbSalir_MouseLeave(object sender, EventArgs e)
        {
            pcbSalir.Size = new Size(43,43);
        }

        private void pcbHome_MouseLeave(object sender, EventArgs e)
        {
            pcbHome.Size = new Size(52, 55);
        }

        private void pcbHome_MouseHover(object sender, EventArgs e)
        {
            pcbHome.Size = new Size(57, 60);
        }

        private void lblAtras_Click(object sender, EventArgs e)
        {
            FrmModAvanTemas objModAvan = new FrmModAvanTemas();
            objModAvan.Show();
            this.Visible = false;
        }

        private void lblSiguiente_Click(object sender, EventArgs e)
        {
            FrmContaminacionAmbiental objModAvan = new FrmContaminacionAmbiental();
            objModAvan.Show();
            this.Visible = false;
        }

        private void lblAtras_MouseLeave(object sender, EventArgs e)
        {
            pnlAtras.Size = new Size(142, 47);
        }

        private void lblAtras_MouseHover(object sender, EventArgs e)
        {
            pnlAtras.Size = new Size(147, 52);
        }

        private void lblSiguiente_MouseLeave(object sender, EventArgs e)
        {
            pnlSiguiente.Size = new Size(142, 47);
        }

        private void lblSiguiente_MouseHover(object sender, EventArgs e)
        {
            pnlSiguiente.Size = new Size(147, 52);
        }
    }
}
