namespace ZestyBrain
{
    partial class FrmCuerpoHumano2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCuerpoHumano2));
            this.pctSalir = new System.Windows.Forms.PictureBox();
            this.wmpSentido = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlPrueba = new System.Windows.Forms.Panel();
            this.lblPrueba = new System.Windows.Forms.Label();
            this.pctHome = new System.Windows.Forms.PictureBox();
            this.pnlRegresar = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpSentido)).BeginInit();
            this.pnlPrueba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctHome)).BeginInit();
            this.SuspendLayout();
            // 
            // pctSalir
            // 
            this.pctSalir.BackColor = System.Drawing.Color.Transparent;
            this.pctSalir.Image = global::ZestyBrain.Properties.Resources.button_31222_960_720;
            this.pctSalir.Location = new System.Drawing.Point(900, 16);
            this.pctSalir.Name = "pctSalir";
            this.pctSalir.Size = new System.Drawing.Size(43, 43);
            this.pctSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSalir.TabIndex = 11;
            this.pctSalir.TabStop = false;
            this.pctSalir.Click += new System.EventHandler(this.pctSalir_Click);
            this.pctSalir.MouseLeave += new System.EventHandler(this.pctSalir_MouseLeave);
            this.pctSalir.MouseHover += new System.EventHandler(this.pctSalir_MouseHover);
            // 
            // wmpSentido
            // 
            this.wmpSentido.Enabled = true;
            this.wmpSentido.Location = new System.Drawing.Point(91, 91);
            this.wmpSentido.Name = "wmpSentido";
            this.wmpSentido.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpSentido.OcxState")));
            this.wmpSentido.Size = new System.Drawing.Size(786, 399);
            this.wmpSentido.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(80, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 420);
            this.panel1.TabIndex = 18;
            // 
            // pnlPrueba
            // 
            this.pnlPrueba.BackColor = System.Drawing.Color.Transparent;
            this.pnlPrueba.BackgroundImage = global::ZestyBrain.Properties.Resources.perspective_button_go;
            this.pnlPrueba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPrueba.Controls.Add(this.lblPrueba);
            this.pnlPrueba.Location = new System.Drawing.Point(437, 508);
            this.pnlPrueba.Name = "pnlPrueba";
            this.pnlPrueba.Size = new System.Drawing.Size(102, 87);
            this.pnlPrueba.TabIndex = 40;
            // 
            // lblPrueba
            // 
            this.lblPrueba.Font = new System.Drawing.Font("Skater Girls Rock", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrueba.ForeColor = System.Drawing.Color.Black;
            this.lblPrueba.Location = new System.Drawing.Point(10, 5);
            this.lblPrueba.Name = "lblPrueba";
            this.lblPrueba.Size = new System.Drawing.Size(83, 58);
            this.lblPrueba.TabIndex = 1;
            this.lblPrueba.Text = "Ir a Prueba";
            this.lblPrueba.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPrueba.Click += new System.EventHandler(this.lblPrueba_Click);
            this.lblPrueba.MouseLeave += new System.EventHandler(this.lblPrueba_MouseLeave);
            this.lblPrueba.MouseHover += new System.EventHandler(this.lblPrueba_MouseHover);
            // 
            // pctHome
            // 
            this.pctHome.BackColor = System.Drawing.Color.Transparent;
            this.pctHome.Image = global::ZestyBrain.Properties.Resources.m_home;
            this.pctHome.Location = new System.Drawing.Point(19, 14);
            this.pctHome.Name = "pctHome";
            this.pctHome.Size = new System.Drawing.Size(53, 57);
            this.pctHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctHome.TabIndex = 41;
            this.pctHome.TabStop = false;
            this.pctHome.Click += new System.EventHandler(this.pctHome_Click);
            this.pctHome.MouseLeave += new System.EventHandler(this.pctHome_MouseLeave);
            this.pctHome.MouseHover += new System.EventHandler(this.pctHome_MouseHover);
            // 
            // pnlRegresar
            // 
            this.pnlRegresar.BackColor = System.Drawing.Color.Transparent;
            this.pnlRegresar.BackgroundImage = global::ZestyBrain.Properties.Resources.Button_Previous_icon;
            this.pnlRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRegresar.Location = new System.Drawing.Point(839, 16);
            this.pnlRegresar.Name = "pnlRegresar";
            this.pnlRegresar.Size = new System.Drawing.Size(43, 43);
            this.pnlRegresar.TabIndex = 42;
            this.pnlRegresar.Click += new System.EventHandler(this.pnlRegresar_Click);
            this.pnlRegresar.MouseLeave += new System.EventHandler(this.pnlRegresar_MouseLeave);
            this.pnlRegresar.MouseHover += new System.EventHandler(this.pnlRegresar_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Skater Girls Rock", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(382, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 41);
            this.label4.TabIndex = 43;
            this.label4.Text = "Los Sentidos";
            // 
            // FrmCuerpoHumano2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZestyBrain.Properties.Resources.sentidos_arre;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(970, 600);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pctHome);
            this.Controls.Add(this.pnlRegresar);
            this.Controls.Add(this.pnlPrueba);
            this.Controls.Add(this.wmpSentido);
            this.Controls.Add(this.pctSalir);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCuerpoHumano2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCuerpoHumano2";
            ((System.ComponentModel.ISupportInitialize)(this.pctSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpSentido)).EndInit();
            this.pnlPrueba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pctSalir;
        private AxWMPLib.AxWindowsMediaPlayer wmpSentido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlPrueba;
        private System.Windows.Forms.Label lblPrueba;
        private System.Windows.Forms.PictureBox pctHome;
        private System.Windows.Forms.Panel pnlRegresar;
        private System.Windows.Forms.Label label4;
    }
}