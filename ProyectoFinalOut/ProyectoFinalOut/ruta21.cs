﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalOut
{
    public partial class frmRuta21 : Form
    {
        public frmRuta21()
        {
            InitializeComponent();
            Size = new Size(940, 660);
            StartPosition = FormStartPosition.CenterScreen;

            MaximizeBox = false; // Deshabilitar el botón de maximizar
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmRuta21_Load(object sender, EventArgs e)
        {

        }

        private void btnRecomendaciones_Click(object sender, EventArgs e)
        {
            frmForoRecomendaciones fr = new frmForoRecomendaciones();
            this.Hide();
            fr.ShowDialog(); //Muestro formulario
        }

        private void btnCasa_Click_1(object sender, EventArgs e)
        {
            Ventana2 vt2 = new Ventana2();
            this.Hide();
            vt2.ShowDialog();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Transportes2 tp2 = new Transportes2();
            this.Hide();
            tp2.ShowDialog();
        }

        private void btnSSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
