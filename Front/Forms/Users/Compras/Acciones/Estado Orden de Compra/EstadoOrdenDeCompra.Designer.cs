namespace Front.Forms.Users.Compras.Acciones
{
    partial class EstadoOrdenDeCompra
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
            this.BotonConsultarEstado = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BotonCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.mlrespuesta = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.label1.Size = new System.Drawing.Size(315, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESTADO ORDENES DE COMPRA";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // BotonConsultarEstado
            // 
            this.BotonConsultarEstado.AutoSize = true;
            this.BotonConsultarEstado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BotonConsultarEstado.Depth = 0;
            this.BotonConsultarEstado.Icon = null;
            this.BotonConsultarEstado.Location = new System.Drawing.Point(529, 482);
            this.BotonConsultarEstado.MouseState = MaterialSkin.MouseState.HOVER;
            this.BotonConsultarEstado.Name = "BotonConsultarEstado";
            this.BotonConsultarEstado.Primary = true;
            this.BotonConsultarEstado.Size = new System.Drawing.Size(155, 36);
            this.BotonConsultarEstado.TabIndex = 1;
            this.BotonConsultarEstado.Text = "Consultar Estado";
            this.BotonConsultarEstado.UseVisualStyleBackColor = true;
            this.BotonConsultarEstado.Click += new System.EventHandler(this.BotonGestionarProvedores_Click);
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.AutoSize = true;
            this.BotonCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BotonCancelar.Depth = 0;
            this.BotonCancelar.Icon = null;
            this.BotonCancelar.Location = new System.Drawing.Point(418, 482);
            this.BotonCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BotonCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Primary = false;
            this.BotonCancelar.Size = new System.Drawing.Size(91, 36);
            this.BotonCancelar.TabIndex = 2;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            // 
            // mlrespuesta
            // 
            this.mlrespuesta.AutoSize = true;
            this.mlrespuesta.Depth = 0;
            this.mlrespuesta.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlrespuesta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlrespuesta.Location = new System.Drawing.Point(264, 400);
            this.mlrespuesta.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlrespuesta.Name = "mlrespuesta";
            this.mlrespuesta.Size = new System.Drawing.Size(0, 19);
            this.mlrespuesta.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(108, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(576, 327);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // EstadoOrdenDeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 557);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mlrespuesta);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonConsultarEstado);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EstadoOrdenDeCompra";
            this.Text = "GestionarProvedores";
            this.Load += new System.EventHandler(this.GestionarProvedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton BotonConsultarEstado;
        private MaterialSkin.Controls.MaterialFlatButton BotonCancelar;
        private MaterialSkin.Controls.MaterialLabel mlrespuesta;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}