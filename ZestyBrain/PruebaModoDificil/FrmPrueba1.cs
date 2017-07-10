using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZestyBrain
{
    public partial class FrmPrueba1 : Form
    {

        int nota=0,pr=0;

        public FrmPrueba1()
        {
            InitializeComponent();
        }

        private void lblVerificar_Click(object sender, EventArgs e)
        {
         
            Evaluar();
           
            FrmPrueba2 objPrueba2 = new FrmPrueba2();
            objPrueba2.Show();
            objPrueba2.label8.Text = nota.ToString();
            objPrueba2.label9.Text = pr.ToString();
            this.Visible = false;

        }

        private void lblVerificar_MouseHover(object sender, EventArgs e)
        {
            pnlVerificar.Size = new Size(170, 57);
        }

        private void lblVerificar_MouseLeave(object sender, EventArgs e)
        {
            pnlVerificar.Size = new Size(165, 52);
        }

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

        public void Evaluar()
        {
            if(rdbRM.Checked==true)
            {
                nota += 1;
            }
            

            if(rdbRinoceronte.Checked==true)
            {
                nota += 1;
            }
            

            if (rdbSexual.Checked==true)
            {
                nota += 1;
            }
           

            if (chkIndustriales.Checked==true && chkComerciales.Checked==true)
            {
                nota += 1;
            }
           

            if (chkPañales.Checked==true)
            {
                nota += 1;
            }
            
           
        
        
        }
    }
}
