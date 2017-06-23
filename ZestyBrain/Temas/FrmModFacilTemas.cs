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
            pcbSalir.Size = new Size(55, 55);
        }

        private void pcbSalir_MouseLeave(object sender, EventArgs e)
        {
            pcbSalir.Size = new Size(50, 50);
        }

        private void pcbHome_Click(object sender, EventArgs e)
        {
            FrmModulosdeJuego FMJ = new FrmModulosdeJuego();
            FMJ.Show();
            this.Close();
        }

        private void pcbHome_MouseHover(object sender, EventArgs e)
        {
            pcbHome.Size = new Size(55, 55);
            lblRegresar.Visible = true;
            lblModulo.Visible = true;
        }

        private void pcbHome_MouseLeave(object sender, EventArgs e)
        {
            pcbHome.Size = new Size(50, 50);
            lblRegresar.Visible = false;
            lblModulo.Visible = false;
        }
      
        private void FrmModFacilTemas_Load(object sender, EventArgs e)
        {
            btnBI1.Focus();
                      
        }

        private void btnBI1_Click(object sender, EventArgs e)
        {
            FrmAnimales FA = new FrmAnimales();
            FA.Show();
            this.Close();
        }

        private void btnBI2_Click(object sender, EventArgs e)
        {
            FrmClasificaciónAlimentos FCLA = new FrmClasificaciónAlimentos();
            FCLA.Show();
            this.Close();
        }

        private void btnBI3_Click(object sender, EventArgs e)
        {
            FrmCuerpoHumano2 FCH = new FrmCuerpoHumano2();
            FCH.Show();
            this.Close();
        }

        private void btnBI1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Down)
            {
                btnBI2.Focus();
               
            }
        }

        private void btnBI2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                btnBI3.Focus();
                
            }
        }

        private void btnBI3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                btnBI1.Focus();
                
            }
        }
    }
}
