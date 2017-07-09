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
            this.panel1 = new System.Windows.Forms.Panel();
            this.wmpAnimales = new AxWMPLib.AxWindowsMediaPlayer();
            this.pnlRegresar = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlPrueba = new System.Windows.Forms.Panel();
            this.lblPrueba = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSalir)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpAnimales)).BeginInit();
            this.pnlPrueba.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbHome
            // 
            this.pcbHome.BackColor = System.Drawing.Color.Transparent;
            this.pcbHome.Image = global::ZestyBrain.Properties.Resources.m_home;
            this.pcbHome.Location = new System.Drawing.Point(19, 10);
            this.pcbHome.Name = "pcbHome";
            this.pcbHome.Size = new System.Drawing.Size(53, 57);
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
            this.pcbSalir.Location = new System.Drawing.Point(900, 18);
            this.pcbSalir.Name = "pcbSalir";
            this.pcbSalir.Size = new System.Drawing.Size(43, 43);
            this.pcbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSalir.TabIndex = 12;
            this.pcbSalir.TabStop = false;
            this.pcbSalir.Click += new System.EventHandler(this.pcbSalir_Click);
            this.pcbSalir.MouseLeave += new System.EventHandler(this.pcbSalir_MouseLeave);
            this.pcbSalir.MouseHover += new System.EventHandler(this.pcbSalir_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.wmpAnimales);
            this.panel1.Location = new System.Drawing.Point(108, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 408);
            this.panel1.TabIndex = 16;
            // 
            // wmpAnimales
            // 
            this.wmpAnimales.Enabled = true;
            this.wmpAnimales.Location = new System.Drawing.Point(9, 6);
            this.wmpAnimales.Name = "wmpAnimales";
            this.wmpAnimales.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpAnimales.OcxState")));
            this.wmpAnimales.Size = new System.Drawing.Size(739, 395);
            this.wmpAnimales.TabIndex = 16;
            // 
            // pnlRegresar
            // 
            this.pnlRegresar.BackColor = System.Drawing.Color.Transparent;
            this.pnlRegresar.BackgroundImage = global::ZestyBrain.Properties.Resources.Button_Previous_icon;
            this.pnlRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRegresar.Location = new System.Drawing.Point(841, 18);
            this.pnlRegresar.Name = "pnlRegresar";
            this.pnlRegresar.Size = new System.Drawing.Size(43, 43);
            this.pnlRegresar.TabIndex = 35;
            this.pnlRegresar.Click += new System.EventHandler(this.pnlRegresar_Click);
            this.pnlRegresar.MouseLeave += new System.EventHandler(this.pnlRegresar_MouseLeave);
            this.pnlRegresar.MouseHover += new System.EventHandler(this.pnlRegresar_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Skater Girls Rock", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(391, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 41);
            this.label4.TabIndex = 0;
            this.label4.Text = "Los Animales";
            // 
            // pnlPrueba
            // 
            this.pnlPrueba.BackColor = System.Drawing.Color.Transparent;
            this.pnlPrueba.BackgroundImage = global::ZestyBrain.Properties.Resources.red_stop_button_icon_png_9;
            this.pnlPrueba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPrueba.Controls.Add(this.lblPrueba);
            this.pnlPrueba.Location = new System.Drawing.Point(452, 495);
            this.pnlPrueba.Name = "pnlPrueba";
            this.pnlPrueba.Size = new System.Drawing.Size(102, 87);
            this.pnlPrueba.TabIndex = 39;
            // 
            // lblPrueba
            // 
            this.lblPrueba.Font = new System.Drawing.Font("Skater Girls Rock", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrueba.ForeColor = System.Drawing.Color.White;
            this.lblPrueba.Location = new System.Drawing.Point(12, 5);
            this.lblPrueba.Name = "lblPrueba";
            this.lblPrueba.Size = new System.Drawing.Size(83, 58);
            this.lblPrueba.TabIndex = 1;
            this.lblPrueba.Text = "Ir a Prueba";
            this.lblPrueba.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPrueba.Click += new System.EventHandler(this.lblPrueba_Click);
            this.lblPrueba.MouseLeave += new System.EventHandler(this.lblPrueba_MouseLeave);
            this.lblPrueba.MouseHover += new System.EventHandler(this.lblPrueba_MouseHover);
            // 
            // FrmAnimales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZestyBrain.Properties.Resources.arreglado;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(970, 600);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnlPrueba);
            this.Controls.Add(this.pcbHome);
            this.Controls.Add(this.pnlRegresar);
            this.Controls.Add(this.pcbSalir);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAnimales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAnimales";
            ((System.ComponentModel.ISupportInitialize)(this.pcbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSalir)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wmpAnimales)).EndInit();
            this.pnlPrueba.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pcbHome;
        private System.Windows.Forms.PictureBox pcbSalir;
        private System.Windows.Forms.Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer wmpAnimales;
        private System.Windows.Forms.Panel pnlRegresar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlPrueba;
        private System.Windows.Forms.Label lblPrueba;
    }
}