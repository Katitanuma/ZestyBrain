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
    public partial class FrmPruebaClasificacion : Form
    {
        public FrmPruebaClasificacion()
        {
            InitializeComponent();
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

        private void pnlRegresar_MouseHover(object sender, EventArgs e)
        {
            pnlRegresar.Size = new Size(60, 48);
        }

        private void pnlRegresar_MouseLeave(object sender, EventArgs e)
        {
            pnlRegresar.Size = new Size(55, 43);
        }

        private void pnlRegresar_Click(object sender, EventArgs e)
        {
            FrmAlimentos objAlimentos = new FrmAlimentos();
            objAlimentos.Show();
            this.Visible = false;
        }

        private void pctHome_MouseHover(object sender, EventArgs e)
        {
            pctHome.Size = new Size(64, 63);
        }

        private void pctHome_MouseLeave(object sender, EventArgs e)
        {
            pctHome.Size = new Size(59, 58);
        }

        private void pctHome_Click(object sender, EventArgs e)
        {
            PantallaPrincipal.FrmInicio objInicio = new PantallaPrincipal.FrmInicio();
            objInicio.Show();
            this.Visible = false;
        }

        private void lblVerificar_MouseLeave(object sender, EventArgs e)
        {
            pnlVerificar.Size = new Size(165, 52);
        }

        private void lblVerificar_MouseHover(object sender, EventArgs e)
        {
            pnlVerificar.Size = new Size(170, 57);
        }

        private void lblVerificar_Click(object sender, EventArgs e)
        {
            pnlRegresar.Visible = true;
            pctHome.Visible = true;

            Image a = pictureBox2.BackgroundImage;
            if (a == pct2.BackgroundImage || a == pct4.BackgroundImage || a == pct5.BackgroundImage || a == pct8.BackgroundImage)
            {
                pictureBox9.BackgroundImage = Properties.Resources.yes_check_mark_png_21;

            }
            else
            {
                pictureBox9.BackgroundImage = Properties.Resources.errorbutton;
            }
            a = pictureBox1.BackgroundImage;
            if (a == pct2.BackgroundImage || a == pct4.BackgroundImage || a == pct5.BackgroundImage || a == pct8.BackgroundImage)
            {
                pictureBox10.BackgroundImage = Properties.Resources.yes_check_mark_png_21;

            }
            else
            {
                pictureBox10.BackgroundImage = Properties.Resources.errorbutton;
            }

            a = pictureBox3.BackgroundImage;
            if (a == pct2.BackgroundImage || a == pct4.BackgroundImage || a == pct5.BackgroundImage || a == pct8.BackgroundImage)
            {
                pictureBox11.BackgroundImage = Properties.Resources.yes_check_mark_png_21;

            }
            else
            {
                pictureBox11.BackgroundImage = Properties.Resources.errorbutton;
            }

            a = pictureBox4.BackgroundImage;
            if (a == pct2.BackgroundImage || a == pct4.BackgroundImage || a == pct5.BackgroundImage || a == pct8.BackgroundImage)
            {
                pictureBox12.BackgroundImage = Properties.Resources.yes_check_mark_png_21;

            }
            else
            {
                pictureBox12.BackgroundImage = Properties.Resources.errorbutton;
            }



            a = pictureBox8.BackgroundImage;
            if (a == pct1.BackgroundImage || a == pct3.BackgroundImage || a == pct6.BackgroundImage || a == pct7.BackgroundImage)
            {
                pictureBox16.BackgroundImage = Properties.Resources.yes_check_mark_png_21;

            }
            else
            {
                pictureBox16.BackgroundImage = Properties.Resources.errorbutton;
            }

            a = pictureBox7.BackgroundImage;
            if (a == pct1.BackgroundImage || a == pct3.BackgroundImage || a == pct6.BackgroundImage || a == pct7.BackgroundImage)
            {
                pictureBox15.BackgroundImage = Properties.Resources.yes_check_mark_png_21;

            }
            else
            {
                pictureBox15.BackgroundImage = Properties.Resources.errorbutton;
            }

            a = pictureBox5.BackgroundImage;
            if (a == pct1.BackgroundImage || a == pct3.BackgroundImage || a == pct6.BackgroundImage || a == pct7.BackgroundImage)
            {
                pictureBox13.BackgroundImage = Properties.Resources.yes_check_mark_png_21;

            }
            else
            {
                pictureBox13.BackgroundImage = Properties.Resources.errorbutton;
            }

            a = pictureBox6.BackgroundImage;
            if (a == pct1.BackgroundImage || a == pct3.BackgroundImage || a == pct6.BackgroundImage || a == pct7.BackgroundImage)
            {
                pictureBox14.BackgroundImage = Properties.Resources.yes_check_mark_png_21;

            }
            else
            {
                pictureBox14.BackgroundImage = Properties.Resources.errorbutton;
            }
        }

        private void FrmPruebaClasificacion_Load(object sender, EventArgs e)
        {
            pnlRegresar.Visible = false;
            pctHome.Visible = false;
            pictureBox1.AllowDrop = true;
            pictureBox2.AllowDrop = true;
            pictureBox3.AllowDrop = true;
            pictureBox4.AllowDrop = true;
            pictureBox5.AllowDrop = true;
            pictureBox6.AllowDrop = true;
            pictureBox7.AllowDrop = true;
            pictureBox8.AllowDrop = true;
        }

        private void pct1_MouseDown(object sender, MouseEventArgs e)
        {
            if (pct1.BackgroundImage != null)
            {

                pct1.DoDragDrop(pct1.BackgroundImage, DragDropEffects.Copy);


            }
        }

        private void pct2_MouseDown(object sender, MouseEventArgs e)
        {
            if (pct2.BackgroundImage != null)
            {

                pct2.DoDragDrop(pct2.BackgroundImage, DragDropEffects.Copy);


            }
        }

        private void pct3_MouseDown(object sender, MouseEventArgs e)
        {
            if (pct3.BackgroundImage != null)
            {

                pct3.DoDragDrop(pct3.BackgroundImage, DragDropEffects.Copy);


            }
        }

        private void pct4_MouseDown(object sender, MouseEventArgs e)
        {
            if (pct4.BackgroundImage != null)
            {

                pct4.DoDragDrop(pct4.BackgroundImage, DragDropEffects.Copy);


            }
        }

        private void pct5_MouseDown(object sender, MouseEventArgs e)
        {
            if (pct5.BackgroundImage != null)
            {

                pct5.DoDragDrop(pct5.BackgroundImage, DragDropEffects.Copy);


            }
        }

        private void pct6_MouseDown(object sender, MouseEventArgs e)
        {
            if (pct6.BackgroundImage != null)
            {

                pct6.DoDragDrop(pct6.BackgroundImage, DragDropEffects.Copy);


            }
        }

        private void pct7_MouseDown(object sender, MouseEventArgs e)
        {
            if (pct7.BackgroundImage != null)
            {

                pct7.DoDragDrop(pct7.BackgroundImage, DragDropEffects.Copy);


            }
        }

        private void pct8_MouseDown(object sender, MouseEventArgs e)
        {
            if (pct8.BackgroundImage != null)
            {

                pct8.DoDragDrop(pct8.BackgroundImage, DragDropEffects.Copy);


            }
        }

        private void pictureBox2_DragDrop(object sender, DragEventArgs e)
        {
            if (pictureBox2.BackgroundImage == null)
            {
                pictureBox2.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);

                Image a = pictureBox2.BackgroundImage;

                if (a == pct1.BackgroundImage)
                {
                    pct1.Visible = false;
                }
                else if (a == pct2.BackgroundImage)
                {
                    pct2.Visible = false;
                }
                else if (a == pct3.BackgroundImage)
                {
                    pct3.Visible = false;
                }
                else if (a == pct4.BackgroundImage)
                {
                    pct4.Visible = false;
                }
                else if (a == pct5.BackgroundImage)
                {
                    pct5.Visible = false;
                }
                else if (a == pct6.BackgroundImage)
                {
                    pct6.Visible = false;
                }
                else if (a == pct7.BackgroundImage)
                {
                    pct7.Visible = false;
                }
                else if (a == pct8.BackgroundImage)
                {
                    pct8.Visible = false;
                }
            }

        }

        private void pictureBox3_DragDrop(object sender, DragEventArgs e)
        {
            if (pictureBox3.BackgroundImage == null)
            {
                pictureBox3.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);

                Image a = pictureBox3.BackgroundImage;

                if (a == pct1.BackgroundImage)
                {
                    pct1.Visible = false;
                }
                else if (a == pct2.BackgroundImage)
                {
                    pct2.Visible = false;
                }
                else if (a == pct3.BackgroundImage)
                {
                    pct3.Visible = false;
                }
                else if (a == pct4.BackgroundImage)
                {
                    pct4.Visible = false;
                }
                else if (a == pct5.BackgroundImage)
                {
                    pct5.Visible = false;
                }
                else if (a == pct6.BackgroundImage)
                {
                    pct6.Visible = false;
                }
                else if (a == pct7.BackgroundImage)
                {
                    pct7.Visible = false;
                }
                else if (a == pct8.BackgroundImage)
                {
                    pct8.Visible = false;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            if (pictureBox1.BackgroundImage == null)
            {
                pictureBox1.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);

                Image a = pictureBox1.BackgroundImage;

                if (a == pct1.BackgroundImage)
                {
                    pct1.Visible = false;
                }
                else if (a == pct2.BackgroundImage)
                {
                    pct2.Visible = false;
                }
                else if (a == pct3.BackgroundImage)
                {
                    pct3.Visible = false;
                }
                else if (a == pct4.BackgroundImage)
                {
                    pct4.Visible = false;
                }
                else if (a == pct5.BackgroundImage)
                {
                    pct5.Visible = false;
                }
                else if (a == pct6.BackgroundImage)
                {
                    pct6.Visible = false;
                }
                else if (a == pct7.BackgroundImage)
                {
                    pct7.Visible = false;
                }
                else if (a == pct8.BackgroundImage)
                {
                    pct8.Visible = false;
                }
            }
        }

        private void pictureBox4_DragDrop(object sender, DragEventArgs e)
        {
            if (pictureBox4.BackgroundImage == null)
            {
                pictureBox4.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);

                Image a = pictureBox4.BackgroundImage;

                if (a == pct1.BackgroundImage)
                {
                    pct1.Visible = false;
                }
                else if (a == pct2.BackgroundImage)
                {
                    pct2.Visible = false;
                }
                else if (a == pct3.BackgroundImage)
                {
                    pct3.Visible = false;
                }
                else if (a == pct4.BackgroundImage)
                {
                    pct4.Visible = false;
                }
                else if (a == pct5.BackgroundImage)
                {
                    pct5.Visible = false;
                }
                else if (a == pct6.BackgroundImage)
                {
                    pct6.Visible = false;
                }
                else if (a == pct7.BackgroundImage)
                {
                    pct7.Visible = false;
                }
                else if (a == pct8.BackgroundImage)
                {
                    pct8.Visible = false;
                }
            }
        }

        private void pictureBox8_DragDrop(object sender, DragEventArgs e)
        {
            if (pictureBox8.BackgroundImage == null)
            {
                pictureBox8.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);

                Image a = pictureBox8.BackgroundImage;

                if (a == pct1.BackgroundImage)
                {
                    pct1.Visible = false;
                }
                else if (a == pct2.BackgroundImage)
                {
                    pct2.Visible = false;
                }
                else if (a == pct3.BackgroundImage)
                {
                    pct3.Visible = false;
                }
                else if (a == pct4.BackgroundImage)
                {
                    pct4.Visible = false;
                }
                else if (a == pct5.BackgroundImage)
                {
                    pct5.Visible = false;
                }
                else if (a == pct6.BackgroundImage)
                {
                    pct6.Visible = false;
                }
                else if (a == pct7.BackgroundImage)
                {
                    pct7.Visible = false;
                }
                else if (a == pct8.BackgroundImage)
                {
                    pct8.Visible = false;
                }
            }
        }

        private void pictureBox6_DragDrop(object sender, DragEventArgs e)
        {
            if (pictureBox6.BackgroundImage == null)
            {
                pictureBox6.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);

                Image a = pictureBox6.BackgroundImage;

                if (a == pct1.BackgroundImage)
                {
                    pct1.Visible = false;
                }
                else if (a == pct2.BackgroundImage)
                {
                    pct2.Visible = false;
                }
                else if (a == pct3.BackgroundImage)
                {
                    pct3.Visible = false;
                }
                else if (a == pct4.BackgroundImage)
                {
                    pct4.Visible = false;
                }
                else if (a == pct5.BackgroundImage)
                {
                    pct5.Visible = false;
                }
                else if (a == pct6.BackgroundImage)
                {
                    pct6.Visible = false;
                }
                else if (a == pct7.BackgroundImage)
                {
                    pct7.Visible = false;
                }
                else if (a == pct8.BackgroundImage)
                {
                    pct8.Visible = false;
                }
            }
        }

        private void pictureBox7_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
           
        }

        private void pictureBox5_DragDrop(object sender, DragEventArgs e)
        {
            if (pictureBox5.BackgroundImage == null)
            {
                pictureBox5.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);

                Image a = pictureBox5.BackgroundImage;

                if (a == pct1.BackgroundImage)
                {
                    pct1.Visible = false;
                }
                else if (a == pct2.BackgroundImage)
                {
                    pct2.Visible = false;
                }
                else if (a == pct3.BackgroundImage)
                {
                    pct3.Visible = false;
                }
                else if (a == pct4.BackgroundImage)
                {
                    pct4.Visible = false;
                }
                else if (a == pct5.BackgroundImage)
                {
                    pct5.Visible = false;
                }
                else if (a == pct6.BackgroundImage)
                {
                    pct6.Visible = false;
                }
                else if (a == pct7.BackgroundImage)
                {
                    pct7.Visible = false;
                }
                else if (a == pct8.BackgroundImage)
                {
                    pct8.Visible = false;
                }
            }
        }

        private void pictureBox2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictureBox3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictureBox4_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictureBox8_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictureBox6_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictureBox7_DragDrop(object sender, DragEventArgs e)
        {
            if (pictureBox7.BackgroundImage == null)
            {
                pictureBox7.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);

                Image a = pictureBox7.BackgroundImage;

                if (a == pct1.BackgroundImage)
                {
                    pct1.Visible = false;
                }
                else if (a == pct2.BackgroundImage)
                {
                    pct2.Visible = false;
                }
                else if (a == pct3.BackgroundImage)
                {
                    pct3.Visible = false;
                }
                else if (a == pct4.BackgroundImage)
                {
                    pct4.Visible = false;
                }
                else if (a == pct5.BackgroundImage)
                {
                    pct5.Visible = false;
                }
                else if (a == pct6.BackgroundImage)
                {
                    pct6.Visible = false;
                }
                else if (a == pct7.BackgroundImage)
                {
                    pct7.Visible = false;
                }
                else if (a == pct8.BackgroundImage)
                {
                    pct8.Visible = false;
                }
            }
        }

        private void pictureBox5_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pnlVerificar_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void pct3_Click(object sender, EventArgs e)
        {

        }
    }
}
