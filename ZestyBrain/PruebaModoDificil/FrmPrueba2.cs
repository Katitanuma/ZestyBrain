﻿using System;
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
    public partial class FrmPrueba2 : Form
    {
        

        int nota,pr;
        public FrmPrueba2()
        {
            InitializeComponent();
        }

        private void pctSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.ExitThread();
        }

        private void pctSalir_MouseLeave(object sender, EventArgs e)
        {
            pctSalir.Size = new Size(43, 43);
        }

        private void pctSalir_MouseHover(object sender, EventArgs e)
        {
            pctSalir.Size = new Size(47, 47);
        }

        

        private void lblVerificar_MouseHover(object sender, EventArgs e)
        {
            pnlVerificar.Size = new Size(320, 57);
        }

        private void lblVerificar_MouseLeave(object sender, EventArgs e)
        {
            pnlVerificar.Size = new Size(315, 52);
        }

        private void pnlRegresar_Click(object sender, EventArgs e)
        {
            FrmLeccionTiposdeReproducion objRepro = new FrmLeccionTiposdeReproducion();
            objRepro.Show();
            this.Visible = false;
        }

        private void pctHome_Click(object sender, EventArgs e)
        {
            PantallaPrincipal.FrmInicio objInicio = new PantallaPrincipal.FrmInicio();
            objInicio.Show();
            this.Visible = false;
        }

        public void Evaluar()
        {
            nota = int.Parse(label8.Text);
            pr = int.Parse(label9.Text);
            if (rdbGyFR.Checked == true)
            {
                nota += 1;
            }
            
            if (rdbPR.Checked == true)
            {
                nota += 1;
            }
            

            if (rdbPlantasyAlgas.Checked == true)
            {
                nota += 1;
            }
            
                        
        }
               

        private void lblVerificar_Click(object sender, EventArgs e)
        {
            

            Evaluar();


            txtPreguntasR.Text = "8";
            txtRespuestasC.Text = nota.ToString();
            txtRespustasI.Text = (8 - nota).ToString();
            txtPuntuacion.Text = (nota * 5)+"/40".ToString();

        }
    }
}
