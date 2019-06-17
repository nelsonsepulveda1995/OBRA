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
            this.dgProductosSinStock = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductosSinStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.BotonMostrarStock.Location = new System.Drawing.Point(136, 482);
            this.BotonMostrarStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.BotonMostrarStock.Name = "BotonMostrarStock";
            this.BotonMostrarStock.Primary = true;
            this.BotonMostrarStock.Size = new System.Drawing.Size(241, 36);
            this.BotonMostrarStock.TabIndex = 1;
            this.BotonMostrarStock.Text = "MOSTRAR PRODUCTOS SIN STOCK";
            this.BotonMostrarStock.UseVisualStyleBackColor = true;
            this.BotonMostrarStock.Click += new System.EventHandler(this.BotonMostrarStock_Click);
            // 
            // dgProductosSinStock
            // 
            this.dgProductosSinStock.AllowUserToDeleteRows = false;
            this.dgProductosSinStock.AllowUserToOrderColumns = true;
            this.dgProductosSinStock.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgProductosSinStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductosSinStock.Location = new System.Drawing.Point(136, 195);
            this.dgProductosSinStock.Name = "dgProductosSinStock";
            this.dgProductosSinStock.ReadOnly = true;
            this.dgProductosSinStock.Size = new System.Drawing.Size(242, 248);
            this.dgProductosSinStock.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(436, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(242, 248);
            this.dataGridView1.TabIndex = 5;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(497, 482);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(105, 36);
            this.materialRaisedButton1.TabIndex = 6;
            this.materialRaisedButton1.Text = "USAR FILTRO";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(432, 143);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(57, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "FILTRO";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(579, 142);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(99, 20);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ProductosSinStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 557);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dgProductosSinStock);
            this.Controls.Add(this.BotonMostrarStock);
            this.Controls.Add(this.Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductosSinStock";
            this.Text = "Productos sin stock";
            ((System.ComponentModel.ISupportInitialize)(this.dgProductosSinStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private MaterialSkin.Controls.MaterialRaisedButton BotonMostrarStock;
        private System.Windows.Forms.DataGridView dgProductosSinStock;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}