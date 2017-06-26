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
            this.pnlBorde = new System.Windows.Forms.Panel();
            this.pnlBorde.SuspendLayout();
            this.SuspendLayout();
            // 
            // pgbBarra
            // 
            this.pgbBarra.BackColor = System.Drawing.Color.Black;
            this.pgbBarra.Location = new System.Drawing.Point(2, 2);
            this.pgbBarra.Name = "pgbBarra";
            this.pgbBarra.Size = new System.Drawing.Size(306, 22);
            this.pgbBarra.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // pnlBorde
            // 
            this.pnlBorde.BackColor = System.Drawing.Color.Lime;
            this.pnlBorde.Controls.Add(this.pgbBarra);
            this.pnlBorde.Location = new System.Drawing.Point(273, 538);
            this.pnlBorde.Name = "pnlBorde";
            this.pnlBorde.Size = new System.Drawing.Size(310, 26);
            this.pnlBorde.TabIndex = 7;
            // 
            // FrmPortada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZestyBrain.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(834, 591);
            this.Controls.Add(this.pnlBorde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPortada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlBorde.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar pgbBarra;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlBorde;
    }
}

