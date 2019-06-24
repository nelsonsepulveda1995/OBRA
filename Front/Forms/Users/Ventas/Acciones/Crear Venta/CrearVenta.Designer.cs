namespace Front.Forms.Users.Ventas.Acciones
{
    partial class CrearVenta
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
            this.BotonConfirmar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BotonCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cbclientes = new System.Windows.Forms.ComboBox();
            this.cbproducto = new System.Windows.Forms.ComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.cbmediodepago = new System.Windows.Forms.ComboBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agregar = new MaterialSkin.Controls.MaterialFlatButton();
            this.numupdow_cantidad = new System.Windows.Forms.NumericUpDown();
            this.Vaciar = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupdow_cantidad)).BeginInit();
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
            this.Titulo.Size = new System.Drawing.Size(148, 30);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "CREAR VENTA";
            // 
            // BotonConfirmar
            // 
            this.BotonConfirmar.AutoSize = true;
            this.BotonConfirmar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BotonConfirmar.Depth = 0;
            this.BotonConfirmar.Icon = null;
            this.BotonConfirmar.Location = new System.Drawing.Point(632, 479);
            this.BotonConfirmar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BotonConfirmar.Name = "BotonConfirmar";
            this.BotonConfirmar.Primary = true;
            this.BotonConfirmar.Size = new System.Drawing.Size(146, 36);
            this.BotonConfirmar.TabIndex = 1;
            this.BotonConfirmar.Text = "Confirmar Venta";
            this.BotonConfirmar.UseVisualStyleBackColor = true;
            this.BotonConfirmar.Click += new System.EventHandler(this.BotonConfirmar_Click);
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.AutoSize = true;
            this.BotonCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BotonCancelar.Depth = 0;
            this.BotonCancelar.Icon = null;
            this.BotonCancelar.Location = new System.Drawing.Point(521, 479);
            this.BotonCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BotonCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Primary = false;
            this.BotonCancelar.Size = new System.Drawing.Size(91, 36);
            this.BotonCancelar.TabIndex = 2;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(105, 146);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(56, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Cliente";
            // 
            // cbclientes
            // 
            this.cbclientes.FormattingEnabled = true;
            this.cbclientes.Location = new System.Drawing.Point(265, 144);
            this.cbclientes.Name = "cbclientes";
            this.cbclientes.Size = new System.Drawing.Size(161, 21);
            this.cbclientes.TabIndex = 5;
            // 
            // cbproducto
            // 
            this.cbproducto.FormattingEnabled = true;
            this.cbproducto.Location = new System.Drawing.Point(265, 269);
            this.cbproducto.Name = "cbproducto";
            this.cbproducto.Size = new System.Drawing.Size(162, 21);
            this.cbproducto.TabIndex = 6;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(106, 343);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(68, 19);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Cantidad";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(106, 271);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(70, 19);
            this.materialLabel3.TabIndex = 9;
            this.materialLabel3.Text = "Producto";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(521, 116);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(55, 19);
            this.materialLabel4.TabIndex = 11;
            this.materialLabel4.Text = "Carrito";
            // 
            // cbmediodepago
            // 
            this.cbmediodepago.FormattingEnabled = true;
            this.cbmediodepago.Location = new System.Drawing.Point(264, 195);
            this.cbmediodepago.Name = "cbmediodepago";
            this.cbmediodepago.Size = new System.Drawing.Size(162, 21);
            this.cbmediodepago.TabIndex = 12;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(105, 194);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(108, 19);
            this.materialLabel5.TabIndex = 13;
            this.materialLabel5.Text = "Medio de pago";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(525, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(242, 285);
            this.dataGridView1.TabIndex = 16;
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
            // Agregar
            // 
            this.Agregar.AutoSize = true;
            this.Agregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Agregar.Depth = 0;
            this.Agregar.Icon = null;
            this.Agregar.Location = new System.Drawing.Point(259, 395);
            this.Agregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Agregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.Agregar.Name = "Agregar";
            this.Agregar.Primary = false;
            this.Agregar.Size = new System.Drawing.Size(167, 36);
            this.Agregar.TabIndex = 17;
            this.Agregar.Text = "Agregar al  Carrito";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // numupdow_cantidad
            // 
            this.numupdow_cantidad.Location = new System.Drawing.Point(265, 342);
            this.numupdow_cantidad.Name = "numupdow_cantidad";
            this.numupdow_cantidad.Size = new System.Drawing.Size(161, 20);
            this.numupdow_cantidad.TabIndex = 18;
            // 
            // Vaciar
            // 
            this.Vaciar.AutoSize = true;
            this.Vaciar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Vaciar.Depth = 0;
            this.Vaciar.Icon = null;
            this.Vaciar.Location = new System.Drawing.Point(118, 395);
            this.Vaciar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Vaciar.MouseState = MaterialSkin.MouseState.HOVER;
            this.Vaciar.Name = "Vaciar";
            this.Vaciar.Primary = false;
            this.Vaciar.Size = new System.Drawing.Size(133, 36);
            this.Vaciar.TabIndex = 19;
            this.Vaciar.Text = "Vaciar  Carrito";
            this.Vaciar.UseVisualStyleBackColor = true;
            this.Vaciar.Click += new System.EventHandler(this.Vaciar_Click);
            // 
            // CrearVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 557);
            this.Controls.Add(this.Vaciar);
            this.Controls.Add(this.numupdow_cantidad);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.cbmediodepago);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.cbproducto);
            this.Controls.Add(this.cbclientes);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonConfirmar);
            this.Controls.Add(this.Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearVenta";
            this.Text = " ";
            this.Load += new System.EventHandler(this.CrearVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupdow_cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private MaterialSkin.Controls.MaterialRaisedButton BotonConfirmar;
        private MaterialSkin.Controls.MaterialFlatButton BotonCancelar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ComboBox cbclientes;
        private System.Windows.Forms.ComboBox cbproducto;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.ComboBox cbmediodepago;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private MaterialSkin.Controls.MaterialFlatButton Agregar;
        private System.Windows.Forms.NumericUpDown numupdow_cantidad;
        private MaterialSkin.Controls.MaterialFlatButton Vaciar;
    }
}