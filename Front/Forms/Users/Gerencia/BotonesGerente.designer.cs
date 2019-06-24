namespace Front.Forms.Users.Gerencia
{
    partial class BotonesGerente
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
            this.BotonReporteDeCompras = new MaterialSkin.Controls.MaterialFlatButton();
            this.BotonReporteDeVentas = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // BotonReporteDeCompras
            // 
            this.BotonReporteDeCompras.AutoSize = true;
            this.BotonReporteDeCompras.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BotonReporteDeCompras.Depth = 0;
            this.BotonReporteDeCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.BotonReporteDeCompras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonReporteDeCompras.Icon = null;
            this.BotonReporteDeCompras.Location = new System.Drawing.Point(0, 36);
            this.BotonReporteDeCompras.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BotonReporteDeCompras.MouseState = MaterialSkin.MouseState.HOVER;
            this.BotonReporteDeCompras.Name = "BotonReporteDeCompras";
            this.BotonReporteDeCompras.Primary = false;
            this.BotonReporteDeCompras.Size = new System.Drawing.Size(184, 36);
            this.BotonReporteDeCompras.TabIndex = 15;
            this.BotonReporteDeCompras.Text = "Producto mas Vendido";
            this.BotonReporteDeCompras.UseVisualStyleBackColor = true;
            this.BotonReporteDeCompras.Click += new System.EventHandler(this.BotonReporteDeCompras_Click);
            // 
            // BotonReporteDeVentas
            // 
            this.BotonReporteDeVentas.AutoSize = true;
            this.BotonReporteDeVentas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BotonReporteDeVentas.Depth = 0;
            this.BotonReporteDeVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BotonReporteDeVentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonReporteDeVentas.Icon = null;
            this.BotonReporteDeVentas.Location = new System.Drawing.Point(0, 0);
            this.BotonReporteDeVentas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BotonReporteDeVentas.MouseState = MaterialSkin.MouseState.HOVER;
            this.BotonReporteDeVentas.Name = "BotonReporteDeVentas";
            this.BotonReporteDeVentas.Primary = false;
            this.BotonReporteDeVentas.Size = new System.Drawing.Size(184, 36);
            this.BotonReporteDeVentas.TabIndex = 14;
            this.BotonReporteDeVentas.Text = "Ventas por usuario";
            this.BotonReporteDeVentas.UseVisualStyleBackColor = true;
            this.BotonReporteDeVentas.Click += new System.EventHandler(this.BotonReporteDeVentas_Click);
            // 
            // BotonesGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(184, 521);
            this.Controls.Add(this.BotonReporteDeCompras);
            this.Controls.Add(this.BotonReporteDeVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BotonesGerente";
            this.Text = "Gerente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton BotonReporteDeCompras;
        private MaterialSkin.Controls.MaterialFlatButton BotonReporteDeVentas;
    }
}