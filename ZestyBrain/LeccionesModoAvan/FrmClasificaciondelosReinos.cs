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
    public partial class FrmClasificaciondelosReinos : Form
    {
        public FrmClasificaciondelosReinos()
        {
            InitializeComponent();
        }

        private void pctHome_Click(object sender, EventArgs e)
        {

        }

        private void pctHome_MouseHover(object sender, EventArgs e)
        {

        }

        private void pctHome_Click_1(object sender, EventArgs e)
        {
            PantallaPrincipal.FrmInicio objInicio = new PantallaPrincipal.FrmInicio();
            objInicio.Show();
            this.Visible=false;
        }

        private void pctHome_MouseLeave(object sender, EventArgs e)
        {
            pctHome.Size = new Size(53,50);
        }

        private void pctHome_MouseHover_1(object sender, EventArgs e)
        {
            pctHome.Size = new Size(58, 55);
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

        private void lblAtras_Click(object sender, EventArgs e)
        {
            FrmContaminacionAmbiental objConta = new FrmContaminacionAmbiental();
            objConta.Show();
            this.Visible = false;
        }

        private void lblAtras_MouseHover(object sender, EventArgs e)
        {
            pnlAtras.Size = new Size(102, 52);
        }

        private void lblAtras_MouseLeave(object sender, EventArgs e)
        {
            pnlAtras.Size = new Size(97, 47);
        }

        private void lblSiguiente_Click(object sender, EventArgs e)
        {

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
