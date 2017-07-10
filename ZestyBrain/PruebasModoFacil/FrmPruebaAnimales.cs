using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZestyBrain
{
    public partial class FrmPruebaAnimales : Form
    {
        public FrmPruebaAnimales()
        {
            InitializeComponent();
        }
        SoundPlayer Player;
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

                    
        private void FrmPruebaAnimales_Load(object sender, EventArgs e)
        {
            pnlRegresar.Visible = false;
            pctHome.Visible = false;
            pictureBox10.AllowDrop = true;
            pictureBox11.AllowDrop = true;
            pictureBox12.AllowDrop = true;
            pictureBox23.AllowDrop = true;
            pictureBox13.AllowDrop = true;
            pictureBox14.AllowDrop = true;
            pictureBox15.AllowDrop = true;
            pictureBox.AllowDrop = true;
        }

        private void lblVerificar_Click(object sender, EventArgs e)
        {
            pnlRegresar.Visible = true;
            pctHome.Visible = true;

            if (pictureBox4.BackgroundImage == pictureBox10.BackgroundImage)
            {
                pictureBox25.Visible = true;
            }

            if (pictureBox2.BackgroundImage == pictureBox11.BackgroundImage)
            {
                pictureBox26.Visible = true;
            }

            if (pictureBox3.BackgroundImage == pictureBox12.BackgroundImage)
            {
                pictureBox27.Visible = true;
            }

            if (pictureBox1.BackgroundImage == pictureBox23.BackgroundImage)
            {
                pictureBox28.Visible = true;
            }

            if (pictureBox13.BackgroundImage == pictureBox20.BackgroundImage)
            {
                pictureBox29.Visible = true;
            }

            if (pictureBox5.BackgroundImage == pictureBox14.BackgroundImage)
            {
                pictureBox30.Visible = true;
            }

            if (pictureBox19.BackgroundImage == pictureBox15.BackgroundImage)
            {
                pictureBox31.Visible = true;
            }
            if (pictureBox6.BackgroundImage == pictureBox.BackgroundImage)
            {
                pictureBox32.Visible = true;
            }
        }

        private void lblVerificar_MouseHover(object sender, EventArgs e)
        {
            pnlVerificar.Size = new Size(170, 57);
        }

        private void lblVerificar_MouseLeave(object sender, EventArgs e)
        {
            pnlVerificar.Size = new Size(165, 52);
        }

        private void pnlRegresar_MouseHover_1(object sender, EventArgs e)
        {
            pnlRegresar.Size = new Size(47, 47);
        }

        private void pnlRegresar_MouseLeave_1(object sender, EventArgs e)
        {
            pnlRegresar.Size = new Size(43, 43);
        }

        private void pnlRegresar_Click_1(object sender, EventArgs e)
        {
            FrmAnimales objAnimales = new FrmAnimales();
            objAnimales.Show();
            this.Visible = false;
        }

        private void pctHome_Click_1(object sender, EventArgs e)
        {
            PantallaPrincipal.FrmInicio objInicio = new PantallaPrincipal.FrmInicio();
            objInicio.Show();
            this.Visible = false;
        }

        private void pctHome_MouseHover_1(object sender, EventArgs e)
        {
            pctHome.Size = new Size(57, 53);
        }

        private void pctHome_MouseLeave_1(object sender, EventArgs e)
        {
            pctHome.Size = new Size(52, 48);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (pictureBox1.BackgroundImage != null)
            {
                
                pictureBox1.DoDragDrop(pictureBox1.BackgroundImage, DragDropEffects.Copy);
               

            }
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            if (pictureBox3.BackgroundImage != null)
            {
                
                pictureBox3.DoDragDrop(pictureBox3.BackgroundImage, DragDropEffects.Copy);

            }
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            if (pictureBox5.BackgroundImage != null)
            {
                
                pictureBox5.DoDragDrop(pictureBox5.BackgroundImage, DragDropEffects.Copy);

            }
        }

        private void pictureBox20_MouseDown(object sender, MouseEventArgs e)
        {
            if (pictureBox20.BackgroundImage != null)
            {
               
               
                pictureBox20.DoDragDrop(pictureBox20.BackgroundImage, DragDropEffects.Copy);

            }
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (pictureBox2.BackgroundImage != null)
            {
                
                pictureBox2.DoDragDrop(pictureBox2.BackgroundImage, DragDropEffects.Copy);

            }
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            if (pictureBox4.BackgroundImage != null)
            {
              
                pictureBox4.DoDragDrop(pictureBox4.BackgroundImage, DragDropEffects.Copy);

            }
        }

        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            if (pictureBox6.BackgroundImage != null)
            {
               
                pictureBox6.DoDragDrop(pictureBox6.BackgroundImage, DragDropEffects.Copy);

            }
        }

        private void pictureBox19_MouseDown(object sender, MouseEventArgs e)
        {
            if (pictureBox19.BackgroundImage != null)
            {
              
                pictureBox19.DoDragDrop(pictureBox19.BackgroundImage, DragDropEffects.Copy);
               
            }
        }

        private void pictureBox10_DragDrop(object sender, DragEventArgs e)
        {
            if (pictureBox10.BackgroundImage == null)
            {
                pictureBox10.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);

                Image a = pictureBox10.BackgroundImage;
                if (a == pictureBox1.BackgroundImage)
                {
                    pictureBox1.Visible = false;

                }
                else if (a == pictureBox2.BackgroundImage)
                {
                    pictureBox2.Visible = false;
                }
                else if (a == pictureBox3.BackgroundImage)
                {
                    pictureBox3.Visible = false;
                }
                else if (a == pictureBox4.BackgroundImage)
                {
                    pictureBox4.Visible = false;
                }
                else if (a == pictureBox5.BackgroundImage)
                {
                    pictureBox5.Visible = false;
                }
                else if (a == pictureBox6.BackgroundImage)
                {
                    pictureBox6.Visible = false;
                }
                else if (a == pictureBox20.BackgroundImage)
                {
                    pictureBox20.Visible = false;
                }
                else if (a == pictureBox19.BackgroundImage)
                {
                    pictureBox19.Visible = false;
                }






            }
        }

        private void pictureBox13_DragDrop(object sender, DragEventArgs e)
        {
            if (pictureBox13.BackgroundImage == null)
            {
                pictureBox13.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);

                Image a = pictureBox13.BackgroundImage;
                if (a == pictureBox1.BackgroundImage)
                {
                    pictureBox1.Visible = false;

                }
                else if (a == pictureBox2.BackgroundImage)
                {
                    pictureBox2.Visible = false;
                }
                else if (a == pictureBox3.BackgroundImage)
                {
                    pictureBox3.Visible = false;
                }
                else if (a == pictureBox4.BackgroundImage)
                {
                    pictureBox4.Visible = false;
                }
                else if (a == pictureBox5.BackgroundImage)
                {
                    pictureBox5.Visible = false;
                }
                else if (a == pictureBox6.BackgroundImage)
                {
                    pictureBox6.Visible = false;
                }
                else if (a == pictureBox20.BackgroundImage)
                {
                    pictureBox20.Visible = false;
                }
                else if (a == pictureBox19.BackgroundImage)
                {
                    pictureBox19.Visible = false;
                }

            }
        }

        private void pictureBox11_DragDrop(object sender, DragEventArgs e)
        {
            if (pictureBox11.BackgroundImage == null)
            {
                pictureBox11.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
                Image a = pictureBox11.BackgroundImage;
                if (a == pictureBox1.BackgroundImage)
                {
                    pictureBox1.Visible = false;

                }
                else if (a == pictureBox2.BackgroundImage)
                {
                    pictureBox2.Visible = false;
                }
                else if (a == pictureBox3.BackgroundImage)
                {
                    pictureBox3.Visible = false;
                }
                else if (a == pictureBox4.BackgroundImage)
                {
                    pictureBox4.Visible = false;
                }
                else if (a == pictureBox5.BackgroundImage)
                {
                    pictureBox5.Visible = false;
                }
                else if (a == pictureBox6.BackgroundImage)
                {
                    pictureBox6.Visible = false;
                }
                else if (a == pictureBox20.BackgroundImage)
                {
                    pictureBox20.Visible = false;
                }
                else if (a == pictureBox19.BackgroundImage)
                {
                    pictureBox19.Visible = false;
                }
            }
        }

        private void pictureBox14_DragDrop(object sender, DragEventArgs e)
        {
            if (pictureBox14.BackgroundImage == null)
            {
                pictureBox14.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
                Image a = pictureBox14.BackgroundImage;
                if (a == pictureBox1.BackgroundImage)
                {
                    pictureBox1.Visible = false;

                }
                else if (a == pictureBox2.BackgroundImage)
                {
                    pictureBox2.Visible = false;
                }
                else if (a == pictureBox3.BackgroundImage)
                {
                    pictureBox3.Visible = false;
                }
                else if (a == pictureBox4.BackgroundImage)
                {
                    pictureBox4.Visible = false;
                }
                else if (a == pictureBox5.BackgroundImage)
                {
                    pictureBox5.Visible = false;
                }
                else if (a == pictureBox6.BackgroundImage)
                {
                    pictureBox6.Visible = false;
                }
                else if (a == pictureBox20.BackgroundImage)
                {
                    pictureBox20.Visible = false;
                }
                else if (a == pictureBox19.BackgroundImage)
                {
                    pictureBox19.Visible = false;
                }

            }
        }

        private void pictureBox12_DragDrop(object sender, DragEventArgs e)
        {
            if (pictureBox12.BackgroundImage == null)
            {
                pictureBox12.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
                Image a = pictureBox12.BackgroundImage;
                if (a == pictureBox1.BackgroundImage)
                {
                    pictureBox1.Visible = false;

                }
                else if (a == pictureBox2.BackgroundImage)
                {
                    pictureBox2.Visible = false;
                }
                else if (a == pictureBox3.BackgroundImage)
                {
                    pictureBox3.Visible = false;
                }
                else if (a == pictureBox4.BackgroundImage)
                {
                    pictureBox4.Visible = false;
                }
                else if (a == pictureBox5.BackgroundImage)
                {
                    pictureBox5.Visible = false;
                }
                else if (a == pictureBox6.BackgroundImage)
                {
                    pictureBox6.Visible = false;
                }
                else if (a == pictureBox20.BackgroundImage)
                {
                    pictureBox20.Visible = false;
                }
                else if (a == pictureBox19.BackgroundImage)
                {
                    pictureBox19.Visible = false;
                }

            }
        }

        private void pictureBox15_DragDrop(object sender, DragEventArgs e)
        {
            if (pictureBox15.BackgroundImage == null)
            {
                pictureBox15.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
                Image a = pictureBox15.BackgroundImage;
                if (a == pictureBox1.BackgroundImage)
                {
                    pictureBox1.Visible = false;

                }
                else if (a == pictureBox2.BackgroundImage)
                {
                    pictureBox2.Visible = false;
                }
                else if (a == pictureBox3.BackgroundImage)
                {
                    pictureBox3.Visible = false;
                }
                else if (a == pictureBox4.BackgroundImage)
                {
                    pictureBox4.Visible = false;
                }
                else if (a == pictureBox5.BackgroundImage)
                {
                    pictureBox5.Visible = false;
                }
                else if (a == pictureBox6.BackgroundImage)
                {
                    pictureBox6.Visible = false;
                }
                else if (a == pictureBox20.BackgroundImage)
                {
                    pictureBox20.Visible = false;
                }
                else if (a == pictureBox19.BackgroundImage)
                {
                    pictureBox19.Visible = false;
                }

            }
        }

        private void pictureBox23_DragDrop(object sender, DragEventArgs e)
        {
            if (pictureBox23.BackgroundImage == null)
            {
                pictureBox23.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
                Image a = pictureBox23.BackgroundImage;
                if (a == pictureBox1.BackgroundImage)
                {
                    pictureBox1.Visible = false;

                }
                else if (a == pictureBox2.BackgroundImage)
                {
                    pictureBox2.Visible = false;
                }
                else if (a == pictureBox3.BackgroundImage)
                {
                    pictureBox3.Visible = false;
                }
                else if (a == pictureBox4.BackgroundImage)
                {
                    pictureBox4.Visible = false; ;
                }
                else if (a == pictureBox5.BackgroundImage)
                {
                    pictureBox5.Visible = false; ;
                }
                else if (a == pictureBox6.BackgroundImage)
                {
                    pictureBox6.Visible = false; ;
                }
                else if (a == pictureBox20.BackgroundImage)
                {
                    pictureBox20.Visible = false; ;
                }
                else if (a == pictureBox19.BackgroundImage)
                {
                    pictureBox19.Visible = false; ;
                }

            }
        }

       

        private void pictureBox10_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictureBox11_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictureBox13_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictureBox14_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictureBox12_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictureBox15_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictureBox23_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictureBox_DragDrop(object sender, DragEventArgs e)
        {
            if (pictureBox.BackgroundImage == null)
            {
                pictureBox.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
                Image a = pictureBox.BackgroundImage;
                if (a == pictureBox1.BackgroundImage)
                {
                    pictureBox1.Visible = false;

                }
                else if (a == pictureBox2.BackgroundImage)
                {
                    pictureBox2.Visible = false;
                }
                else if (a == pictureBox3.BackgroundImage)
                {
                    pictureBox3.Visible = false;
                }
                else if (a == pictureBox4.BackgroundImage)
                {
                    pictureBox4.Visible = false;
                }
                else if (a == pictureBox5.BackgroundImage)
                {
                    pictureBox5.Visible = false;
                }
                else if (a == pictureBox6.BackgroundImage)
                {
                    pictureBox6.Visible = false;
                }
                else if (a == pictureBox20.BackgroundImage)
                {
                    pictureBox20.Visible = false;
                }
                else if (a == pictureBox19.BackgroundImage)
                {
                    pictureBox19.Visible = false;
                }

            }
        }

        private void pictureBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            try
            {
                Player = null;
                if (Player == null)
                {
                    Player = new SoundPlayer(ZestyBrain.Properties.Resources.cerdo);
                    Player.Play();

                }
                else
                {
                    Player.Play();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            try
            {
                Player = null;

                if (Player == null)
                {
                    Player = new SoundPlayer(ZestyBrain.Properties.Resources.perro1);
                    Player.Play();

                }
                else
                {
                    Player.Play();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            try
            {
                Player = null;

                if (Player == null)
                {
                    Player = new SoundPlayer(ZestyBrain.Properties.Resources.caballo1);
                    Player.Play();

                }
                else
                {
                    Player.Play();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            try
            {
                Player = null;

                if (Player == null)
                {
                    Player = new SoundPlayer(ZestyBrain.Properties.Resources.gallina1);
                    Player.Play();

                }
                else
                {
                    Player.Play();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            try
            {
                Player = null;

                if (Player == null)
                {
                    Player = new SoundPlayer(ZestyBrain.Properties.Resources.pato1);
                    Player.Play();

                }
                else
                {
                    Player.Play();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            try
            {
                Player = null;

                if (Player == null)
                {
                    Player = new SoundPlayer(ZestyBrain.Properties.Resources.Leopardo);
                    Player.Play();

                }
                else
                {
                    Player.Play();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            try
            {
                Player = null;

                if (Player == null)
                {
                    Player = new SoundPlayer(ZestyBrain.Properties.Resources.oveja1);
                    Player.Play();

                }
                else
                {
                    Player.Play();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            try
            {
                Player = null;
                if (Player == null)
                {
                    Player = new SoundPlayer(ZestyBrain.Properties.Resources.rana);
                    Player.Play();

                }
                else
                {
                    Player.Play();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void pnlVerificar_Paint(object sender, PaintEventArgs e)
        {
            pnlRegresar.Visible = true;
            pctHome.Visible = true;

           
        }
    }
}
