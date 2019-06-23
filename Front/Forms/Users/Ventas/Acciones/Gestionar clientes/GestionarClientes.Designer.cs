namespace Front.Forms.Users.Ventas.Acciones
{
    partial class GestionarClientes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarClientes));
            this.Titulo = new System.Windows.Forms.Label();
            this.BotonRegistrarCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BotonCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.LabelDNI = new MaterialSkin.Controls.MaterialLabel();
            this.CajaTextoDNI = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LabelCorreo = new MaterialSkin.Controls.MaterialLabel();
            this.LabelCP = new MaterialSkin.Controls.MaterialLabel();
            this.LabelNombre = new MaterialSkin.Controls.MaterialLabel();
            this.LabelDireccion = new MaterialSkin.Controls.MaterialLabel();
            this.CajaTextoDireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CajaTextoNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CajaTextoCP = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CajaTextoCorreo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LabelTelefono = new MaterialSkin.Controls.MaterialLabel();
            this.CajaTextoTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Warning = new MaterialSkin.Controls.MaterialLabel();
            this.ControlDeError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ControlDeError)).BeginInit();
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
            this.Titulo.Size = new System.Drawing.Size(220, 30);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "GESTIONAR CLIENTES";
            // 
            // BotonRegistrarCliente
            // 
            this.BotonRegistrarCliente.AutoSize = true;
            this.BotonRegistrarCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BotonRegistrarCliente.Depth = 0;
            this.BotonRegistrarCliente.Icon = null;
            this.BotonRegistrarCliente.Location = new System.Drawing.Point(546, 482);
            this.BotonRegistrarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.BotonRegistrarCliente.Name = "BotonRegistrarCliente";
            this.BotonRegistrarCliente.Primary = true;
            this.BotonRegistrarCliente.Size = new System.Drawing.Size(151, 36);
            this.BotonRegistrarCliente.TabIndex = 1;
            this.BotonRegistrarCliente.Text = "Registrar cliente";
            this.BotonRegistrarCliente.UseVisualStyleBackColor = true;
            this.BotonRegistrarCliente.Click += new System.EventHandler(this.RegistrarCliente_Click);
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
            // LabelDNI
            // 
            this.LabelDNI.AutoSize = true;
            this.LabelDNI.Depth = 0;
            this.LabelDNI.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelDNI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelDNI.Location = new System.Drawing.Point(73, 131);
            this.LabelDNI.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelDNI.Name = "LabelDNI";
            this.LabelDNI.Size = new System.Drawing.Size(34, 19);
            this.LabelDNI.TabIndex = 3;
            this.LabelDNI.Text = "DNI";
            // 
            // CajaTextoDNI
            // 
            this.CajaTextoDNI.Depth = 0;
            this.CajaTextoDNI.Hint = "";
            this.CajaTextoDNI.Location = new System.Drawing.Point(237, 127);
            this.CajaTextoDNI.MaxLength = 32767;
            this.CajaTextoDNI.MouseState = MaterialSkin.MouseState.HOVER;
            this.CajaTextoDNI.Name = "CajaTextoDNI";
            this.CajaTextoDNI.PasswordChar = '\0';
            this.CajaTextoDNI.SelectedText = "";
            this.CajaTextoDNI.SelectionLength = 0;
            this.CajaTextoDNI.SelectionStart = 0;
            this.CajaTextoDNI.Size = new System.Drawing.Size(154, 23);
            this.CajaTextoDNI.TabIndex = 1;
            this.CajaTextoDNI.TabStop = false;
            this.CajaTextoDNI.UseSystemPasswordChar = false;
            // 
            // LabelCorreo
            // 
            this.LabelCorreo.AutoSize = true;
            this.LabelCorreo.Depth = 0;
            this.LabelCorreo.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelCorreo.Location = new System.Drawing.Point(73, 393);
            this.LabelCorreo.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelCorreo.Name = "LabelCorreo";
            this.LabelCorreo.Size = new System.Drawing.Size(136, 19);
            this.LabelCorreo.TabIndex = 5;
            this.LabelCorreo.Text = "Correo Electronico";
            // 
            // LabelCP
            // 
            this.LabelCP.AutoSize = true;
            this.LabelCP.Depth = 0;
            this.LabelCP.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelCP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelCP.Location = new System.Drawing.Point(73, 279);
            this.LabelCP.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelCP.Name = "LabelCP";
            this.LabelCP.Size = new System.Drawing.Size(28, 19);
            this.LabelCP.TabIndex = 6;
            this.LabelCP.Text = "CP";
            // 
            // LabelNombre
            // 
            this.LabelNombre.AutoSize = true;
            this.LabelNombre.Depth = 0;
            this.LabelNombre.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelNombre.Location = new System.Drawing.Point(73, 177);
            this.LabelNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(63, 19);
            this.LabelNombre.TabIndex = 7;
            this.LabelNombre.Text = "Nombre";
            // 
            // LabelDireccion
            // 
            this.LabelDireccion.AutoSize = true;
            this.LabelDireccion.Depth = 0;
            this.LabelDireccion.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelDireccion.Location = new System.Drawing.Point(73, 227);
            this.LabelDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelDireccion.Name = "LabelDireccion";
            this.LabelDireccion.Size = new System.Drawing.Size(73, 19);
            this.LabelDireccion.TabIndex = 8;
            this.LabelDireccion.Text = "Direccion";
            // 
            // CajaTextoDireccion
            // 
            this.CajaTextoDireccion.Depth = 0;
            this.CajaTextoDireccion.Hint = "";
            this.CajaTextoDireccion.Location = new System.Drawing.Point(237, 223);
            this.CajaTextoDireccion.MaxLength = 32767;
            this.CajaTextoDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.CajaTextoDireccion.Name = "CajaTextoDireccion";
            this.CajaTextoDireccion.PasswordChar = '\0';
            this.CajaTextoDireccion.SelectedText = "";
            this.CajaTextoDireccion.SelectionLength = 0;
            this.CajaTextoDireccion.SelectionStart = 0;
            this.CajaTextoDireccion.Size = new System.Drawing.Size(246, 23);
            this.CajaTextoDireccion.TabIndex = 3;
            this.CajaTextoDireccion.TabStop = false;
            this.CajaTextoDireccion.UseSystemPasswordChar = false;
            // 
            // CajaTextoNombre
            // 
            this.CajaTextoNombre.Depth = 0;
            this.CajaTextoNombre.Hint = "";
            this.CajaTextoNombre.Location = new System.Drawing.Point(237, 173);
            this.CajaTextoNombre.MaxLength = 32767;
            this.CajaTextoNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.CajaTextoNombre.Name = "CajaTextoNombre";
            this.CajaTextoNombre.PasswordChar = '\0';
            this.CajaTextoNombre.SelectedText = "";
            this.CajaTextoNombre.SelectionLength = 0;
            this.CajaTextoNombre.SelectionStart = 0;
            this.CajaTextoNombre.Size = new System.Drawing.Size(214, 23);
            this.CajaTextoNombre.TabIndex = 2;
            this.CajaTextoNombre.TabStop = false;
            this.CajaTextoNombre.UseSystemPasswordChar = false;
            // 
            // CajaTextoCP
            // 
            this.CajaTextoCP.Depth = 0;
            this.CajaTextoCP.Hint = "";
            this.CajaTextoCP.Location = new System.Drawing.Point(237, 275);
            this.CajaTextoCP.MaxLength = 32767;
            this.CajaTextoCP.MouseState = MaterialSkin.MouseState.HOVER;
            this.CajaTextoCP.Name = "CajaTextoCP";
            this.CajaTextoCP.PasswordChar = '\0';
            this.CajaTextoCP.SelectedText = "";
            this.CajaTextoCP.SelectionLength = 0;
            this.CajaTextoCP.SelectionStart = 0;
            this.CajaTextoCP.Size = new System.Drawing.Size(72, 23);
            this.CajaTextoCP.TabIndex = 4;
            this.CajaTextoCP.TabStop = false;
            this.CajaTextoCP.UseSystemPasswordChar = false;
            // 
            // CajaTextoCorreo
            // 
            this.CajaTextoCorreo.Depth = 0;
            this.CajaTextoCorreo.Hint = "";
            this.CajaTextoCorreo.Location = new System.Drawing.Point(237, 389);
            this.CajaTextoCorreo.MaxLength = 32767;
            this.CajaTextoCorreo.MouseState = MaterialSkin.MouseState.HOVER;
            this.CajaTextoCorreo.Name = "CajaTextoCorreo";
            this.CajaTextoCorreo.PasswordChar = '\0';
            this.CajaTextoCorreo.SelectedText = "";
            this.CajaTextoCorreo.SelectionLength = 0;
            this.CajaTextoCorreo.SelectionStart = 0;
            this.CajaTextoCorreo.Size = new System.Drawing.Size(246, 23);
            this.CajaTextoCorreo.TabIndex = 6;
            this.CajaTextoCorreo.TabStop = false;
            this.CajaTextoCorreo.UseSystemPasswordChar = false;
            // 
            // LabelTelefono
            // 
            this.LabelTelefono.AutoSize = true;
            this.LabelTelefono.Depth = 0;
            this.LabelTelefono.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelTelefono.Location = new System.Drawing.Point(73, 337);
            this.LabelTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelTelefono.Name = "LabelTelefono";
            this.LabelTelefono.Size = new System.Drawing.Size(69, 19);
            this.LabelTelefono.TabIndex = 13;
            this.LabelTelefono.Text = "Telefono";
            // 
            // CajaTextoTelefono
            // 
            this.CajaTextoTelefono.Depth = 0;
            this.CajaTextoTelefono.Hint = "";
            this.CajaTextoTelefono.Location = new System.Drawing.Point(237, 333);
            this.CajaTextoTelefono.MaxLength = 32767;
            this.CajaTextoTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.CajaTextoTelefono.Name = "CajaTextoTelefono";
            this.CajaTextoTelefono.PasswordChar = '\0';
            this.CajaTextoTelefono.SelectedText = "";
            this.CajaTextoTelefono.SelectionLength = 0;
            this.CajaTextoTelefono.SelectionStart = 0;
            this.CajaTextoTelefono.Size = new System.Drawing.Size(154, 23);
            this.CajaTextoTelefono.TabIndex = 5;
            this.CajaTextoTelefono.TabStop = false;
            this.CajaTextoTelefono.UseSystemPasswordChar = false;
            // 
            // Warning
            // 
            this.Warning.AutoSize = true;
            this.Warning.Depth = 0;
            this.Warning.Font = new System.Drawing.Font("Roboto", 11F);
            this.Warning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Warning.Location = new System.Drawing.Point(195, 482);
            this.Warning.MouseState = MaterialSkin.MouseState.HOVER;
            this.Warning.Name = "Warning";
            this.Warning.Size = new System.Drawing.Size(0, 19);
            this.Warning.TabIndex = 15;
            // 
            // ControlDeError
            // 
            this.ControlDeError.ContainerControl = this;
            this.ControlDeError.Icon = ((System.Drawing.Icon)(resources.GetObject("ControlDeError.Icon")));
            // 
            // GestionarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 557);
            this.Controls.Add(this.Warning);
            this.Controls.Add(this.CajaTextoTelefono);
            this.Controls.Add(this.LabelTelefono);
            this.Controls.Add(this.CajaTextoCorreo);
            this.Controls.Add(this.CajaTextoCP);
            this.Controls.Add(this.CajaTextoNombre);
            this.Controls.Add(this.CajaTextoDireccion);
            this.Controls.Add(this.LabelDireccion);
            this.Controls.Add(this.LabelNombre);
            this.Controls.Add(this.LabelCP);
            this.Controls.Add(this.LabelCorreo);
            this.Controls.Add(this.CajaTextoDNI);
            this.Controls.Add(this.LabelDNI);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonRegistrarCliente);
            this.Controls.Add(this.Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionarClientes";
            this.Text = "Facturas de ventas";
            ((System.ComponentModel.ISupportInitialize)(this.ControlDeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private MaterialSkin.Controls.MaterialRaisedButton BotonRegistrarCliente;
        private MaterialSkin.Controls.MaterialFlatButton BotonCancelar;
        private MaterialSkin.Controls.MaterialLabel LabelDNI;
        private MaterialSkin.Controls.MaterialSingleLineTextField CajaTextoDNI;
        private MaterialSkin.Controls.MaterialLabel LabelCorreo;
        private MaterialSkin.Controls.MaterialLabel LabelCP;
        private MaterialSkin.Controls.MaterialLabel LabelNombre;
        private MaterialSkin.Controls.MaterialLabel LabelDireccion;
        private MaterialSkin.Controls.MaterialSingleLineTextField CajaTextoDireccion;
        private MaterialSkin.Controls.MaterialSingleLineTextField CajaTextoNombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField CajaTextoCP;
        private MaterialSkin.Controls.MaterialSingleLineTextField CajaTextoCorreo;
        private MaterialSkin.Controls.MaterialLabel LabelTelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField CajaTextoTelefono;
        private MaterialSkin.Controls.MaterialLabel Warning;
        private System.Windows.Forms.ErrorProvider ControlDeError;
    }
}