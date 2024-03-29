﻿namespace Front.Forms.Users.Deposito.Acciones
{
    partial class OrdenesDeCompras
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
            this.label1 = new System.Windows.Forms.Label();
            this.BotonCrearOrdenCompra = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ProductoLabel = new MaterialSkin.Controls.MaterialLabel();
            this.numupdow_cantidad = new System.Windows.Forms.NumericUpDown();
            this.cblistaproducto = new System.Windows.Forms.ComboBox();
            this.Agregar = new MaterialSkin.Controls.MaterialFlatButton();
            this.Vaciar = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numupdow_cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(62, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "ORDENES DE COMPRAS";
            // 
            // BotonCrearOrdenCompra
            // 
            this.BotonCrearOrdenCompra.AutoSize = true;
            this.BotonCrearOrdenCompra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BotonCrearOrdenCompra.Depth = 0;
            this.BotonCrearOrdenCompra.Icon = null;
            this.BotonCrearOrdenCompra.Location = new System.Drawing.Point(515, 482);
            this.BotonCrearOrdenCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.BotonCrearOrdenCompra.Name = "BotonCrearOrdenCompra";
            this.BotonCrearOrdenCompra.Primary = true;
            this.BotonCrearOrdenCompra.Size = new System.Drawing.Size(201, 36);
            this.BotonCrearOrdenCompra.TabIndex = 1;
            this.BotonCrearOrdenCompra.Text = "Crear Orden de Compras";
            this.BotonCrearOrdenCompra.UseVisualStyleBackColor = true;
            this.BotonCrearOrdenCompra.Click += new System.EventHandler(this.BotonCrearOrdenCompra_Click);
            // 
            // ProductoLabel
            // 
            this.ProductoLabel.AutoSize = true;
            this.ProductoLabel.Depth = 0;
            this.ProductoLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.ProductoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ProductoLabel.Location = new System.Drawing.Point(63, 149);
            this.ProductoLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProductoLabel.Name = "ProductoLabel";
            this.ProductoLabel.Size = new System.Drawing.Size(70, 19);
            this.ProductoLabel.TabIndex = 3;
            this.ProductoLabel.Text = "Producto";
            // 
            // numupdow_cantidad
            // 
            this.numupdow_cantidad.Location = new System.Drawing.Point(443, 147);
            this.numupdow_cantidad.Name = "numupdow_cantidad";
            this.numupdow_cantidad.Size = new System.Drawing.Size(64, 20);
            this.numupdow_cantidad.TabIndex = 9;
            // 
            // cblistaproducto
            // 
            this.cblistaproducto.FormattingEnabled = true;
            this.cblistaproducto.Location = new System.Drawing.Point(153, 147);
            this.cblistaproducto.Name = "cblistaproducto";
            this.cblistaproducto.Size = new System.Drawing.Size(228, 21);
            this.cblistaproducto.TabIndex = 10;
            this.cblistaproducto.SelectedIndexChanged += new System.EventHandler(this.Cblistaproducto_SelectedIndexChanged);
            // 
            // Agregar
            // 
            this.Agregar.AutoSize = true;
            this.Agregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Agregar.Depth = 0;
            this.Agregar.Icon = null;
            this.Agregar.Location = new System.Drawing.Point(549, 141);
            this.Agregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Agregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.Agregar.Name = "Agregar";
            this.Agregar.Primary = false;
            this.Agregar.Size = new System.Drawing.Size(167, 36);
            this.Agregar.TabIndex = 11;
            this.Agregar.Text = "Agregar al  Carrito";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.AgregarAlCarrito_Click);
            // 
            // Vaciar
            // 
            this.Vaciar.AutoSize = true;
            this.Vaciar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Vaciar.Depth = 0;
            this.Vaciar.Icon = null;
            this.Vaciar.Location = new System.Drawing.Point(67, 482);
            this.Vaciar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Vaciar.MouseState = MaterialSkin.MouseState.HOVER;
            this.Vaciar.Name = "Vaciar";
            this.Vaciar.Primary = false;
            this.Vaciar.Size = new System.Drawing.Size(133, 36);
            this.Vaciar.TabIndex = 12;
            this.Vaciar.Text = "Vaciar  Carrito";
            this.Vaciar.UseVisualStyleBackColor = true;
            this.Vaciar.Click += new System.EventHandler(this.VaciarCarrito_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(191, 237);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(55, 19);
            this.materialLabel1.TabIndex = 14;
            this.materialLabel1.Text = "Carrito";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(252, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(242, 214);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Producto";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cantidad";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // OrdenesDeCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 557);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.Vaciar);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.cblistaproducto);
            this.Controls.Add(this.numupdow_cantidad);
            this.Controls.Add(this.ProductoLabel);
            this.Controls.Add(this.BotonCrearOrdenCompra);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrdenesDeCompras";
            this.Text = "EliminarUsuario";
            this.Load += new System.EventHandler(this.OrdenesDeCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numupdow_cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton BotonCrearOrdenCompra;
        private MaterialSkin.Controls.MaterialLabel ProductoLabel;
        private System.Windows.Forms.NumericUpDown numupdow_cantidad;
        private System.Windows.Forms.ComboBox cblistaproducto;
        private MaterialSkin.Controls.MaterialFlatButton Agregar;
        private MaterialSkin.Controls.MaterialFlatButton Vaciar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}