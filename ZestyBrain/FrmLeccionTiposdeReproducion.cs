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
    public partial class FrmLeccionTiposdeReproducion : Form
    {
        public FrmLeccionTiposdeReproducion()
        {
            InitializeComponent();
        }

        private void pcbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.ExitThread();
        }

        private void pcbHome_Click(object sender, EventArgs e)
        {
            FrmModAvanTemas FMAT = new FrmModAvanTemas();
            FMAT.Show();
            this.Close();
        }
    }
}
