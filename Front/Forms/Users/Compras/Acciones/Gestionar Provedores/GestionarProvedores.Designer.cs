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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.mlcuit = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.mlnombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mldireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mltelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mlcorreo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mlrespuesta = new MaterialSkin.Controls.MaterialLabel();
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
            this.label1.Size = new System.Drawing.Size(214, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "CREAR PROVEDORES";
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
            this.BotonGestionarProvedores.Size = new System.Drawing.Size(138, 36);
            this.BotonGestionarProvedores.TabIndex = 1;
            this.BotonGestionarProvedores.Text = "CREAR PROVEDOR";
            this.BotonGestionarProvedores.UseVisualStyleBackColor = true;
            this.BotonGestionarProvedores.Click += new System.EventHandler(this.BotonGestionarProvedores_Click);
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
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(102, 123);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(42, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "CUIT";
            // 
            // mlcuit
            // 
            this.mlcuit.Depth = 0;
            this.mlcuit.Hint = "";
            this.mlcuit.Location = new System.Drawing.Point(344, 123);
            this.mlcuit.MaxLength = 32767;
            this.mlcuit.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlcuit.Name = "mlcuit";
            this.mlcuit.PasswordChar = '\0';
            this.mlcuit.SelectedText = "";
            this.mlcuit.SelectionLength = 0;
            this.mlcuit.SelectionStart = 0;
            this.mlcuit.Size = new System.Drawing.Size(250, 23);
            this.mlcuit.TabIndex = 4;
            this.mlcuit.TabStop = false;
            this.mlcuit.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(102, 169);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(63, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Nombre";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(102, 219);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(73, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Direccion";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(102, 266);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(69, 19);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Telefono";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(102, 315);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(136, 19);
            this.materialLabel5.TabIndex = 8;
            this.materialLabel5.Text = "Correo Electronico";
            // 
            // mlnombre
            // 
            this.mlnombre.Depth = 0;
            this.mlnombre.Hint = "";
            this.mlnombre.Location = new System.Drawing.Point(344, 169);
            this.mlnombre.MaxLength = 32767;
            this.mlnombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlnombre.Name = "mlnombre";
            this.mlnombre.PasswordChar = '\0';
            this.mlnombre.SelectedText = "";
            this.mlnombre.SelectionLength = 0;
            this.mlnombre.SelectionStart = 0;
            this.mlnombre.Size = new System.Drawing.Size(250, 23);
            this.mlnombre.TabIndex = 10;
            this.mlnombre.TabStop = false;
            this.mlnombre.UseSystemPasswordChar = false;
            // 
            // mldireccion
            // 
            this.mldireccion.Depth = 0;
            this.mldireccion.Hint = "";
            this.mldireccion.Location = new System.Drawing.Point(344, 215);
            this.mldireccion.MaxLength = 32767;
            this.mldireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.mldireccion.Name = "mldireccion";
            this.mldireccion.PasswordChar = '\0';
            this.mldireccion.SelectedText = "";
            this.mldireccion.SelectionLength = 0;
            this.mldireccion.SelectionStart = 0;
            this.mldireccion.Size = new System.Drawing.Size(250, 23);
            this.mldireccion.TabIndex = 11;
            this.mldireccion.TabStop = false;
            this.mldireccion.UseSystemPasswordChar = false;
            // 
            // mltelefono
            // 
            this.mltelefono.Depth = 0;
            this.mltelefono.Hint = "";
            this.mltelefono.Location = new System.Drawing.Point(344, 262);
            this.mltelefono.MaxLength = 32767;
            this.mltelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.mltelefono.Name = "mltelefono";
            this.mltelefono.PasswordChar = '\0';
            this.mltelefono.SelectedText = "";
            this.mltelefono.SelectionLength = 0;
            this.mltelefono.SelectionStart = 0;
            this.mltelefono.Size = new System.Drawing.Size(250, 23);
            this.mltelefono.TabIndex = 12;
            this.mltelefono.TabStop = false;
            this.mltelefono.UseSystemPasswordChar = false;
            // 
            // mlcorreo
            // 
            this.mlcorreo.Depth = 0;
            this.mlcorreo.Hint = "";
            this.mlcorreo.Location = new System.Drawing.Point(344, 311);
            this.mlcorreo.MaxLength = 32767;
            this.mlcorreo.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlcorreo.Name = "mlcorreo";
            this.mlcorreo.PasswordChar = '\0';
            this.mlcorreo.SelectedText = "";
            this.mlcorreo.SelectionLength = 0;
            this.mlcorreo.SelectionStart = 0;
            this.mlcorreo.Size = new System.Drawing.Size(250, 23);
            this.mlcorreo.TabIndex = 13;
            this.mlcorreo.TabStop = false;
            this.mlcorreo.UseSystemPasswordChar = false;
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
            // GestionarProvedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 557);
            this.Controls.Add(this.mlrespuesta);
            this.Controls.Add(this.mlcorreo);
            this.Controls.Add(this.mltelefono);
            this.Controls.Add(this.mldireccion);
            this.Controls.Add(this.mlnombre);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.mlcuit);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonGestionarProvedores);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionarProvedores";
            this.Text = "GestionarProvedores";
            this.Load += new System.EventHandler(this.GestionarProvedores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton BotonGestionarProvedores;
        private MaterialSkin.Controls.MaterialFlatButton BotonCancelar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField mlcuit;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField mlnombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField mldireccion;
        private MaterialSkin.Controls.MaterialSingleLineTextField mltelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField mlcorreo;
        private MaterialSkin.Controls.MaterialLabel mlrespuesta;
    }
}