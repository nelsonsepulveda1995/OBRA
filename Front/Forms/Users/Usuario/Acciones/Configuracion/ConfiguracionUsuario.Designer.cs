namespace Front.Forms.Users.Usuario.Acciones
{
    partial class ConfiguracionUsuario
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
            this.BotonGuardarCambios = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BotonCancelar = new MaterialSkin.Controls.MaterialFlatButton();
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
            this.Titulo.Size = new System.Drawing.Size(306, 30);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "CONFIGURACION DE USUARIO";
            // 
            // BotonGuardarCambios
            // 
            this.BotonGuardarCambios.AutoSize = true;
            this.BotonGuardarCambios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BotonGuardarCambios.Depth = 0;
            this.BotonGuardarCambios.Icon = null;
            this.BotonGuardarCambios.Location = new System.Drawing.Point(546, 482);
            this.BotonGuardarCambios.MouseState = MaterialSkin.MouseState.HOVER;
            this.BotonGuardarCambios.Name = "BotonGuardarCambios";
            this.BotonGuardarCambios.Primary = true;
            this.BotonGuardarCambios.Size = new System.Drawing.Size(147, 36);
            this.BotonGuardarCambios.TabIndex = 1;
            this.BotonGuardarCambios.Text = "Guardar cambios";
            this.BotonGuardarCambios.UseVisualStyleBackColor = true;
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
            // ConfiguracionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 557);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonGuardarCambios);
            this.Controls.Add(this.Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfiguracionUsuario";
            this.Text = "Configuracion Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private MaterialSkin.Controls.MaterialRaisedButton BotonGuardarCambios;
        private MaterialSkin.Controls.MaterialFlatButton BotonCancelar;
    }
}