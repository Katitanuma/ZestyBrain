namespace ZestyBrain
{
    partial class FrmAnimales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnimales));
            this.pcbHome = new System.Windows.Forms.PictureBox();
            this.pcbSalir = new System.Windows.Forms.PictureBox();
            this.pcbPrueba = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPrueba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbHome
            // 
            this.pcbHome.BackColor = System.Drawing.Color.Transparent;
            this.pcbHome.Image = global::ZestyBrain.Properties.Resources.botonHome;
            this.pcbHome.Location = new System.Drawing.Point(24, 2);
            this.pcbHome.Name = "pcbHome";
            this.pcbHome.Size = new System.Drawing.Size(50, 50);
            this.pcbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbHome.TabIndex = 13;
            this.pcbHome.TabStop = false;
            this.pcbHome.Click += new System.EventHandler(this.pcbHome_Click);
            this.pcbHome.MouseLeave += new System.EventHandler(this.pcbHome_MouseLeave);
            this.pcbHome.MouseHover += new System.EventHandler(this.pcbHome_MouseHover);
            // 
            // pcbSalir
            // 
            this.pcbSalir.BackColor = System.Drawing.Color.Transparent;
            this.pcbSalir.Image = global::ZestyBrain.Properties.Resources.button_31222_960_720;
            this.pcbSalir.Location = new System.Drawing.Point(772, 2);
            this.pcbSalir.Name = "pcbSalir";
            this.pcbSalir.Size = new System.Drawing.Size(50, 50);
            this.pcbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSalir.TabIndex = 12;
            this.pcbSalir.TabStop = false;
            this.pcbSalir.Click += new System.EventHandler(this.pcbSalir_Click);
            this.pcbSalir.MouseLeave += new System.EventHandler(this.pcbSalir_MouseLeave);
            this.pcbSalir.MouseHover += new System.EventHandler(this.pcbSalir_MouseHover);
            // 
            // pcbPrueba
            // 
            this.pcbPrueba.BackColor = System.Drawing.Color.Transparent;
            this.pcbPrueba.Image = global::ZestyBrain.Properties.Resources.botonPrueba;
            this.pcbPrueba.Location = new System.Drawing.Point(734, 486);
            this.pcbPrueba.Name = "pcbPrueba";
            this.pcbPrueba.Size = new System.Drawing.Size(75, 75);
            this.pcbPrueba.TabIndex = 14;
            this.pcbPrueba.TabStop = false;
            this.pcbPrueba.Click += new System.EventHandler(this.pcbPrueba_Click);
            this.pcbPrueba.MouseLeave += new System.EventHandler(this.pcbPrueba_MouseLeave);
            this.pcbPrueba.MouseHover += new System.EventHandler(this.pcbPrueba_MouseHover);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(139, 96);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(541, 401);
            this.axWindowsMediaPlayer1.TabIndex = 15;
            // 
            // FrmAnimales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZestyBrain.Properties.Resources.fondoniños;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 591);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.pcbPrueba);
            this.Controls.Add(this.pcbHome);
            this.Controls.Add(this.pcbSalir);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAnimales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAnimales";
            ((System.ComponentModel.ISupportInitialize)(this.pcbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPrueba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pcbHome;
        private System.Windows.Forms.PictureBox pcbSalir;
        private System.Windows.Forms.PictureBox pcbPrueba;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}