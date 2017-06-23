namespace ZestyBrain
{
    partial class FrmPortada
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
            this.components = new System.ComponentModel.Container();
            this.pgbBarra = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcbOpciones = new System.Windows.Forms.PictureBox();
            this.pcbPlay = new System.Windows.Forms.PictureBox();
            this.pcbSalir = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOpciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // pgbBarra
            // 
            this.pgbBarra.Location = new System.Drawing.Point(287, 565);
            this.pgbBarra.Name = "pgbBarra";
            this.pgbBarra.Size = new System.Drawing.Size(284, 14);
            this.pgbBarra.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pcbOpciones);
            this.panel1.Location = new System.Drawing.Point(622, 488);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 4;
            // 
            // pcbOpciones
            // 
            this.pcbOpciones.Image = global::ZestyBrain.Properties.Resources.engranaje_md;
            this.pcbOpciones.Location = new System.Drawing.Point(112, 22);
            this.pcbOpciones.Name = "pcbOpciones";
            this.pcbOpciones.Size = new System.Drawing.Size(75, 75);
            this.pcbOpciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbOpciones.TabIndex = 0;
            this.pcbOpciones.TabStop = false;
            this.pcbOpciones.Click += new System.EventHandler(this.pcbOpciones_Click);
            this.pcbOpciones.MouseLeave += new System.EventHandler(this.pcbOpciones_MouseLeave);
            this.pcbOpciones.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // pcbPlay
            // 
            this.pcbPlay.BackColor = System.Drawing.Color.Transparent;
            this.pcbPlay.Image = global::ZestyBrain.Properties.Resources.bp;
            this.pcbPlay.Location = new System.Drawing.Point(377, 538);
            this.pcbPlay.Name = "pcbPlay";
            this.pcbPlay.Size = new System.Drawing.Size(100, 50);
            this.pcbPlay.TabIndex = 5;
            this.pcbPlay.TabStop = false;
            this.pcbPlay.Click += new System.EventHandler(this.pcbPlay_Click);
            // 
            // pcbSalir
            // 
            this.pcbSalir.BackColor = System.Drawing.Color.Transparent;
            this.pcbSalir.Image = global::ZestyBrain.Properties.Resources.button_31222_960_720;
            this.pcbSalir.Location = new System.Drawing.Point(772, 1);
            this.pcbSalir.Name = "pcbSalir";
            this.pcbSalir.Size = new System.Drawing.Size(50, 50);
            this.pcbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSalir.TabIndex = 6;
            this.pcbSalir.TabStop = false;
            this.pcbSalir.Click += new System.EventHandler(this.pcbSalir_Click);
            this.pcbSalir.MouseLeave += new System.EventHandler(this.pcbSalir_MouseLeave);
            this.pcbSalir.MouseHover += new System.EventHandler(this.pcbSalir_MouseHover);
            // 
            // FrmPortada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZestyBrain.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(834, 591);
            this.Controls.Add(this.pcbSalir);
            this.Controls.Add(this.pcbPlay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pgbBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPortada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbOpciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar pgbBarra;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcbPlay;
        private System.Windows.Forms.PictureBox pcbOpciones;
        private System.Windows.Forms.PictureBox pcbSalir;
    }
}

