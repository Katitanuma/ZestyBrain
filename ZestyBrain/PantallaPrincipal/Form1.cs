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
    public partial class FrmPortada : Form
    {
        public FrmPortada()
        {
            InitializeComponent();
        }
        private void progres()
        {
            pgbBarra.Increment(1);
            if (pgbBarra.Value == pgbBarra.Maximum)
            {
                pcbPlay.Visible = true;
                timer1.Stop();
                pgbBarra.Dispose();
                pcbOpciones.Visible = true;
                pcbSalir.Visible = true;
            }

        }
               
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            progres();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            pcbPlay.Visible = false;
            pcbOpciones.Visible = false;
            pcbSalir.Visible = false;
        }

        private void pcbPlay_Click(object sender, EventArgs e)
        {
            FrmModulosdeJuego objM = new FrmModulosdeJuego();
            objM.Show();
            this.Visible = false;
        }


        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pcbOpciones.Image=ZestyBrain.Properties.Resources.engranaje_mds;
        }

        private void pcbOpciones_MouseLeave(object sender, EventArgs e)
        {
            pcbOpciones.Image = ZestyBrain.Properties.Resources.engranaje_md;
        }

        private void pcbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcbSalir_MouseHover(object sender, EventArgs e)
        {
            pcbSalir.Size=new Size(55,55);
        }

        private void pcbSalir_MouseLeave(object sender, EventArgs e)
        {
            pcbSalir.Size = new Size(50, 50);
        }

        private void pcbOpciones_Click(object sender, EventArgs e)
        {
            FrmOpciones Fo = new FrmOpciones();
            Fo.ShowDialog();
            
        }
    }
}
