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
            pcbSalir.Size = new Size(55, 55);
        }

        private void pcbSalir_MouseLeave(object sender, EventArgs e)
        {
            pcbSalir.Size = new Size(50, 50);
        }

        private void pcbHome_Click(object sender, EventArgs e)
        {
            FrmModFacilTemas FMF = new FrmModFacilTemas();
            FMF.Show();
            this.Close();
        }

        private void pcbHome_MouseHover(object sender, EventArgs e)
        {
            pcbHome.Size = new Size(55, 55);
        }

        private void pcbHome_MouseLeave(object sender, EventArgs e)
        {   
            pcbHome.Size = new Size(50, 50);
        }

        private void pcbPrueba_MouseHover(object sender, EventArgs e)
        {
            pcbPrueba.Size = new Size(55, 55);
        }

        private void pcbPrueba_MouseLeave(object sender, EventArgs e)
        {
            pcbPrueba.Size = new Size(50, 50);
        }

        private void pcbPrueba_Click(object sender, EventArgs e)
        {
            FrmPruebaAnimales FPA = new FrmPruebaAnimales();
            FPA.Show();
            this.Close();
        }
    }
}
