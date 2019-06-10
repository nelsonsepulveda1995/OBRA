namespace Front.Forms.Users.Deposito.Acciones
{
    partial class ProductosSinStock
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
            this.BotonMostrarStock = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BotonCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.dgProductosSinStock = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductosSinStock)).BeginInit();
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
            this.Titulo.Size = new System.Drawing.Size(242, 30);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "PRODUCTOS SIN STOCK";
            // 
            // BotonMostrarStock
            // 
            this.BotonMostrarStock.AutoSize = true;
            this.BotonMostrarStock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BotonMostrarStock.Depth = 0;
            this.BotonMostrarStock.Icon = null;
            this.BotonMostrarStock.Location = new System.Drawing.Point(546, 482);
            this.BotonMostrarStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.BotonMostrarStock.Name = "BotonMostrarStock";
            this.BotonMostrarStock.Primary = true;
            this.BotonMostrarStock.Size = new System.Drawing.Size(132, 36);
            this.BotonMostrarStock.TabIndex = 1;
            this.BotonMostrarStock.Text = "MOSTRAR STOCK";
            this.BotonMostrarStock.UseVisualStyleBackColor = true;
            this.BotonMostrarStock.Click += new System.EventHandler(this.BotonMostrarStock_Click);
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
            // dgProductosSinStock
            // 
            this.dgProductosSinStock.AllowUserToDeleteRows = false;
            this.dgProductosSinStock.AllowUserToOrderColumns = true;
            this.dgProductosSinStock.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgProductosSinStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductosSinStock.Location = new System.Drawing.Point(113, 143);
            this.dgProductosSinStock.Name = "dgProductosSinStock";
            this.dgProductosSinStock.ReadOnly = true;
            this.dgProductosSinStock.Size = new System.Drawing.Size(496, 252);
            this.dgProductosSinStock.TabIndex = 4;
            // 
            // ProductosSinStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 557);
            this.Controls.Add(this.dgProductosSinStock);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonMostrarStock);
            this.Controls.Add(this.Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductosSinStock";
            this.Text = "Productos sin stock";
            ((System.ComponentModel.ISupportInitialize)(this.dgProductosSinStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private MaterialSkin.Controls.MaterialRaisedButton BotonMostrarStock;
        private MaterialSkin.Controls.MaterialFlatButton BotonCancelar;
        private System.Windows.Forms.DataGridView dgProductosSinStock;
    }
}