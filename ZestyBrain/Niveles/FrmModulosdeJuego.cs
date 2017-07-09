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

        private void pcbSalir1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.ExitThread();
        }

        private void pcbSalir1_MouseHover(object sender, EventArgs e)
        {
            pcbSalir1.Size = new Size(47, 47);
        }

        private void pcbSalir1_MouseLeave(object sender, EventArgs e)
        {
            pcbSalir1.Size = new Size(43, 43);
        }

        private void FrmModulosdeJuego_Load(object sender, EventArgs e)
        {
            pctModulo2.Visible = false;
            pnlRegresar.Visible = false;
        }

        private void pctModulo1_MouseHover_1(object sender, EventArgs e)
        {
            pctModulo1.Image = ZestyBrain.Properties.Resources.modojuegofacil1;
        }

        private void pctModulo1_MouseLeave_1(object sender, EventArgs e)
        {
            pctModulo1.Image = ZestyBrain.Properties.Resources.Captura;
        }

        private void pnlSiguiente_MouseHover(object sender, EventArgs e)
        {
            pnlSiguiente.Size = new Size(88, 88);
        }

        private void pnlSiguiente_MouseLeave(object sender, EventArgs e)
        {
            pnlSiguiente.Size = new Size(80, 80);
        }

        private void pnlRegresar_MouseHover(object sender, EventArgs e)
        {
            pnlRegresar.Size = new Size(88, 88);
        }

        private void pnlRegresar_MouseLeave(object sender, EventArgs e)
        {
            pnlRegresar.Size = new Size(80, 80);
            lblNivel.Text = "6 - 9 Años";
        }

        private void pnlSiguiente_Click(object sender, EventArgs e)
        {
            pctModulo1.Visible = false;
            pctModulo2.Visible = true;
            pnlSiguiente.Visible = false;
            pnlRegresar.Visible = true;
            lblNivel.Text = "10 - 12 Años";
        }

        private void pnlRegresar_Click(object sender, EventArgs e)
        {
            pctModulo1.Visible = true;
            pctModulo2.Visible = false;
            pnlSiguiente.Visible = true;
            pnlRegresar.Visible = false;
        }

        private void pctModulo2_MouseHover_1(object sender, EventArgs e)
        {
            pctModulo2.Image = ZestyBrain.Properties.Resources.listomodulo2;
        }

        private void pctModulo2_MouseLeave_1(object sender, EventArgs e)
        {
            pctModulo2.Image = ZestyBrain.Properties.Resources.modulo2;
        }

        private void pctModulo2_Click_1(object sender, EventArgs e)
        {
            FrmModAvanTemas FMA = new FrmModAvanTemas();
            FMA.Show();
            this.Visible=false;
        }

        private void pctModulo1_Click_1(object sender, EventArgs e)
        {
            FrmModFacilTemas FMF = new FrmModFacilTemas();
            FMF.Show();
            this.Visible = false;
        }

        private void pnlInicio_MouseHover(object sender, EventArgs e)
        {
            pnlInicio.Size = new Size(165, 62);
        }

        private void pnlInicio_MouseLeave(object sender, EventArgs e)
        {
            pnlInicio.Size = new Size(160, 57);
        }

        private void pnlInicio_Click(object sender, EventArgs e)
        {
            PantallaPrincipal.FrmInicio Inicio = new PantallaPrincipal.FrmInicio();
            Inicio.Show();
            this.Visible=false;
        }
    }
}
