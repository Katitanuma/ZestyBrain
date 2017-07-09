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
    public partial class FrmContaminacionAmbiental : Form
    {
        public FrmContaminacionAmbiental()
        {
            InitializeComponent();
        }

        private void pcbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.ExitThread();
        }

        private void pcbSalir_MouseHover(object sender, EventArgs e)
        {
            pcbSalir.Size = new Size(47, 47);
        }

        private void pcbSalir_MouseLeave(object sender, EventArgs e)
        {
            pcbSalir.Size = new Size(43, 43);
        }

        private void pctHome_Click(object sender, EventArgs e)
        {
            PantallaPrincipal.FrmInicio objInicio = new PantallaPrincipal.FrmInicio();
            objInicio.Show();
            this.Visible = false;
        }

        private void pctHome_MouseLeave(object sender, EventArgs e)
        {
            pctHome.Size = new Size(53, 57);
        }

        private void pctHome_MouseHover(object sender, EventArgs e)
        {
            pctHome.Size = new Size(58, 62);
        }

        private void lblSiguiente_Click(object sender, EventArgs e)
        {
            FrmClasificaciondelosReinos objReino = new FrmClasificaciondelosReinos();
            objReino.Show();
            this.Visible = false;
        }

        private void lblSiguiente_MouseLeave(object sender, EventArgs e)
        {
            pnlSiguiente.Size = new Size(142, 47);
        }

        private void lblSiguiente_MouseHover(object sender, EventArgs e)
        {
            pnlSiguiente.Size = new Size(147, 52);
        }

        private void lblAtras_Click(object sender, EventArgs e)
        {
            FrmLeccionTiposdeReproducion objRepro = new FrmLeccionTiposdeReproducion();
            objRepro.Show();
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
    }
}
