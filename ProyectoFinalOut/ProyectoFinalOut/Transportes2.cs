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
    public partial class Transportes2 : Form
    {
        public Transportes2()
        {
            InitializeComponent();
            Size = new Size(940, 660);
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false; // Deshabilitar el botón de maximizar
            FormBorderStyle = FormBorderStyle.FixedSingle; // Establecer el borde del formulario a un tamaño fijo
        }

        private void Transportes2_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = $"¡Hola {Usuario.Nombre}, elige el numero de la ruta \n del que quiera informarse!";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            frmTutransporti tp3 = new frmTutransporti();
            this.Hide();
            tp3.ShowDialog(); //Muestro formulario
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ventana2 vt2 = new Ventana2();
            this.Hide();
            vt2.ShowDialog(); //Muestro formulario
        }

        private void btnRuta8_Click(object sender, EventArgs e)
        {
            frmRuta8 rt8 = new frmRuta8();
            this.Hide();
            rt8.ShowDialog(); //Muestro formulario
        }

        private void btbRuta14_Click(object sender, EventArgs e)
        {
            frmRurta14 rt14 = new frmRurta14();
            this.Hide();
            rt14.ShowDialog(); //Muestro formulario
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRuta21 rt21 = new frmRuta21();
            this.Hide();
            rt21.ShowDialog(); //Muestro formulario

        }
    }
}
