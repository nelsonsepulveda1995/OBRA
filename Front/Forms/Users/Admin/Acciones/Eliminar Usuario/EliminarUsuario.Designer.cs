namespace Front.Forms.Users.Admin.Acciones
{
    partial class EliminarUsuario
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
            this.Boton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BotonCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.cbdesabilitar = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dgw_listahabiltados = new System.Windows.Forms.DataGridView();
            this.mlrespuesta = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_listahabiltados)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(230, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "DESABILITAR USUARIO";
            // 
            // Boton
            // 
            this.Boton.AutoSize = true;
            this.Boton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Boton.Depth = 0;
            this.Boton.Icon = null;
            this.Boton.Location = new System.Drawing.Point(546, 482);
            this.Boton.MouseState = MaterialSkin.MouseState.HOVER;
            this.Boton.Name = "Boton";
            this.Boton.Primary = true;
            this.Boton.Size = new System.Drawing.Size(166, 36);
            this.Boton.TabIndex = 1;
            this.Boton.Text = "desabilitar usuario";
            this.Boton.UseVisualStyleBackColor = true;
            this.Boton.Click += new System.EventHandler(this.Boton_Click);
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
            // cbdesabilitar
            // 
            this.cbdesabilitar.FormattingEnabled = true;
            this.cbdesabilitar.Location = new System.Drawing.Point(262, 150);
            this.cbdesabilitar.Name = "cbdesabilitar";
            this.cbdesabilitar.Size = new System.Drawing.Size(373, 21);
            this.cbdesabilitar.TabIndex = 3;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(63, 152);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(139, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Seleccione Usuario";
            // 
            // dgw_listahabiltados
            // 
            this.dgw_listahabiltados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_listahabiltados.Location = new System.Drawing.Point(262, 218);
            this.dgw_listahabiltados.Name = "dgw_listahabiltados";
            this.dgw_listahabiltados.Size = new System.Drawing.Size(373, 229);
            this.dgw_listahabiltados.TabIndex = 5;
            // 
            // mlrespuesta
            // 
            this.mlrespuesta.AutoSize = true;
            this.mlrespuesta.Depth = 0;
            this.mlrespuesta.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlrespuesta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlrespuesta.Location = new System.Drawing.Point(258, 482);
            this.mlrespuesta.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlrespuesta.Name = "mlrespuesta";
            this.mlrespuesta.Size = new System.Drawing.Size(0, 19);
            this.mlrespuesta.TabIndex = 6;
            // 
            // EliminarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 557);
            this.Controls.Add(this.mlrespuesta);
            this.Controls.Add(this.dgw_listahabiltados);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cbdesabilitar);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.Boton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EliminarUsuario";
            this.Text = "EliminarUsuario";
            this.Load += new System.EventHandler(this.EliminarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_listahabiltados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton Boton;
        private MaterialSkin.Controls.MaterialFlatButton BotonCancelar;
        private System.Windows.Forms.ComboBox cbdesabilitar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridView dgw_listahabiltados;
        private MaterialSkin.Controls.MaterialLabel mlrespuesta;
    }
}