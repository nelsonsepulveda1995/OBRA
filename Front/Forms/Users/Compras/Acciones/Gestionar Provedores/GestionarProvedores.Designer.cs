namespace Front.Forms.Users.Compras.Acciones
{
    partial class GestionarProvedores
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
            this.BotonGestionarProvedores = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BotonCancelar = new MaterialSkin.Controls.MaterialFlatButton();
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
            this.label1.Size = new System.Drawing.Size(262, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTIONAR PROVEDORES";
            // 
            // BotonGestionarProvedores
            // 
            this.BotonGestionarProvedores.AutoSize = true;
            this.BotonGestionarProvedores.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BotonGestionarProvedores.Depth = 0;
            this.BotonGestionarProvedores.Icon = null;
            this.BotonGestionarProvedores.Location = new System.Drawing.Point(529, 482);
            this.BotonGestionarProvedores.MouseState = MaterialSkin.MouseState.HOVER;
            this.BotonGestionarProvedores.Name = "BotonGestionarProvedores";
            this.BotonGestionarProvedores.Primary = true;
            this.BotonGestionarProvedores.Size = new System.Drawing.Size(185, 36);
            this.BotonGestionarProvedores.TabIndex = 1;
            this.BotonGestionarProvedores.Text = "Gestionar PROVEDORES";
            this.BotonGestionarProvedores.UseVisualStyleBackColor = true;
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
            // GestionarProvedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 557);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonGestionarProvedores);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionarProvedores";
            this.Text = "GestionarProvedores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton BotonGestionarProvedores;
        private MaterialSkin.Controls.MaterialFlatButton BotonCancelar;
    }
}