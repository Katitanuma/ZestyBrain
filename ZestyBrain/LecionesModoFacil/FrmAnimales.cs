using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace ZestyBrain
{
    public partial class FrmAnimales : Form
    {
        public FrmAnimales()
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
            pcbSalir.Size = new Size(48, 48);
        }

        private void pcbSalir_MouseLeave(object sender, EventArgs e)
        {
            pcbSalir.Size = new Size(43, 43);
        }

        private void pcbHome_Click(object sender, EventArgs e)
        {
            PantallaPrincipal.FrmInicio objInicio = new PantallaPrincipal.FrmInicio();
            objInicio.Show();
            this.Visible=false;
        }

        private void pcbHome_MouseHover(object sender, EventArgs e)
        {
            pcbHome.Size = new Size(58, 62);
        }

        private void pcbHome_MouseLeave(object sender, EventArgs e)
        {   
            pcbHome.Size = new Size(53, 57);
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
            FrmModFacilTemas objModoFa = new FrmModFacilTemas();
            objModoFa.Show();
            this.Visible=false;
        }

        private void lblPrueba_Click(object sender, EventArgs e)
        {

        }

        private void lblPrueba_MouseHover(object sender, EventArgs e)
        {
            pnlPrueba.Size = new Size(107, 92);
        }

        private void lblPrueba_MouseLeave(object sender, EventArgs e)
        {
            pnlPrueba.Size = new Size(102, 87);
        }
    }
}
