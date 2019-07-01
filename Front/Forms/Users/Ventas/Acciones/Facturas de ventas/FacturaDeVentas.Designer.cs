namespace Front.Forms.Users.Ventas.Acciones
{
    partial class FacturasDeVentas
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
            this.BotonFacturaDeVentas = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BotonCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gvwDetalleFV = new System.Windows.Forms.DataGridView();
            this.btnVerDetalleFV = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwDetalleFV)).BeginInit();
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
            this.Titulo.Size = new System.Drawing.Size(227, 30);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "FACTURAS DE VENTAS";
            // 
            // BotonFacturaDeVentas
            // 
            this.BotonFacturaDeVentas.AutoSize = true;
            this.BotonFacturaDeVentas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BotonFacturaDeVentas.Depth = 0;
            this.BotonFacturaDeVentas.Icon = null;
            this.BotonFacturaDeVentas.Location = new System.Drawing.Point(546, 482);
            this.BotonFacturaDeVentas.MouseState = MaterialSkin.MouseState.HOVER;
            this.BotonFacturaDeVentas.Name = "BotonFacturaDeVentas";
            this.BotonFacturaDeVentas.Primary = true;
            this.BotonFacturaDeVentas.Size = new System.Drawing.Size(157, 36);
            this.BotonFacturaDeVentas.TabIndex = 1;
            this.BotonFacturaDeVentas.Text = "FACTURA DE VENTAS";
            this.BotonFacturaDeVentas.UseVisualStyleBackColor = true;
            this.BotonFacturaDeVentas.Click += new System.EventHandler(this.BotonFacturaDeVentas_Click);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(636, 145);
            this.dataGridView1.TabIndex = 3;
            // 
            // gvwDetalleFV
            // 
            this.gvwDetalleFV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvwDetalleFV.Location = new System.Drawing.Point(67, 328);
            this.gvwDetalleFV.Name = "gvwDetalleFV";
            this.gvwDetalleFV.Size = new System.Drawing.Size(636, 145);
            this.gvwDetalleFV.TabIndex = 4;
            // 
            // btnVerDetalleFV
            // 
            this.btnVerDetalleFV.AutoSize = true;
            this.btnVerDetalleFV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVerDetalleFV.Depth = 0;
            this.btnVerDetalleFV.Icon = null;
            this.btnVerDetalleFV.Location = new System.Drawing.Point(597, 263);
            this.btnVerDetalleFV.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVerDetalleFV.Name = "btnVerDetalleFV";
            this.btnVerDetalleFV.Primary = true;
            this.btnVerDetalleFV.Size = new System.Drawing.Size(106, 36);
            this.btnVerDetalleFV.TabIndex = 5;
            this.btnVerDetalleFV.Text = "VER DETALLE";
            this.btnVerDetalleFV.UseVisualStyleBackColor = true;
            this.btnVerDetalleFV.Click += new System.EventHandler(this.BtnVerDetalleFV_Click);
            // 
            // FacturasDeVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 557);
            this.Controls.Add(this.btnVerDetalleFV);
            this.Controls.Add(this.gvwDetalleFV);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonFacturaDeVentas);
            this.Controls.Add(this.Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FacturasDeVentas";
            this.Text = "Facturas de ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwDetalleFV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private MaterialSkin.Controls.MaterialRaisedButton BotonFacturaDeVentas;
        private MaterialSkin.Controls.MaterialFlatButton BotonCancelar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView gvwDetalleFV;
        private MaterialSkin.Controls.MaterialRaisedButton btnVerDetalleFV;
    }
}