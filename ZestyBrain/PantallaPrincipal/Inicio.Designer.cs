namespace ZestyBrain.PantallaPrincipal
{
    partial class FrmInicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.pnlJugar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlConf = new System.Windows.Forms.Panel();
            this.pctSalirB = new System.Windows.Forms.PictureBox();
            this.pctAnimal = new System.Windows.Forms.PictureBox();
            this.pctVenado = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSalirB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAnimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVenado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("leaf1", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(242, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenidos(as)";
            // 
            // pnlJugar
            // 
            this.pnlJugar.BackColor = System.Drawing.Color.Transparent;
            this.pnlJugar.BackgroundImage = global::ZestyBrain.Properties.Resources.BotonJugar;
            this.pnlJugar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlJugar.Location = new System.Drawing.Point(328, 313);
            this.pnlJugar.Name = "pnlJugar";
            this.pnlJugar.Size = new System.Drawing.Size(317, 129);
            this.pnlJugar.TabIndex = 2;
            this.pnlJugar.Click += new System.EventHandler(this.pnlJugar_Click);
            this.pnlJugar.MouseLeave += new System.EventHandler(this.pnlJugar_MouseLeave_1);
            this.pnlJugar.MouseHover += new System.EventHandler(this.pnlJugar_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ZestyBrain.Properties.Resources.ANIMALES__RANAS___30_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(111, 390);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 189);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::ZestyBrain.Properties.Resources.direction_25871_640;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pnlConf);
            this.panel1.Location = new System.Drawing.Point(752, 479);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 115);
            this.panel1.TabIndex = 4;
            // 
            // pnlConf
            // 
            this.pnlConf.BackgroundImage = global::ZestyBrain.Properties.Resources.Configu;
            this.pnlConf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlConf.Location = new System.Drawing.Point(15, 15);
            this.pnlConf.Name = "pnlConf";
            this.pnlConf.Size = new System.Drawing.Size(180, 60);
            this.pnlConf.TabIndex = 0;
            this.pnlConf.MouseLeave += new System.EventHandler(this.pnlConf_MouseLeave);
            this.pnlConf.MouseHover += new System.EventHandler(this.pnlConf_MouseHover);
            // 
            // pctSalirB
            // 
            this.pctSalirB.BackColor = System.Drawing.Color.Transparent;
            this.pctSalirB.Image = global::ZestyBrain.Properties.Resources.button_31222_960_720;
            this.pctSalirB.Location = new System.Drawing.Point(894, 15);
            this.pctSalirB.Name = "pctSalirB";
            this.pctSalirB.Size = new System.Drawing.Size(43, 43);
            this.pctSalirB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSalirB.TabIndex = 7;
            this.pctSalirB.TabStop = false;
            this.pctSalirB.Click += new System.EventHandler(this.ptbSalirB_Click);
            this.pctSalirB.MouseLeave += new System.EventHandler(this.pctSalirB_MouseLeave);
            this.pctSalirB.MouseHover += new System.EventHandler(this.pctSalirB_MouseHover);
            // 
            // pctAnimal
            // 
            this.pctAnimal.BackColor = System.Drawing.Color.Transparent;
            this.pctAnimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctAnimal.Image = global::ZestyBrain.Properties.Resources.tigre;
            this.pctAnimal.Location = new System.Drawing.Point(178, 155);
            this.pctAnimal.Name = "pctAnimal";
            this.pctAnimal.Size = new System.Drawing.Size(188, 111);
            this.pctAnimal.TabIndex = 8;
            this.pctAnimal.TabStop = false;
            // 
            // pctVenado
            // 
            this.pctVenado.BackColor = System.Drawing.Color.Transparent;
            this.pctVenado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctVenado.Image = global::ZestyBrain.Properties.Resources.deer4;
            this.pctVenado.Location = new System.Drawing.Point(747, 119);
            this.pctVenado.Name = "pctVenado";
            this.pctVenado.Size = new System.Drawing.Size(190, 199);
            this.pctVenado.TabIndex = 9;
            this.pctVenado.TabStop = false;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ZestyBrain.Properties.Resources._67b62d4c00336a5b0bf8b73e420f992d;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(963, 591);
            this.ControlBox = false;
            this.Controls.Add(this.pctVenado);
            this.Controls.Add(this.pctAnimal);
            this.Controls.Add(this.pctSalirB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlJugar);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctSalirB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAnimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVenado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlJugar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pctSalirB;
        private System.Windows.Forms.PictureBox pctAnimal;
        private System.Windows.Forms.PictureBox pctVenado;
        private System.Windows.Forms.Panel pnlConf;
    }
}