namespace ZestyBrain
{
    partial class FrmAlimentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlimentos));
            this.pnlRegresar = new System.Windows.Forms.Panel();
            this.pctSalir = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pctHome = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.wmpAlimentos = new AxWMPLib.AxWindowsMediaPlayer();
            this.pnlPrueba = new System.Windows.Forms.Panel();
            this.lblPrueba = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctHome)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpAlimentos)).BeginInit();
            this.pnlPrueba.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRegresar
            // 
            this.pnlRegresar.BackColor = System.Drawing.Color.Transparent;
            this.pnlRegresar.BackgroundImage = global::ZestyBrain.Properties.Resources.Button_Previous_icon;
            this.pnlRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRegresar.Location = new System.Drawing.Point(807, 20);
            this.pnlRegresar.Name = "pnlRegresar";
            this.pnlRegresar.Size = new System.Drawing.Size(43, 43);
            this.pnlRegresar.TabIndex = 37;
            this.pnlRegresar.Click += new System.EventHandler(this.pnlRegresar_Click);
            this.pnlRegresar.MouseLeave += new System.EventHandler(this.pnlRegresar_MouseLeave);
            this.pnlRegresar.MouseHover += new System.EventHandler(this.pnlRegresar_MouseHover);
            // 
            // pctSalir
            // 
            this.pctSalir.BackColor = System.Drawing.Color.Transparent;
            this.pctSalir.Image = global::ZestyBrain.Properties.Resources.button_31222_960_720;
            this.pctSalir.Location = new System.Drawing.Point(868, 20);
            this.pctSalir.Name = "pctSalir";
            this.pctSalir.Size = new System.Drawing.Size(43, 43);
            this.pctSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSalir.TabIndex = 36;
            this.pctSalir.TabStop = false;
            this.pctSalir.Click += new System.EventHandler(this.pctSalir_Click);
            this.pctSalir.MouseLeave += new System.EventHandler(this.pctSalir_MouseLeave);
            this.pctSalir.MouseHover += new System.EventHandler(this.pctSalir_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Skater Girls Rock", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(373, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 41);
            this.label4.TabIndex = 38;
            this.label4.Text = "Los Alimentos";
            // 
            // pctHome
            // 
            this.pctHome.BackColor = System.Drawing.Color.Transparent;
            this.pctHome.Image = global::ZestyBrain.Properties.Resources.m_home;
            this.pctHome.Location = new System.Drawing.Point(22, 11);
            this.pctHome.Name = "pctHome";
            this.pctHome.Size = new System.Drawing.Size(53, 57);
            this.pctHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctHome.TabIndex = 39;
            this.pctHome.TabStop = false;
            this.pctHome.Click += new System.EventHandler(this.pctHome_Click);
            this.pctHome.MouseLeave += new System.EventHandler(this.pctHome_MouseLeave);
            this.pctHome.MouseHover += new System.EventHandler(this.pctHome_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.wmpAlimentos);
            this.panel1.Location = new System.Drawing.Point(58, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 414);
            this.panel1.TabIndex = 40;
            // 
            // wmpAlimentos
            // 
            this.wmpAlimentos.Enabled = true;
            this.wmpAlimentos.Location = new System.Drawing.Point(11, 7);
            this.wmpAlimentos.Name = "wmpAlimentos";
            this.wmpAlimentos.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpAlimentos.OcxState")));
            this.wmpAlimentos.Size = new System.Drawing.Size(804, 399);
            this.wmpAlimentos.TabIndex = 16;
            // 
            // pnlPrueba
            // 
            this.pnlPrueba.BackColor = System.Drawing.Color.Transparent;
            this.pnlPrueba.BackgroundImage = global::ZestyBrain.Properties.Resources.red_stop_button_icon_png_9;
            this.pnlPrueba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPrueba.Controls.Add(this.lblPrueba);
            this.pnlPrueba.Location = new System.Drawing.Point(426, 506);
            this.pnlPrueba.Name = "pnlPrueba";
            this.pnlPrueba.Size = new System.Drawing.Size(102, 87);
            this.pnlPrueba.TabIndex = 41;
            // 
            // lblPrueba
            // 
            this.lblPrueba.Font = new System.Drawing.Font("Skater Girls Rock", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrueba.ForeColor = System.Drawing.Color.White;
            this.lblPrueba.Location = new System.Drawing.Point(12, 4);
            this.lblPrueba.Name = "lblPrueba";
            this.lblPrueba.Size = new System.Drawing.Size(83, 58);
            this.lblPrueba.TabIndex = 1;
            this.lblPrueba.Text = "Ir a Prueba";
            this.lblPrueba.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPrueba.Click += new System.EventHandler(this.lblPrueba_Click);
            this.lblPrueba.MouseLeave += new System.EventHandler(this.lblPrueba_MouseLeave);
            this.lblPrueba.MouseHover += new System.EventHandler(this.lblPrueba_MouseHover);
            // 
            // FrmAlimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZestyBrain.Properties.Resources.ec5e98c7b61e11bbe6b44c843f462f3f;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(937, 600);
            this.ControlBox = false;
            this.Controls.Add(this.pnlPrueba);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pctHome);
            this.Controls.Add(this.pnlRegresar);
            this.Controls.Add(this.pctSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAlimentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAlimentos";
            ((System.ComponentModel.ISupportInitialize)(this.pctSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctHome)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wmpAlimentos)).EndInit();
            this.pnlPrueba.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegresar;
        private System.Windows.Forms.PictureBox pctSalir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pctHome;
        private System.Windows.Forms.Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer wmpAlimentos;
        private System.Windows.Forms.Panel pnlPrueba;
        private System.Windows.Forms.Label lblPrueba;
    }
}