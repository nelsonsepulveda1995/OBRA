namespace Front.Forms.Users.Deposito.Acciones
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
            this.BotonOrdenarCompras = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BotonCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.numupdow_cantidad = new System.Windows.Forms.NumericUpDown();
            this.cblistaproducto = new System.Windows.Forms.ComboBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.tb_vistacarrito = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numupdow_cantidad)).BeginInit();
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
            // BotonOrdenarCompras
            // 
            this.BotonOrdenarCompras.AutoSize = true;
            this.BotonOrdenarCompras.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BotonOrdenarCompras.Depth = 0;
            this.BotonOrdenarCompras.Icon = null;
            this.BotonOrdenarCompras.Location = new System.Drawing.Point(515, 482);
            this.BotonOrdenarCompras.MouseState = MaterialSkin.MouseState.HOVER;
            this.BotonOrdenarCompras.Name = "BotonOrdenarCompras";
            this.BotonOrdenarCompras.Primary = true;
            this.BotonOrdenarCompras.Size = new System.Drawing.Size(201, 36);
            this.BotonOrdenarCompras.TabIndex = 1;
            this.BotonOrdenarCompras.Text = "Crear Orden de Compras";
            this.BotonOrdenarCompras.UseVisualStyleBackColor = true;
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.AutoSize = true;
            this.BotonCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BotonCancelar.Depth = 0;
            this.BotonCancelar.Icon = null;
            this.BotonCancelar.Location = new System.Drawing.Point(395, 482);
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
            this.materialLabel1.Location = new System.Drawing.Point(63, 149);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(70, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Producto";
            // 
            // numupdow_cantidad
            // 
            this.numupdow_cantidad.Location = new System.Drawing.Point(422, 147);
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
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(549, 141);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(167, 36);
            this.materialFlatButton1.TabIndex = 11;
            this.materialFlatButton1.Text = "Agregar al  Carrito";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.MaterialFlatButton1_Click);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Icon = null;
            this.materialFlatButton2.Location = new System.Drawing.Point(67, 482);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(133, 36);
            this.materialFlatButton2.TabIndex = 12;
            this.materialFlatButton2.Text = "Vaciar  Carrito";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.MaterialFlatButton2_Click);
            // 
            // tb_vistacarrito
            // 
            this.tb_vistacarrito.Location = new System.Drawing.Point(153, 213);
            this.tb_vistacarrito.Multiline = true;
            this.tb_vistacarrito.Name = "tb_vistacarrito";
            this.tb_vistacarrito.ReadOnly = true;
            this.tb_vistacarrito.Size = new System.Drawing.Size(358, 219);
            this.tb_vistacarrito.TabIndex = 13;
            // 
            // OrdenesDeCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 557);
            this.Controls.Add(this.tb_vistacarrito);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.cblistaproducto);
            this.Controls.Add(this.numupdow_cantidad);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonOrdenarCompras);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrdenesDeCompras";
            this.Text = "EliminarUsuario";
            this.Load += new System.EventHandler(this.OrdenesDeCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numupdow_cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton BotonOrdenarCompras;
        private MaterialSkin.Controls.MaterialFlatButton BotonCancelar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.NumericUpDown numupdow_cantidad;
        private System.Windows.Forms.ComboBox cblistaproducto;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private System.Windows.Forms.TextBox tb_vistacarrito;
    }
}