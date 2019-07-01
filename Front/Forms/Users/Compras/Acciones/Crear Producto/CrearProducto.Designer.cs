namespace Front.Forms.Users.Compras.Acciones
{
    partial class CrearProducto
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
            this.btnCrearPrducto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BotonCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.sl_descripcion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.nud_catidad = new System.Windows.Forms.NumericUpDown();
            this.tb_precio = new System.Windows.Forms.TextBox();
            this.ML_RESPUESTA = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nud_catidad)).BeginInit();
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
            this.Titulo.Size = new System.Drawing.Size(193, 30);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "CREAR PRODUCTO";
            // 
            // btnCrearPrducto
            // 
            this.btnCrearPrducto.AutoSize = true;
            this.btnCrearPrducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCrearPrducto.Depth = 0;
            this.btnCrearPrducto.Icon = null;
            this.btnCrearPrducto.Location = new System.Drawing.Point(546, 482);
            this.btnCrearPrducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCrearPrducto.Name = "btnCrearPrducto";
            this.btnCrearPrducto.Primary = true;
            this.btnCrearPrducto.Size = new System.Drawing.Size(139, 36);
            this.btnCrearPrducto.TabIndex = 1;
            this.btnCrearPrducto.Text = "Crear pRODUCTO";
            this.btnCrearPrducto.UseVisualStyleBackColor = true;
            this.btnCrearPrducto.Click += new System.EventHandler(this.btnCrearPrducto_Click);
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
            // sl_descripcion
            // 
            this.sl_descripcion.Depth = 0;
            this.sl_descripcion.Hint = "";
            this.sl_descripcion.Location = new System.Drawing.Point(298, 148);
            this.sl_descripcion.MaxLength = 32767;
            this.sl_descripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.sl_descripcion.Name = "sl_descripcion";
            this.sl_descripcion.PasswordChar = '\0';
            this.sl_descripcion.SelectedText = "";
            this.sl_descripcion.SelectionLength = 0;
            this.sl_descripcion.SelectionStart = 0;
            this.sl_descripcion.Size = new System.Drawing.Size(275, 23);
            this.sl_descripcion.TabIndex = 3;
            this.sl_descripcion.TabStop = false;
            this.sl_descripcion.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(126, 152);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(148, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Nombre de Producto";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(126, 206);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(52, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Precio";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(126, 265);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(68, 19);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Cantidad";
            // 
            // nud_catidad
            // 
            this.nud_catidad.Location = new System.Drawing.Point(298, 264);
            this.nud_catidad.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nud_catidad.Name = "nud_catidad";
            this.nud_catidad.Size = new System.Drawing.Size(105, 20);
            this.nud_catidad.TabIndex = 9;
            this.nud_catidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_precio
            // 
            this.tb_precio.Location = new System.Drawing.Point(298, 205);
            this.tb_precio.Name = "tb_precio";
            this.tb_precio.Size = new System.Drawing.Size(122, 20);
            this.tb_precio.TabIndex = 10;
            // 
            // ML_RESPUESTA
            // 
            this.ML_RESPUESTA.AutoSize = true;
            this.ML_RESPUESTA.Depth = 0;
            this.ML_RESPUESTA.Font = new System.Drawing.Font("Roboto", 11F);
            this.ML_RESPUESTA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ML_RESPUESTA.Location = new System.Drawing.Point(294, 420);
            this.ML_RESPUESTA.MouseState = MaterialSkin.MouseState.HOVER;
            this.ML_RESPUESTA.Name = "ML_RESPUESTA";
            this.ML_RESPUESTA.Size = new System.Drawing.Size(0, 19);
            this.ML_RESPUESTA.TabIndex = 11;
            // 
            // CrearProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 557);
            this.Controls.Add(this.ML_RESPUESTA);
            this.Controls.Add(this.tb_precio);
            this.Controls.Add(this.nud_catidad);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.sl_descripcion);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.btnCrearPrducto);
            this.Controls.Add(this.Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearProducto";
            this.Text = "FacturasDeCompras";
            this.Load += new System.EventHandler(this.CrearProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_catidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private MaterialSkin.Controls.MaterialRaisedButton btnCrearPrducto;
        private MaterialSkin.Controls.MaterialFlatButton BotonCancelar;
        private MaterialSkin.Controls.MaterialSingleLineTextField sl_descripcion;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.NumericUpDown nud_catidad;
        private System.Windows.Forms.TextBox tb_precio;
        private MaterialSkin.Controls.MaterialLabel ML_RESPUESTA;
    }
}