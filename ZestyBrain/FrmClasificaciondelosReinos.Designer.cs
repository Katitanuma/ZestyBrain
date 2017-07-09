namespace ZestyBrain
{
    partial class FrmClasificaciondelosReinos
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
            this.pctHome = new System.Windows.Forms.PictureBox();
            this.pnlRegresar = new System.Windows.Forms.Panel();
            this.pnlPrueba = new System.Windows.Forms.Panel();
            this.lblPrueba = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctHome)).BeginInit();
            this.pnlPrueba.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctHome
            // 
            this.pctHome.BackColor = System.Drawing.Color.Transparent;
            this.pctHome.Image = global::ZestyBrain.Properties.Resources.m_home;
            this.pctHome.Location = new System.Drawing.Point(19, 10);
            this.pctHome.Name = "pctHome";
            this.pctHome.Size = new System.Drawing.Size(53, 57);
            this.pctHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctHome.TabIndex = 40;
            this.pctHome.TabStop = false;
            this.pctHome.Click += new System.EventHandler(this.pctHome_Click);
            this.pctHome.MouseHover += new System.EventHandler(this.pctHome_MouseHover);
            // 
            // pnlRegresar
            // 
            this.pnlRegresar.BackColor = System.Drawing.Color.Transparent;
            this.pnlRegresar.BackgroundImage = global::ZestyBrain.Properties.Resources.Button_Previous_icon;
            this.pnlRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRegresar.Location = new System.Drawing.Point(841, 18);
            this.pnlRegresar.Name = "pnlRegresar";
            this.pnlRegresar.Size = new System.Drawing.Size(43, 43);
            this.pnlRegresar.TabIndex = 41;
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
            this.pnlPrueba.TabIndex = 42;
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
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Skater Girls Rock", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(317, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(418, 41);
            this.label4.TabIndex = 43;
            this.label4.Text = "Clasificación de los Reinos";
            // 
            // FrmClasificaciondelosReinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 600);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pctHome);
            this.Controls.Add(this.pnlRegresar);
            this.Controls.Add(this.pnlPrueba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClasificaciondelosReinos";
            this.Text = "FrmClasificaciondelosReinos";
            ((System.ComponentModel.ISupportInitialize)(this.pctHome)).EndInit();
            this.pnlPrueba.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctHome;
        private System.Windows.Forms.Panel pnlRegresar;
        private System.Windows.Forms.Label lblPrueba;
        private System.Windows.Forms.Panel pnlPrueba;
        private System.Windows.Forms.Label label4;
    }
}