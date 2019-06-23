﻿namespace Front.Forms.Users.Gerencia.Acciones
{
    partial class ReporteDeCompras
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
            this.Titulo = new System.Windows.Forms.Label();
            this.BotonReporteDeCompras = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BotonCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Titulo.Location = new System.Drawing.Point(62, 49);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(236, 30);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "REPORTE DE COMPRAS";
            // 
            // BotonReporteDeCompras
            // 
            this.BotonReporteDeCompras.AutoSize = true;
            this.BotonReporteDeCompras.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BotonReporteDeCompras.Depth = 0;
            this.BotonReporteDeCompras.Icon = null;
            this.BotonReporteDeCompras.Location = new System.Drawing.Point(546, 482);
            this.BotonReporteDeCompras.MouseState = MaterialSkin.MouseState.HOVER;
            this.BotonReporteDeCompras.Name = "BotonReporteDeCompras";
            this.BotonReporteDeCompras.Primary = true;
            this.BotonReporteDeCompras.Size = new System.Drawing.Size(145, 36);
            this.BotonReporteDeCompras.TabIndex = 1;
            this.BotonReporteDeCompras.Text = "Generar reporte";
            this.BotonReporteDeCompras.UseVisualStyleBackColor = true;
            this.BotonReporteDeCompras.Click += new System.EventHandler(this.BotonReporteDeCompras_Click);
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.AutoSize = true;
            this.BotonCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BotonCancelar.Depth = 0;
            this.BotonCancelar.Icon = null;
            this.BotonCancelar.Location = new System.Drawing.Point(435, 482);
            this.BotonCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BotonCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Primary = false;
            this.BotonCancelar.Size = new System.Drawing.Size(91, 36);
            this.BotonCancelar.TabIndex = 2;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            // 
            // ReporteDeCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 557);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonReporteDeCompras);
            this.Controls.Add(this.Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReporteDeCompras";
            this.Text = "Reporte de compras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private MaterialSkin.Controls.MaterialRaisedButton BotonReporteDeCompras;
        private MaterialSkin.Controls.MaterialFlatButton BotonCancelar;
    }
}