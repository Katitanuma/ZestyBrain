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
    public partial class PruebaCuerpoHumano : Form
    {
        public PruebaCuerpoHumano()
        {
            InitializeComponent();
        }

        private void lblVerificar_Click(object sender, EventArgs e)
        {
            pnlRegresar.Visible = true;
            pctHome.Visible = true;
            if(p1.BackgroundImage == pi1.BackgroundImage)
            {
                r1.Visible = true;
            }
            if (p2.BackgroundImage == pi2.BackgroundImage)
            {
                r2.Visible = true;
            }
            if (p3.BackgroundImage == pi3.BackgroundImage)
            {
                r3.Visible = true;
            }
            if (p4.BackgroundImage == pi4.BackgroundImage)
            {
                r4.Visible = true;
            }
            if (p5.BackgroundImage == pi5.BackgroundImage)
            {
                r5.Visible = true;
            }

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

        private void pctHome_Click(object sender, EventArgs e)
        {
            PantallaPrincipal.FrmInicio objInicio = new PantallaPrincipal.FrmInicio();
            objInicio.Show();
            this.Visible = false;
        }

        private void pctHome_MouseLeave(object sender, EventArgs e)
        {
            pctHome.Size = new Size(52, 48);
        }

        private void pctHome_MouseHover(object sender, EventArgs e)
        {
            pctHome.Size = new Size(57, 53);
        }

        private void pnlRegresar_Click(object sender, EventArgs e)
        {
            FrmCuerpoHumano2 objSentidos = new FrmCuerpoHumano2();
            objSentidos.Show();
            this.Visible = false;
        }

        private void pnlRegresar_MouseHover(object sender, EventArgs e)
        {
            pnlRegresar.Size = new Size(47, 47);
        }

        private void pnlRegresar_MouseLeave(object sender, EventArgs e)
        {
            pnlRegresar.Size = new Size(43, 43);
        }

        private void lblVerificar_MouseHover(object sender, EventArgs e)
        {
            pnlVerificar.Size = new Size(170, 57);
        }

        private void lblVerificar_MouseLeave(object sender, EventArgs e)
        {
            pnlVerificar.Size = new Size(165, 52);
        }

        private void PruebaCuerpoHumano_Load(object sender, EventArgs e)
        {
            pnlRegresar.Visible = false;
            pctHome.Visible = false;
            p1.AllowDrop = true;
            p2.AllowDrop = true;
            p3.AllowDrop = true;
            p4.AllowDrop = true;
            p5.AllowDrop = true;
           
        }

        private void pi2_MouseDown(object sender, MouseEventArgs e)
        {
            if (pi2.BackgroundImage != null)
            {

                pi2.DoDragDrop(pi2.BackgroundImage, DragDropEffects.Copy);


            }
        }

        private void pi5_MouseDown(object sender, MouseEventArgs e)
        {
            if (pi5.BackgroundImage != null)
            {

                pi5.DoDragDrop(pi5.BackgroundImage, DragDropEffects.Copy);


            }
        }

        private void pi1_MouseDown(object sender, MouseEventArgs e)
        {
            if (pi1.BackgroundImage != null)
            {

                pi1.DoDragDrop(pi1.BackgroundImage, DragDropEffects.Copy);


            }
        }

        private void pi4_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pi3_MouseDown(object sender, MouseEventArgs e)
        {
            if (pi3.BackgroundImage != null)
            {

                pi3.DoDragDrop(pi3.BackgroundImage, DragDropEffects.Copy);


            }
        }

        private void pi4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void p1_DragDrop(object sender, DragEventArgs e)
        {
            if (p1.BackgroundImage == null)
            {
                p1.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);

                Image a = p1.BackgroundImage;


                if (a == pi1.BackgroundImage)
                {
                    pi1.Visible = false;
                }
                else if (a == pi2.BackgroundImage)
                {
                    pi2.Visible = false;
                }
                else if (a == pi3.BackgroundImage)
                {
                    pi3.Visible = false;
                }
                else if (a == pi4.BackgroundImage)
                {
                    pi4.Visible = false;
                }
                else if (a == pi5.BackgroundImage)
                {
                    pi5.Visible = false;
                }
            }

        }

        private void p2_DragDrop(object sender, DragEventArgs e)
        {
            if (p2.BackgroundImage == null)
            {
                p2.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);

                Image a = p2.BackgroundImage;

                if (a == pi1.BackgroundImage)
                {
                    pi1.Visible = false;
                }
                else if (a == pi2.BackgroundImage)
                {
                    pi2.Visible = false;
                }
                else if (a == pi3.BackgroundImage)
                {
                    pi3.Visible = false;
                }
                else if (a == pi4.BackgroundImage)
                {
                    pi4.Visible = false;
                }
                else if (a == pi5.BackgroundImage)
                {
                    pi5.Visible = false;
                }
            }
        }

        private void p3_DragDrop(object sender, DragEventArgs e)
        {
            if (p3.BackgroundImage == null)
            {
                p3.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);

                Image a = p3.BackgroundImage;

                if (a == pi1.BackgroundImage)
                {
                    pi1.Visible = false;
                }
                else if (a == pi2.BackgroundImage)
                {
                    pi2.Visible = false;
                }
                else if (a == pi3.BackgroundImage)
                {
                    pi3.Visible = false;
                }
                else if (a == pi4.BackgroundImage)
                {
                    pi4.Visible = false;
                }
                else if (a == pi5.BackgroundImage)
                {
                    pi5.Visible = false;
                }
            }
        }

        private void p4_DragDrop(object sender, DragEventArgs e)
        {
            if (p4.BackgroundImage == null)
            {
                p4.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);

                Image a = p4.BackgroundImage;

                if (a == pi1.BackgroundImage)
                {
                    pi1.Visible = false;
                }
                else if (a == pi2.BackgroundImage)
                {
                    pi2.Visible = false;
                }
                else if (a == pi3.BackgroundImage)
                {
                    pi3.Visible = false;
                }
                else if (a == pi4.BackgroundImage)
                {
                    pi4.Visible = false;
                }
                else if (a == pi5.BackgroundImage)
                {
                    pi5.Visible = false;
                }
            }
        }

        private void p5_DragDrop(object sender, DragEventArgs e)
        {
            if (p5.BackgroundImage == null)
            {
                p5.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);

                Image a = p5.BackgroundImage;


                if (a == pi1.BackgroundImage)
                {
                    pi1.Visible = false;
                }
                else if (a == pi2.BackgroundImage)
                {
                    pi2.Visible = false;
                }
                else if (a == pi3.BackgroundImage)
                {
                    pi3.Visible = false;
                }
                else if (a == pi4.BackgroundImage)
                {
                    pi4.Visible = false;
                }
                else if (a == pi5.BackgroundImage)
                {
                    pi5.Visible = false;
                }
            }
        }

        private void p2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void p3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void p4_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void p5_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void p1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pi4_MouseDown(object sender, MouseEventArgs e)
        {
            if (pi4.BackgroundImage != null)
            {

                pi4.DoDragDrop(pi4.BackgroundImage, DragDropEffects.Copy);


            }
        }
    }
}
