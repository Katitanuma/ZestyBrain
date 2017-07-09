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
    public partial class FrmPruebaAnimales : Form
    {
        public FrmPruebaAnimales()
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
            pctSalir.Size = new Size(47, 47);
        }

        private void pctSalir_MouseLeave(object sender, EventArgs e)
        {
            pctSalir.Size = new Size(43, 43);
        }

                    
        private void FrmPruebaAnimales_Load(object sender, EventArgs e)
        {
            pnlRegresar.Visible = false;
            pctHome.Visible = false;
        }

        private void lblVerificar_Click(object sender, EventArgs e)
        {
            pnlRegresar.Visible = true;
            pctHome.Visible = true;
        }

        private void lblVerificar_MouseHover(object sender, EventArgs e)
        {
            pnlVerificar.Size = new Size(170, 57);
        }

        private void lblVerificar_MouseLeave(object sender, EventArgs e)
        {
            pnlVerificar.Size = new Size(165, 52);
        }

        private void pnlRegresar_MouseHover_1(object sender, EventArgs e)
        {
            pnlRegresar.Size = new Size(47, 47);
        }

        private void pnlRegresar_MouseLeave_1(object sender, EventArgs e)
        {
            pnlRegresar.Size = new Size(43, 43);
        }

        private void pnlRegresar_Click_1(object sender, EventArgs e)
        {
            FrmAnimales objAnimales = new FrmAnimales();
            objAnimales.Show();
            this.Visible = false;
        }

        private void pctHome_Click_1(object sender, EventArgs e)
        {
            PantallaPrincipal.FrmInicio objInicio = new PantallaPrincipal.FrmInicio();
            objInicio.Show();
            this.Visible = false;
        }

        private void pctHome_MouseHover_1(object sender, EventArgs e)
        {
            pctHome.Size = new Size(57, 53);
        }

        private void pctHome_MouseLeave_1(object sender, EventArgs e)
        {
            pctHome.Size = new Size(52, 48);
        }
    }
}
