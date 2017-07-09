namespace ZestyBrain
{
    partial class FrmPruebaAnimales
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
            this.label5 = new System.Windows.Forms.Label();
            this.pctSalir = new System.Windows.Forms.PictureBox();
            this.pctHome = new System.Windows.Forms.PictureBox();
            this.pnlRegresar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctHome)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Skater Girls Rock", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(367, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(292, 36);
            this.label5.TabIndex = 44;
            this.label5.Text = "Prueba: Los animales";
            // 
            // pctSalir
            // 
            this.pctSalir.BackColor = System.Drawing.Color.Transparent;
            this.pctSalir.Image = global::ZestyBrain.Properties.Resources.button_31222_960_720;
            this.pctSalir.Location = new System.Drawing.Point(932, 22);
            this.pctSalir.Name = "pctSalir";
            this.pctSalir.Size = new System.Drawing.Size(43, 43);
            this.pctSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSalir.TabIndex = 45;
            this.pctSalir.TabStop = false;
            // 
            // pctHome
            // 
            this.pctHome.BackColor = System.Drawing.Color.Transparent;
            this.pctHome.Image = global::ZestyBrain.Properties.Resources.inicio2;
            this.pctHome.Location = new System.Drawing.Point(22, 707);
            this.pctHome.Name = "pctHome";
            this.pctHome.Size = new System.Drawing.Size(175, 57);
            this.pctHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctHome.TabIndex = 47;
            this.pctHome.TabStop = false;
            // 
            // pnlRegresar
            // 
            this.pnlRegresar.BackColor = System.Drawing.Color.Transparent;
            this.pnlRegresar.BackgroundImage = global::ZestyBrain.Properties.Resources.Button_Previous_icon;
            this.pnlRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRegresar.Location = new System.Drawing.Point(932, 714);
            this.pnlRegresar.Name = "pnlRegresar";
            this.pnlRegresar.Size = new System.Drawing.Size(43, 43);
            this.pnlRegresar.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(165, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(701, 27);
            this.label1.TabIndex = 48;
            this.label1.Text = "Instrucciones: Arrastre la imagen del alimento a la clasificación correcta.";
            // 
            // FrmPruebaAnimales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZestyBrain.Properties.Resources.arregladofondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 780);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctHome);
            this.Controls.Add(this.pnlRegresar);
            this.Controls.Add(this.pctSalir);
            this.Controls.Add(this.label5);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPruebaAnimales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPruebaAnimales";
            ((System.ComponentModel.ISupportInitialize)(this.pctSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pctSalir;
        private System.Windows.Forms.PictureBox pctHome;
        private System.Windows.Forms.Panel pnlRegresar;
        private System.Windows.Forms.Label label1;
    }
}