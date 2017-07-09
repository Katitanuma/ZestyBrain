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
    public partial class FrmAlimentos : Form
    {
        public FrmAlimentos()
        {
            InitializeComponent();
        }

        private void pctSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.ExitThread();
        }

        private void pctSalir_MouseHover(object sender, EventArgs e)
        {
            pctSalir.Size = new Size(48, 48);
        }

        private void pctSalir_MouseLeave(object sender, EventArgs e)
        {
            pctSalir.Size = new Size(43, 43);
        }

        private void pctHome_MouseHover(object sender, EventArgs e)
        {
            pctHome.Size = new Size(58, 62);
        }

        private void pctHome_MouseLeave(object sender, EventArgs e)
        {
            pctHome.Size = new Size(53, 57);
        }

        private void pctHome_Click(object sender, EventArgs e)
        {
            PantallaPrincipal.FrmInicio objInicio = new PantallaPrincipal.FrmInicio();
            objInicio.Show();
            this.Visible = false;
        }

        private void lblPrueba_Click(object sender, EventArgs e)
        {
            FrmPruebaClasificacion objAlimentosPrueba = new FrmPruebaClasificacion();
            objAlimentosPrueba.Show();
            this.Visible = false;
        }

        private void lblPrueba_MouseHover(object sender, EventArgs e)
        {
            pnlPrueba.Size = new Size(107, 92);
        }

        private void lblPrueba_MouseLeave(object sender, EventArgs e)
        {
            pnlPrueba.Size = new Size(102, 87);
        }

        private void pnlRegresar_MouseHover(object sender, EventArgs e)
        {
            pnlRegresar.Size = new Size(47, 47);
        }

        private void pnlRegresar_MouseLeave(object sender, EventArgs e)
        {
            pnlRegresar.Size = new Size(43, 43);
        }

        private void pnlRegresar_Click(object sender, EventArgs e)
        {
            FrmModFacilTemas objModFacil = new FrmModFacilTemas();
            objModFacil.Show();
            this.Visible = false;
        }
    }
}
