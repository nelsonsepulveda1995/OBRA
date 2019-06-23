namespace Front.Forms.Users.Admin.Acciones
{
    partial class ModificarUsuario
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
            this.gvwListaUsuarios = new System.Windows.Forms.DataGridView();
            this.apellidoIngresado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.apellido = new MaterialSkin.Controls.MaterialLabel();
            this.nombre = new MaterialSkin.Controls.MaterialLabel();
            this.nombreIngresado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cboxPuntoV = new System.Windows.Forms.ComboBox();
            this.materialLabelEmpresa = new MaterialSkin.Controls.MaterialLabel();
            this.TipoSeleccionado = new System.Windows.Forms.ComboBox();
            this.tipo = new MaterialSkin.Controls.MaterialLabel();
            this.btnCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnModificar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gvwListaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // gvwListaUsuarios
            // 
            this.gvwListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvwListaUsuarios.Location = new System.Drawing.Point(51, 72);
            this.gvwListaUsuarios.Name = "gvwListaUsuarios";
            this.gvwListaUsuarios.Size = new System.Drawing.Size(405, 426);
            this.gvwListaUsuarios.TabIndex = 2;
            // 
            // apellidoIngresado
            // 
            this.apellidoIngresado.Depth = 0;
            this.apellidoIngresado.Hint = "";
            this.apellidoIngresado.Location = new System.Drawing.Point(605, 106);
            this.apellidoIngresado.MaxLength = 32767;
            this.apellidoIngresado.MouseState = MaterialSkin.MouseState.HOVER;
            this.apellidoIngresado.Name = "apellidoIngresado";
            this.apellidoIngresado.PasswordChar = '\0';
            this.apellidoIngresado.SelectedText = "";
            this.apellidoIngresado.SelectionLength = 0;
            this.apellidoIngresado.SelectionStart = 0;
            this.apellidoIngresado.Size = new System.Drawing.Size(222, 23);
            this.apellidoIngresado.TabIndex = 10;
            this.apellidoIngresado.TabStop = false;
            this.apellidoIngresado.UseSystemPasswordChar = false;
            // 
            // apellido
            // 
            this.apellido.AutoSize = true;
            this.apellido.Depth = 0;
            this.apellido.Font = new System.Drawing.Font("Roboto", 11F);
            this.apellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.apellido.Location = new System.Drawing.Point(482, 110);
            this.apellido.MouseState = MaterialSkin.MouseState.HOVER;
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(64, 19);
            this.apellido.TabIndex = 9;
            this.apellido.Text = "Apellido";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Depth = 0;
            this.nombre.Font = new System.Drawing.Font("Roboto", 11F);
            this.nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nombre.Location = new System.Drawing.Point(482, 72);
            this.nombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(63, 19);
            this.nombre.TabIndex = 8;
            this.nombre.Text = "Nombre";
            // 
            // nombreIngresado
            // 
            this.nombreIngresado.Depth = 0;
            this.nombreIngresado.Hint = "";
            this.nombreIngresado.Location = new System.Drawing.Point(605, 68);
            this.nombreIngresado.MaxLength = 32767;
            this.nombreIngresado.MouseState = MaterialSkin.MouseState.HOVER;
            this.nombreIngresado.Name = "nombreIngresado";
            this.nombreIngresado.PasswordChar = '\0';
            this.nombreIngresado.SelectedText = "";
            this.nombreIngresado.SelectionLength = 0;
            this.nombreIngresado.SelectionStart = 0;
            this.nombreIngresado.Size = new System.Drawing.Size(222, 23);
            this.nombreIngresado.TabIndex = 7;
            this.nombreIngresado.TabStop = false;
            this.nombreIngresado.UseSystemPasswordChar = false;
            this.nombreIngresado.Click += new System.EventHandler(this.NombreIngresado_Click);
            // 
            // cboxPuntoV
            // 
            this.cboxPuntoV.BackColor = System.Drawing.SystemColors.Window;
            this.cboxPuntoV.FormattingEnabled = true;
            this.cboxPuntoV.Location = new System.Drawing.Point(605, 191);
            this.cboxPuntoV.Name = "cboxPuntoV";
            this.cboxPuntoV.Size = new System.Drawing.Size(222, 21);
            this.cboxPuntoV.TabIndex = 22;
            // 
            // materialLabelEmpresa
            // 
            this.materialLabelEmpresa.AutoSize = true;
            this.materialLabelEmpresa.Depth = 0;
            this.materialLabelEmpresa.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelEmpresa.Location = new System.Drawing.Point(482, 193);
            this.materialLabelEmpresa.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelEmpresa.Name = "materialLabelEmpresa";
            this.materialLabelEmpresa.Size = new System.Drawing.Size(111, 19);
            this.materialLabelEmpresa.TabIndex = 21;
            this.materialLabelEmpresa.Text = "Punto de Venta";
            this.materialLabelEmpresa.Click += new System.EventHandler(this.MaterialLabelEmpresa_Click);
            // 
            // TipoSeleccionado
            // 
            this.TipoSeleccionado.BackColor = System.Drawing.SystemColors.Window;
            this.TipoSeleccionado.FormattingEnabled = true;
            this.TipoSeleccionado.Location = new System.Drawing.Point(605, 146);
            this.TipoSeleccionado.Name = "TipoSeleccionado";
            this.TipoSeleccionado.Size = new System.Drawing.Size(222, 21);
            this.TipoSeleccionado.TabIndex = 20;
            // 
            // tipo
            // 
            this.tipo.AutoSize = true;
            this.tipo.Depth = 0;
            this.tipo.Font = new System.Drawing.Font("Roboto", 11F);
            this.tipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tipo.Location = new System.Drawing.Point(482, 148);
            this.tipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(39, 19);
            this.tipo.TabIndex = 19;
            this.tipo.Text = "Tipo";
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(636, 462);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = false;
            this.btnCancelar.Size = new System.Drawing.Size(91, 36);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.AutoSize = true;
            this.btnModificar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificar.Depth = 0;
            this.btnModificar.Icon = null;
            this.btnModificar.Location = new System.Drawing.Point(486, 231);
            this.btnModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Primary = true;
            this.btnModificar.Size = new System.Drawing.Size(93, 36);
            this.btnModificar.TabIndex = 23;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Icon = null;
            this.btnGuardar.Location = new System.Drawing.Point(734, 462);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = true;
            this.btnGuardar.Size = new System.Drawing.Size(84, 36);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(47, 22);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(153, 19);
            this.materialLabel1.TabIndex = 26;
            this.materialLabel1.Text = "MODIFICAR USUARIO";
            // 
            // ModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 520);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.cboxPuntoV);
            this.Controls.Add(this.materialLabelEmpresa);
            this.Controls.Add(this.TipoSeleccionado);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.apellidoIngresado);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.nombreIngresado);
            this.Controls.Add(this.gvwListaUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarUsuario";
            this.Text = "ModificarUsuario";
            this.Load += new System.EventHandler(this.ModificarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvwListaUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gvwListaUsuarios;
        private MaterialSkin.Controls.MaterialSingleLineTextField apellidoIngresado;
        private MaterialSkin.Controls.MaterialLabel apellido;
        private MaterialSkin.Controls.MaterialLabel nombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField nombreIngresado;
        private System.Windows.Forms.ComboBox cboxPuntoV;
        private MaterialSkin.Controls.MaterialLabel materialLabelEmpresa;
        private System.Windows.Forms.ComboBox TipoSeleccionado;
        private MaterialSkin.Controls.MaterialLabel tipo;
        private MaterialSkin.Controls.MaterialFlatButton btnCancelar;
        private MaterialSkin.Controls.MaterialRaisedButton btnModificar;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}