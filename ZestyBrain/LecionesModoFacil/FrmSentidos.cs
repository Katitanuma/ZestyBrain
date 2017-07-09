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
    public partial class FrmCuerpoHumano2 : Form
    {
        public FrmCuerpoHumano2()
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
            FrmModFacilTemas FMFT = new FrmModFacilTemas();
            FMFT.Show();
            this.Close();
        }

        private void pcbPrueba_Click(object sender, EventArgs e)
        {
            PruebaCuerpoHumano PCH = new PruebaCuerpoHumano();
            PCH.Show();
            this.Close();
        }
    }
}
