
namespace Temas
{
    partial class frmTemas
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
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAzul = new System.Windows.Forms.Button();
            this.BtnRojo = new System.Windows.Forms.Button();
            this.BtnNaranja = new System.Windows.Forms.Button();
            this.btnVerde = new System.Windows.Forms.Button();
            this.BtnGris = new System.Windows.Forms.Button();
            this.btnRosa = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.pnlPadre = new System.Windows.Forms.Panel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.lbl = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tick_hora = new System.Windows.Forms.Timer(this.components);
            this.pnlLateral.SuspendLayout();
            this.pnlPadre.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            this.pnlSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(48)))), ((int)(((byte)(199)))));
            this.pnlLateral.Controls.Add(this.label4);
            this.pnlLateral.Controls.Add(this.btnAzul);
            this.pnlLateral.Controls.Add(this.BtnRojo);
            this.pnlLateral.Controls.Add(this.BtnNaranja);
            this.pnlLateral.Controls.Add(this.btnVerde);
            this.pnlLateral.Controls.Add(this.BtnGris);
            this.pnlLateral.Controls.Add(this.btnRosa);
            this.pnlLateral.Controls.Add(this.btnDefault);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 59);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(220, 474);
            this.pnlLateral.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tema:";
            // 
            // btnAzul
            // 
            this.btnAzul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAzul.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAzul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAzul.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzul.ForeColor = System.Drawing.Color.White;
            this.btnAzul.Location = new System.Drawing.Point(12, 81);
            this.btnAzul.Name = "btnAzul";
            this.btnAzul.Size = new System.Drawing.Size(164, 31);
            this.btnAzul.TabIndex = 6;
            this.btnAzul.Text = "Azul";
            this.btnAzul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAzul.UseVisualStyleBackColor = true;
            this.btnAzul.Click += new System.EventHandler(this.ColorTema);
            // 
            // BtnRojo
            // 
            this.BtnRojo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRojo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnRojo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRojo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRojo.ForeColor = System.Drawing.Color.White;
            this.BtnRojo.Location = new System.Drawing.Point(12, 118);
            this.BtnRojo.Name = "BtnRojo";
            this.BtnRojo.Size = new System.Drawing.Size(164, 31);
            this.BtnRojo.TabIndex = 5;
            this.BtnRojo.Text = "Rojo";
            this.BtnRojo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRojo.UseVisualStyleBackColor = true;
            this.BtnRojo.Click += new System.EventHandler(this.ColorTema);
            // 
            // BtnNaranja
            // 
            this.BtnNaranja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNaranja.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnNaranja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNaranja.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNaranja.ForeColor = System.Drawing.Color.White;
            this.BtnNaranja.Location = new System.Drawing.Point(12, 155);
            this.BtnNaranja.Name = "BtnNaranja";
            this.BtnNaranja.Size = new System.Drawing.Size(164, 31);
            this.BtnNaranja.TabIndex = 4;
            this.BtnNaranja.Text = "Naranja";
            this.BtnNaranja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNaranja.UseVisualStyleBackColor = true;
            this.BtnNaranja.Click += new System.EventHandler(this.ColorTema);
            // 
            // btnVerde
            // 
            this.btnVerde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerde.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVerde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerde.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerde.ForeColor = System.Drawing.Color.White;
            this.btnVerde.Location = new System.Drawing.Point(12, 267);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(164, 31);
            this.btnVerde.TabIndex = 3;
            this.btnVerde.Text = "Verde";
            this.btnVerde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerde.UseVisualStyleBackColor = true;
            this.btnVerde.Click += new System.EventHandler(this.ColorTema);
            // 
            // BtnGris
            // 
            this.BtnGris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGris.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnGris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGris.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGris.ForeColor = System.Drawing.Color.White;
            this.BtnGris.Location = new System.Drawing.Point(12, 229);
            this.BtnGris.Name = "BtnGris";
            this.BtnGris.Size = new System.Drawing.Size(164, 32);
            this.BtnGris.TabIndex = 2;
            this.BtnGris.Text = "Gris";
            this.BtnGris.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGris.UseVisualStyleBackColor = true;
            this.BtnGris.Click += new System.EventHandler(this.ColorTema);
            // 
            // btnRosa
            // 
            this.btnRosa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRosa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRosa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRosa.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRosa.ForeColor = System.Drawing.Color.White;
            this.btnRosa.Location = new System.Drawing.Point(12, 192);
            this.btnRosa.Name = "btnRosa";
            this.btnRosa.Size = new System.Drawing.Size(164, 31);
            this.btnRosa.TabIndex = 1;
            this.btnRosa.Text = "Rosa";
            this.btnRosa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRosa.UseVisualStyleBackColor = true;
            this.btnRosa.Click += new System.EventHandler(this.ColorTema);
            // 
            // btnDefault
            // 
            this.btnDefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDefault.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefault.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefault.ForeColor = System.Drawing.Color.White;
            this.btnDefault.Location = new System.Drawing.Point(12, 44);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(164, 31);
            this.btnDefault.TabIndex = 0;
            this.btnDefault.Text = "Default";
            this.btnDefault.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.ColorTema);
            // 
            // pnlPadre
            // 
            this.pnlPadre.Controls.Add(this.pnlContenedor);
            this.pnlPadre.Controls.Add(this.pnlLateral);
            this.pnlPadre.Controls.Add(this.pnlSuperior);
            this.pnlPadre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPadre.Location = new System.Drawing.Point(0, 0);
            this.pnlPadre.Name = "pnlPadre";
            this.pnlPadre.Size = new System.Drawing.Size(974, 533);
            this.pnlPadre.TabIndex = 1;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.pnlContenedor.Controls.Add(this.lbl);
            this.pnlContenedor.Controls.Add(this.lblHora);
            this.pnlContenedor.Controls.Add(this.lblFecha);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(220, 59);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(754, 474);
            this.pnlContenedor.TabIndex = 2;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Comic Sans MS", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(251)))));
            this.lbl.Location = new System.Drawing.Point(157, 211);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(118, 49);
            this.lbl.TabIndex = 4;
            this.lbl.Text = "Hora:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Comic Sans MS", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(251)))));
            this.lblHora.Location = new System.Drawing.Point(344, 212);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(103, 49);
            this.lblHora.TabIndex = 3;
            this.lblHora.Text = "Hora";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Comic Sans MS", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(251)))));
            this.lblFecha.Location = new System.Drawing.Point(140, 138);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(120, 49);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(29)))), ((int)(((byte)(122)))));
            this.pnlSuperior.Controls.Add(this.label2);
            this.pnlSuperior.Controls.Add(this.label1);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(974, 59);
            this.pnlSuperior.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bryan Gonzalez";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(304, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programa para practicar el color en los temas.";
            // 
            // tick_hora
            // 
            this.tick_hora.Enabled = true;
            this.tick_hora.Interval = 500;
            this.tick_hora.Tick += new System.EventHandler(this.tick_hora_Tick);
            // 
            // frmTemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 533);
            this.Controls.Add(this.pnlPadre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTemas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmTemas_Load);
            this.pnlLateral.ResumeLayout(false);
            this.pnlLateral.PerformLayout();
            this.pnlPadre.ResumeLayout(false);
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.Button btnAzul;
        private System.Windows.Forms.Button BtnRojo;
        private System.Windows.Forms.Button BtnNaranja;
        private System.Windows.Forms.Button btnVerde;
        private System.Windows.Forms.Button BtnGris;
        private System.Windows.Forms.Button btnRosa;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Panel pnlPadre;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tick_hora;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label4;
    }
}

