namespace Front.Forms.Users.Compras.Acciones
{
    partial class ListaDeProductos
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
            this.BotonListaDeProductos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dglistaproductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dglistaproductos)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(224, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTA DE PRODUCTOS";
            // 
            // BotonListaDeProductos
            // 
            this.BotonListaDeProductos.AutoSize = true;
            this.BotonListaDeProductos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BotonListaDeProductos.Depth = 0;
            this.BotonListaDeProductos.Icon = null;
            this.BotonListaDeProductos.Location = new System.Drawing.Point(580, 474);
            this.BotonListaDeProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.BotonListaDeProductos.Name = "BotonListaDeProductos";
            this.BotonListaDeProductos.Primary = true;
            this.BotonListaDeProductos.Size = new System.Drawing.Size(150, 36);
            this.BotonListaDeProductos.TabIndex = 1;
            this.BotonListaDeProductos.Text = "LISTAR PRODUCTOS";
            this.BotonListaDeProductos.UseVisualStyleBackColor = true;
            // 
            // dglistaproductos
            // 
            this.dglistaproductos.AllowUserToDeleteRows = false;
            this.dglistaproductos.AllowUserToOrderColumns = true;
            this.dglistaproductos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dglistaproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dglistaproductos.Location = new System.Drawing.Point(144, 131);
            this.dglistaproductos.Name = "dglistaproductos";
            this.dglistaproductos.ReadOnly = true;
            this.dglistaproductos.Size = new System.Drawing.Size(499, 282);
            this.dglistaproductos.TabIndex = 3;
            this.dglistaproductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // ListaDeProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 557);
            this.Controls.Add(this.dglistaproductos);
            this.Controls.Add(this.BotonListaDeProductos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaDeProductos";
            this.Text = "EliminarUsuario";
            this.Load += new System.EventHandler(this.ListaDeProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dglistaproductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton BotonListaDeProductos;
        private System.Windows.Forms.DataGridView dglistaproductos;
    }
}