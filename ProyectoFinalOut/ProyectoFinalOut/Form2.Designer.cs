﻿namespace ProyectoFinalOut
{
    partial class frmTutransporti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTutransporti));
            lblBienvenida = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            btnRuta1 = new Botones();
            btnRuta6 = new Botones();
            btnRuta10 = new Botones();
            btnRuta7 = new Botones();
            btnCasa = new Botones();
            btnSiguiente = new Botones();
            btnSSalir = new Botones();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.Location = new Point(105, 49);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(249, 34);
            lblBienvenida.TabIndex = 1;
            lblBienvenida.Text = " ¡Hola, elige el numero del autobus \r\ndel que quieres informarte!";
            lblBienvenida.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(522, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(285, 466);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(248, 0);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 46);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(122, 14);
            label3.Name = "label3";
            label3.Size = new Size(115, 19);
            label3.TabIndex = 15;
            label3.Text = "TuTransporti";
            // 
            // btnRuta1
            // 
            btnRuta1.BackColor = Color.MediumSlateBlue;
            btnRuta1.Cursor = Cursors.Hand;
            btnRuta1.FlatAppearance.BorderSize = 0;
            btnRuta1.FlatStyle = FlatStyle.Flat;
            btnRuta1.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRuta1.ForeColor = Color.Gold;
            btnRuta1.Image = (Image)resources.GetObject("btnRuta1.Image");
            btnRuta1.ImageAlign = ContentAlignment.TopCenter;
            btnRuta1.Location = new Point(69, 104);
            btnRuta1.Name = "btnRuta1";
            btnRuta1.Size = new Size(150, 83);
            btnRuta1.TabIndex = 18;
            btnRuta1.Text = "RUTA 1";
            btnRuta1.TextAlign = ContentAlignment.BottomCenter;
            btnRuta1.UseVisualStyleBackColor = false;
            btnRuta1.Click += btnRuta1_Click_1;
            // 
            // btnRuta6
            // 
            btnRuta6.BackColor = Color.MediumSlateBlue;
            btnRuta6.Cursor = Cursors.Hand;
            btnRuta6.FlatAppearance.BorderSize = 0;
            btnRuta6.FlatStyle = FlatStyle.Flat;
            btnRuta6.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRuta6.ForeColor = Color.Gold;
            btnRuta6.Image = (Image)resources.GetObject("btnRuta6.Image");
            btnRuta6.ImageAlign = ContentAlignment.TopCenter;
            btnRuta6.Location = new Point(248, 104);
            btnRuta6.Name = "btnRuta6";
            btnRuta6.Size = new Size(150, 83);
            btnRuta6.TabIndex = 19;
            btnRuta6.Text = "RUTA 6";
            btnRuta6.TextAlign = ContentAlignment.BottomCenter;
            btnRuta6.UseVisualStyleBackColor = false;
            btnRuta6.Click += btnRuta6_Click;
            // 
            // btnRuta10
            // 
            btnRuta10.BackColor = Color.MediumSlateBlue;
            btnRuta10.Cursor = Cursors.Hand;
            btnRuta10.FlatAppearance.BorderSize = 0;
            btnRuta10.FlatStyle = FlatStyle.Flat;
            btnRuta10.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRuta10.ForeColor = Color.Gold;
            btnRuta10.Image = (Image)resources.GetObject("btnRuta10.Image");
            btnRuta10.ImageAlign = ContentAlignment.TopCenter;
            btnRuta10.Location = new Point(69, 210);
            btnRuta10.Name = "btnRuta10";
            btnRuta10.Size = new Size(150, 83);
            btnRuta10.TabIndex = 20;
            btnRuta10.Text = "RUTA 10";
            btnRuta10.TextAlign = ContentAlignment.BottomCenter;
            btnRuta10.UseVisualStyleBackColor = false;
            btnRuta10.Click += btnRuta10_Click;
            // 
            // btnRuta7
            // 
            btnRuta7.BackColor = Color.MediumSlateBlue;
            btnRuta7.Cursor = Cursors.Hand;
            btnRuta7.FlatAppearance.BorderSize = 0;
            btnRuta7.FlatStyle = FlatStyle.Flat;
            btnRuta7.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRuta7.ForeColor = Color.Gold;
            btnRuta7.Image = (Image)resources.GetObject("btnRuta7.Image");
            btnRuta7.ImageAlign = ContentAlignment.TopCenter;
            btnRuta7.Location = new Point(248, 210);
            btnRuta7.Name = "btnRuta7";
            btnRuta7.Size = new Size(150, 83);
            btnRuta7.TabIndex = 21;
            btnRuta7.Text = "RUTA 7";
            btnRuta7.TextAlign = ContentAlignment.BottomCenter;
            btnRuta7.UseVisualStyleBackColor = false;
            btnRuta7.Click += btnRuta7_Click;
            // 
            // btnCasa
            // 
            btnCasa.BackColor = Color.MediumSlateBlue;
            btnCasa.Cursor = Cursors.Hand;
            btnCasa.FlatAppearance.BorderSize = 0;
            btnCasa.FlatStyle = FlatStyle.Flat;
            btnCasa.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCasa.ForeColor = Color.Black;
            btnCasa.Image = (Image)resources.GetObject("btnCasa.Image");
            btnCasa.ImageAlign = ContentAlignment.TopCenter;
            btnCasa.Location = new Point(12, 331);
            btnCasa.Name = "btnCasa";
            btnCasa.Size = new Size(150, 94);
            btnCasa.TabIndex = 22;
            btnCasa.Text = "CASA";
            btnCasa.TextAlign = ContentAlignment.BottomCenter;
            btnCasa.UseVisualStyleBackColor = false;
            btnCasa.Click += btnCasa_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.MediumSlateBlue;
            btnSiguiente.Cursor = Cursors.Hand;
            btnSiguiente.FlatAppearance.BorderSize = 0;
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSiguiente.ForeColor = Color.Black;
            btnSiguiente.Image = (Image)resources.GetObject("btnSiguiente.Image");
            btnSiguiente.ImageAlign = ContentAlignment.TopCenter;
            btnSiguiente.Location = new Point(186, 331);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(150, 94);
            btnSiguiente.TabIndex = 23;
            btnSiguiente.Text = "SIGUIENTE";
            btnSiguiente.TextAlign = ContentAlignment.BottomCenter;
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click_1;
            // 
            // btnSSalir
            // 
            btnSSalir.BackColor = Color.MediumSlateBlue;
            btnSSalir.Cursor = Cursors.Hand;
            btnSSalir.FlatAppearance.BorderSize = 0;
            btnSSalir.FlatStyle = FlatStyle.Flat;
            btnSSalir.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSSalir.ForeColor = Color.Black;
            btnSSalir.Image = (Image)resources.GetObject("btnSSalir.Image");
            btnSSalir.ImageAlign = ContentAlignment.TopCenter;
            btnSSalir.Location = new Point(356, 331);
            btnSSalir.Name = "btnSSalir";
            btnSSalir.Size = new Size(150, 94);
            btnSSalir.TabIndex = 24;
            btnSSalir.Text = "SALIR";
            btnSSalir.TextAlign = ContentAlignment.BottomCenter;
            btnSSalir.UseVisualStyleBackColor = false;
            btnSSalir.Click += btnSSalir_Click;
            // 
            // frmTutransporti
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 460);
            Controls.Add(btnSSalir);
            Controls.Add(btnSiguiente);
            Controls.Add(btnCasa);
            Controls.Add(btnRuta7);
            Controls.Add(btnRuta10);
            Controls.Add(btnRuta6);
            Controls.Add(btnRuta1);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(lblBienvenida);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmTutransporti";
            Text = "TuTransporti";
            Load += frmTutransporti_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblBienvenida;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private Botones btnRuta1;
        private Botones btnRuta6;
        private Botones btnRuta10;
        private Botones btnRuta7;
        private Botones btnCasa;
        private Botones btnSiguiente;
        private Botones btnSSalir;
    }
}