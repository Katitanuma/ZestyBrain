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
    public partial class FrmModulosdeJuego : Form
    {
        public FrmModulosdeJuego()
        {
            InitializeComponent();
        }

        private void pctModulo2_MouseHover(object sender, EventArgs e)
        {
            pctModulo2.Image = ZestyBrain.Properties.Resources.listomodulo2;
        }

        private void pctModulo2_MouseLeave(object sender, EventArgs e)
        {
            pctModulo2.Image = ZestyBrain.Properties.Resources.modulo2;
        }

        private void pctModulo1_MouseLeave(object sender, EventArgs e)
        {
            pctModulo1.Image = ZestyBrain.Properties.Resources.Captura;
        }

        private void pctModulo1_MouseHover(object sender, EventArgs e)
        {
            pctModulo1.Image = ZestyBrain.Properties.Resources.modojuegofacil1;
        }

        private void pcbSalir1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.ExitThread();
        }

        private void pcbSalir1_MouseHover(object sender, EventArgs e)
        {
            pcbSalir1.Size = new Size(55, 55);
        }

        private void pcbSalir1_MouseLeave(object sender, EventArgs e)
        {
            pcbSalir1.Size = new Size(50, 50);
        }

        private void pctModulo1_Click(object sender, EventArgs e)
        {
            FrmModFacilTemas FMF = new FrmModFacilTemas();
            FMF.Show();
            this.Close();
        }

        private void pctModulo2_Click(object sender, EventArgs e)
        {
            FrmModAvanTemas FMA = new FrmModAvanTemas();
            FMA.Show();
            this.Close();
        }
    }
}
