﻿namespace ProyectoFinalOut
{
    partial class frmNoticias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNoticias));
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            textBox1 = new TextBox();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            btnCasa = new Botones();
            btnSSalir = new Botones();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(350, 7);
            label1.Name = "label1";
            label1.Size = new Size(270, 46);
            label1.TabIndex = 36;
            label1.Text = "Noticias y anuncios importantes \r\nsobre el servicio de autobuses";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(264, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(71, 61);
            pictureBox2.TabIndex = 37;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(2, -4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(64, 64);
            pictureBox3.TabIndex = 39;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 17);
            label2.Name = "label2";
            label2.Size = new Size(114, 24);
            label2.TabIndex = 38;
            label2.Text = "Transporti";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(447, 339);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(441, 135);
            textBox1.TabIndex = 40;
            textBox1.Text = resources.GetString("textBox1.Text");
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(459, 60);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(440, 247);
            pictureBox4.TabIndex = 41;
            pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(79, 268);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(341, 253);
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(46, 80);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(396, 159);
            textBox2.TabIndex = 42;
            textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // btnCasa
            // 
            btnCasa.BackColor = Color.SteelBlue;
            btnCasa.Cursor = Cursors.Hand;
            btnCasa.FlatAppearance.BorderSize = 0;
            btnCasa.FlatStyle = FlatStyle.Flat;
            btnCasa.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCasa.ForeColor = Color.Black;
            btnCasa.Image = (Image)resources.GetObject("btnCasa.Image");
            btnCasa.ImageAlign = ContentAlignment.TopCenter;
            btnCasa.Location = new Point(535, 481);
            btnCasa.Margin = new Padding(3, 4, 3, 4);
            btnCasa.Name = "btnCasa";
            btnCasa.Size = new Size(95, 103);
            btnCasa.TabIndex = 44;
            btnCasa.Text = "CASA";
            btnCasa.TextAlign = ContentAlignment.BottomCenter;
            btnCasa.UseVisualStyleBackColor = false;
            btnCasa.Click += btnCasa_Click;
            // 
            // btnSSalir
            // 
            btnSSalir.BackColor = Color.SteelBlue;
            btnSSalir.Cursor = Cursors.Hand;
            btnSSalir.FlatAppearance.BorderSize = 0;
            btnSSalir.FlatStyle = FlatStyle.Flat;
            btnSSalir.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSSalir.ForeColor = Color.Black;
            btnSSalir.Image = (Image)resources.GetObject("btnSSalir.Image");
            btnSSalir.ImageAlign = ContentAlignment.TopCenter;
            btnSSalir.Location = new Point(683, 481);
            btnSSalir.Margin = new Padding(3, 4, 3, 4);
            btnSSalir.Name = "btnSSalir";
            btnSSalir.Size = new Size(95, 103);
            btnSSalir.TabIndex = 45;
            btnSSalir.Text = "SALIR";
            btnSSalir.TextAlign = ContentAlignment.BottomCenter;
            btnSSalir.UseVisualStyleBackColor = false;
            btnSSalir.Click += btnSSalir_Click;
            // 
            // frmNoticias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 613);
            Controls.Add(btnSSalir);
            Controls.Add(btnCasa);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(pictureBox4);
            Controls.Add(textBox1);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Name = "frmNoticias";
            Text = "Noticias";
            Load += frmNoticias_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label2;
        private TextBox textBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private Botones btnCasa;
        private Botones btnSSalir;
    }
}