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
    public partial class FrmModFacilTemas : Form
    {
        public FrmModFacilTemas()
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

        private void pcbHome_Click(object sender, EventArgs e)
        {
            FrmModulosdeJuego FMJ = new FrmModulosdeJuego();
            FMJ.Show();
            this.Close();
        }

                  
        private void pnlInicio_MouseHover(object sender, EventArgs e)
        {
            pnlInicio.Size = new Size(62, 62);
        }

        private void pnlInicio_MouseLeave(object sender, EventArgs e)
        {
            pnlInicio.Size = new Size(58, 58);
        }

        private void pnlRegresar_MouseHover(object sender, EventArgs e)
        {
            pnlRegresar.Size = new Size(62, 62);
        }

        private void pnlRegresar_MouseLeave(object sender, EventArgs e)
        {
            pnlRegresar.Size = new Size(58, 58);
        }

        private void lblAnimal_MouseHover(object sender, EventArgs e)
        {
            lblAnimal.ForeColor = Color.Black;
        }

        private void lblAnimal_MouseLeave(object sender, EventArgs e)
        {
            lblAnimal.ForeColor = Color.White;
        }

        private void lblAlimentos_MouseHover(object sender, EventArgs e)
        {
            lblAlimentos.ForeColor = Color.Black;
        }

        private void lblAlimentos_MouseLeave(object sender, EventArgs e)
        {
            lblAlimentos.ForeColor = Color.White;
        }

        private void lblSentidos_MouseHover(object sender, EventArgs e)
        {
            lblSentidos.ForeColor = Color.Black;
        }

        private void lblSentidos_MouseLeave(object sender, EventArgs e)
        {
            lblSentidos.ForeColor = Color.White;
        }

        private void pnlRegresar_Click(object sender, EventArgs e)
        {
            FrmModulosdeJuego objModulo = new FrmModulosdeJuego();
            objModulo.Show();
            this.Visible = false;
        }

        private void pnlInicio_Click(object sender, EventArgs e)
        {
            PantallaPrincipal.FrmInicio objInicio = new PantallaPrincipal.FrmInicio();
            objInicio.Show();
            this.Visible = false;
        }

        private void lblAnimal_Click(object sender, EventArgs e)
        {
            FrmAnimales objAnimales = new FrmAnimales();
            objAnimales.Show();
            this.Visible = false;
        }

        private void lblAlimentos_Click(object sender, EventArgs e)
        {
            FrmAlimentos objAlimentos = new FrmAlimentos();
            objAlimentos.Show();
            this.Visible = false;
        }

        private void lblSentidos_Click(object sender, EventArgs e)
        {
            FrmCuerpoHumano2 objSentidos = new FrmCuerpoHumano2();
            objSentidos.Show();
            this.Visible = false;
        }
    }
}
