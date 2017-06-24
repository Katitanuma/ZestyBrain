using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ZestyBrain.PantallaPrincipal
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        SoundPlayer player;
        
        private void Sonido()
        {
            try
            {
                if (player == null)
                {
                    player = new SoundPlayer(@"C:\Users\Katy\Pictures\ZestyBrain\ZestyBrain\Resources\chup.wav");
                    player.Play();
                }
                else
                {
                    player.Play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void pnlJugar_MouseHover(object sender, EventArgs e)
        {
            pnlJugar.Size = new Size(365, 145);
            //Sonido();
        }

         private void pnlJugar_MouseLeave_1(object sender, EventArgs e)
        {
            pnlJugar.Size = new Size(336, 129);           
        }

        private void pnlJugar_Click(object sender, EventArgs e)
        {
            FrmModulosdeJuego objM = new FrmModulosdeJuego();
            objM.Show();
            this.Visible = false;
        }

        private void ptbSalirB_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.ExitThread();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            pctAnimal.Image= ZestyBrain.Properties.Resources.tigre;
            pctVenado.Image = ZestyBrain.Properties.Resources.deer4;
        }

        private void pnlConf_MouseHover(object sender, EventArgs e)
        {
            pnlConf.Size = new Size(190, 70);
            //Sonido();
        }

        private void pnlConf_MouseLeave(object sender, EventArgs e)
        {
            pnlConf.Size = new Size(180, 60);
        }

        private void pctSalirB_MouseHover(object sender, EventArgs e)
        {
            pctSalirB.Size = new Size(48, 48);
            //Sonido();
        }

        private void pctSalirB_MouseLeave(object sender, EventArgs e)
        {
            pctSalirB.Size = new Size(43, 43);
        }
    }
}
