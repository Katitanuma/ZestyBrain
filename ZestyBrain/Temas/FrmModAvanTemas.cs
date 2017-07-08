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
    public partial class FrmModAvanTemas : Form
    {
        public FrmModAvanTemas()
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

        private void pnlInicio_Click(object sender, EventArgs e)
        {
            PantallaPrincipal.FrmInicio objInicio = new PantallaPrincipal.FrmInicio();
            objInicio.Show();
            this.Visible = false;
        }

        private void pnlRegresar_Click(object sender, EventArgs e)
        {
            FrmModulosdeJuego objModulo = new FrmModulosdeJuego();
            objModulo.Show();
            this.Visible = false;
        }

        private void pnlInicio_MouseHover(object sender, EventArgs e)
        {
            pnlInicio.Size = new Size(55, 56);
        }

        private void pnlInicio_MouseLeave(object sender, EventArgs e)
        {
            pnlInicio.Size = new Size(51, 50);
        }

        private void pnlRegresar_MouseHover(object sender, EventArgs e)
        {
            pnlRegresar.Size = new Size(47, 47);
        }

        private void pnlRegresar_MouseLeave(object sender, EventArgs e)
        {
            pnlRegresar.Size = new Size(43, 43);
        }

        private void btnTipoR_MouseHover(object sender, EventArgs e)
        {
            lblTipoR.ForeColor = Color.Blue;
        }

        private void btnTipoR_MouseLeave(object sender, EventArgs e)
        {
            lblTipoR.ForeColor = Color.Black;
        }

        private void btnContA_MouseHover(object sender, EventArgs e)
        {
            lblConta.ForeColor = Color.Blue;
        }

        private void btnContA_MouseLeave(object sender, EventArgs e)
        {
            lblConta.ForeColor = Color.Black;
        }

        private void btnReino_MouseHover(object sender, EventArgs e)
        {
            lblReino.ForeColor = Color.Blue;
        }

        private void btnReino_MouseLeave(object sender, EventArgs e)
        {
            lblReino.ForeColor = Color.Black;
        }
    }
}
