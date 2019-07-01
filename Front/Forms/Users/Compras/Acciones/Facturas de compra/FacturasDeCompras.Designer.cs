namespace Front.Forms.Users.Compras.Acciones
{
    partial class FacturasDeCompras
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
            this.BotonFacturasDeCompras = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BotonCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gvwDetalleFC = new System.Windows.Forms.DataGridView();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.btnDetalleFC = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwDetalleFC)).BeginInit();
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
            this.Titulo.Size = new System.Drawing.Size(249, 30);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "FACTURAS DE COMPRAS";
            // 
            // BotonFacturasDeCompras
            // 
            this.BotonFacturasDeCompras.AutoSize = true;
            this.BotonFacturasDeCompras.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BotonFacturasDeCompras.Depth = 0;
            this.BotonFacturasDeCompras.Icon = null;
            this.BotonFacturasDeCompras.Location = new System.Drawing.Point(546, 482);
            this.BotonFacturasDeCompras.MouseState = MaterialSkin.MouseState.HOVER;
            this.BotonFacturasDeCompras.Name = "BotonFacturasDeCompras";
            this.BotonFacturasDeCompras.Primary = true;
            this.BotonFacturasDeCompras.Size = new System.Drawing.Size(170, 36);
            this.BotonFacturasDeCompras.TabIndex = 1;
            this.BotonFacturasDeCompras.Text = "Factura De Compras";
            this.BotonFacturasDeCompras.UseVisualStyleBackColor = true;
            this.BotonFacturasDeCompras.Click += new System.EventHandler(this.BotonFacturasDeCompras_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(67, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(649, 162);
            this.dataGridView1.TabIndex = 3;
            // 
            // gvwDetalleFC
            // 
            this.gvwDetalleFC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvwDetalleFC.Location = new System.Drawing.Point(67, 317);
            this.gvwDetalleFC.Name = "gvwDetalleFC";
            this.gvwDetalleFC.Size = new System.Drawing.Size(649, 159);
            this.gvwDetalleFC.TabIndex = 5;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(698, 82);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(18, 162);
            this.vScrollBar1.TabIndex = 4;
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(698, 317);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(18, 159);
            this.vScrollBar2.TabIndex = 6;
            // 
            // btnDetalleFC
            // 
            this.btnDetalleFC.AutoSize = true;
            this.btnDetalleFC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDetalleFC.Depth = 0;
            this.btnDetalleFC.Icon = null;
            this.btnDetalleFC.Location = new System.Drawing.Point(610, 250);
            this.btnDetalleFC.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDetalleFC.Name = "btnDetalleFC";
            this.btnDetalleFC.Primary = true;
            this.btnDetalleFC.Size = new System.Drawing.Size(106, 36);
            this.btnDetalleFC.TabIndex = 7;
            this.btnDetalleFC.Text = "VER DETALLE";
            this.btnDetalleFC.UseVisualStyleBackColor = true;
            this.btnDetalleFC.Click += new System.EventHandler(this.BtnDetalleFC_Click);
            // 
            // FacturasDeCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 557);
            this.Controls.Add(this.btnDetalleFC);
            this.Controls.Add(this.vScrollBar2);
            this.Controls.Add(this.gvwDetalleFC);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonFacturasDeCompras);
            this.Controls.Add(this.Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FacturasDeCompras";
            this.Text = "FacturasDeCompras";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwDetalleFC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private MaterialSkin.Controls.MaterialRaisedButton BotonFacturasDeCompras;
        private MaterialSkin.Controls.MaterialFlatButton BotonCancelar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView gvwDetalleFC;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private MaterialSkin.Controls.MaterialRaisedButton btnDetalleFC;
    }
}