namespace Front.Forms
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.PieDeVentana = new System.Windows.Forms.Panel();
            this.SigInPanel = new System.Windows.Forms.Panel();
            this.Warning = new System.Windows.Forms.Label();
            this.WarningPassword = new System.Windows.Forms.Label();
            this.WarningUser = new System.Windows.Forms.Label();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.EtiquetaUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.EtiquetaContraceña = new MaterialSkin.Controls.MaterialLabel();
            this.CajaIngresarContraceña = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CajaIngresarUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BotonLoginIngresar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ContenedorDelLogo = new System.Windows.Forms.PictureBox();
            this.BotonSalir = new MaterialSkin.Controls.MaterialFlatButton();
            this.Titulo = new System.Windows.Forms.Label();
            this.SigInPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContenedorDelLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PieDeVentana
            // 
            this.PieDeVentana.BackColor = System.Drawing.Color.Gray;
            this.PieDeVentana.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PieDeVentana.Location = new System.Drawing.Point(0, 515);
            this.PieDeVentana.Name = "PieDeVentana";
            this.PieDeVentana.Size = new System.Drawing.Size(370, 25);
            this.PieDeVentana.TabIndex = 2;
            // 
            // SigInPanel
            // 
            this.SigInPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SigInPanel.Controls.Add(this.Warning);
            this.SigInPanel.Controls.Add(this.WarningPassword);
            this.SigInPanel.Controls.Add(this.WarningUser);
            this.SigInPanel.Controls.Add(this.materialCheckBox1);
            this.SigInPanel.Controls.Add(this.EtiquetaUsuario);
            this.SigInPanel.Controls.Add(this.EtiquetaContraceña);
            this.SigInPanel.Controls.Add(this.CajaIngresarContraceña);
            this.SigInPanel.Controls.Add(this.CajaIngresarUsuario);
            this.SigInPanel.Location = new System.Drawing.Point(37, 155);
            this.SigInPanel.Name = "SigInPanel";
            this.SigInPanel.Size = new System.Drawing.Size(301, 273);
            this.SigInPanel.TabIndex = 3;
            // 
            // Warning
            // 
            this.Warning.AutoSize = true;
            this.Warning.BackColor = System.Drawing.Color.Transparent;
            this.Warning.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Warning.Image = global::Front.Properties.Resources.Warnig;
            this.Warning.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Warning.Location = new System.Drawing.Point(49, 239);
            this.Warning.Name = "Warning";
            this.Warning.Size = new System.Drawing.Size(107, 13);
            this.Warning.TabIndex = 8;
            this.Warning.Text = "       avisos generales";
            this.Warning.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Warning.Visible = false;
            // 
            // WarningPassword
            // 
            this.WarningPassword.AutoSize = true;
            this.WarningPassword.BackColor = System.Drawing.Color.Transparent;
            this.WarningPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.WarningPassword.Image = global::Front.Properties.Resources.Warnig;
            this.WarningPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WarningPassword.Location = new System.Drawing.Point(47, 169);
            this.WarningPassword.Name = "WarningPassword";
            this.WarningPassword.Size = new System.Drawing.Size(115, 13);
            this.WarningPassword.TabIndex = 7;
            this.WarningPassword.Text = "       avisos contraceña";
            this.WarningPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.WarningPassword.Visible = false;
            // 
            // WarningUser
            // 
            this.WarningUser.AutoSize = true;
            this.WarningUser.BackColor = System.Drawing.Color.Transparent;
            this.WarningUser.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.WarningUser.Image = global::Front.Properties.Resources.Warnig;
            this.WarningUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WarningUser.Location = new System.Drawing.Point(49, 79);
            this.WarningUser.Name = "WarningUser";
            this.WarningUser.Size = new System.Drawing.Size(95, 13);
            this.WarningUser.TabIndex = 6;
            this.WarningUser.Text = "       avisos usuario";
            this.WarningUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.WarningUser.Visible = false;
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.materialCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox1.ForeColor = System.Drawing.Color.Transparent;
            this.materialCheckBox1.Location = new System.Drawing.Point(43, 197);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(105, 30);
            this.materialCheckBox1.TabIndex = 4;
            this.materialCheckBox1.Text = "Recordarme";
            this.materialCheckBox1.UseVisualStyleBackColor = false;
            // 
            // EtiquetaUsuario
            // 
            this.EtiquetaUsuario.AutoSize = true;
            this.EtiquetaUsuario.Depth = 0;
            this.EtiquetaUsuario.Font = new System.Drawing.Font("Roboto", 11F);
            this.EtiquetaUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EtiquetaUsuario.Location = new System.Drawing.Point(45, 23);
            this.EtiquetaUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.EtiquetaUsuario.Name = "EtiquetaUsuario";
            this.EtiquetaUsuario.Size = new System.Drawing.Size(61, 19);
            this.EtiquetaUsuario.TabIndex = 3;
            this.EtiquetaUsuario.Text = "Usuario";
            // 
            // EtiquetaContraceña
            // 
            this.EtiquetaContraceña.AutoSize = true;
            this.EtiquetaContraceña.Depth = 0;
            this.EtiquetaContraceña.Font = new System.Drawing.Font("Roboto", 11F);
            this.EtiquetaContraceña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EtiquetaContraceña.Location = new System.Drawing.Point(45, 112);
            this.EtiquetaContraceña.MouseState = MaterialSkin.MouseState.HOVER;
            this.EtiquetaContraceña.Name = "EtiquetaContraceña";
            this.EtiquetaContraceña.Size = new System.Drawing.Size(86, 19);
            this.EtiquetaContraceña.TabIndex = 2;
            this.EtiquetaContraceña.Text = "Contraceña";
            // 
            // CajaIngresarContraceña
            // 
            this.CajaIngresarContraceña.Depth = 0;
            this.CajaIngresarContraceña.Hint = "";
            this.CajaIngresarContraceña.Location = new System.Drawing.Point(49, 141);
            this.CajaIngresarContraceña.MaxLength = 32767;
            this.CajaIngresarContraceña.MouseState = MaterialSkin.MouseState.HOVER;
            this.CajaIngresarContraceña.Name = "CajaIngresarContraceña";
            this.CajaIngresarContraceña.PasswordChar = '\0';
            this.CajaIngresarContraceña.SelectedText = "";
            this.CajaIngresarContraceña.SelectionLength = 0;
            this.CajaIngresarContraceña.SelectionStart = 0;
            this.CajaIngresarContraceña.Size = new System.Drawing.Size(192, 23);
            this.CajaIngresarContraceña.TabIndex = 1;
            this.CajaIngresarContraceña.TabStop = false;
            this.CajaIngresarContraceña.UseSystemPasswordChar = true;
            this.CajaIngresarContraceña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CajaIngresarContraceña_KeyPress);
            // 
            // CajaIngresarUsuario
            // 
            this.CajaIngresarUsuario.Depth = 0;
            this.CajaIngresarUsuario.Hint = "";
            this.CajaIngresarUsuario.Location = new System.Drawing.Point(49, 50);
            this.CajaIngresarUsuario.MaxLength = 32767;
            this.CajaIngresarUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.CajaIngresarUsuario.Name = "CajaIngresarUsuario";
            this.CajaIngresarUsuario.PasswordChar = '\0';
            this.CajaIngresarUsuario.SelectedText = "";
            this.CajaIngresarUsuario.SelectionLength = 0;
            this.CajaIngresarUsuario.SelectionStart = 0;
            this.CajaIngresarUsuario.Size = new System.Drawing.Size(192, 23);
            this.CajaIngresarUsuario.TabIndex = 0;
            this.CajaIngresarUsuario.TabStop = false;
            this.CajaIngresarUsuario.UseSystemPasswordChar = false;
            // 
            // BotonLoginIngresar
            // 
            this.BotonLoginIngresar.AutoSize = true;
            this.BotonLoginIngresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BotonLoginIngresar.Depth = 0;
            this.BotonLoginIngresar.Icon = null;
            this.BotonLoginIngresar.Location = new System.Drawing.Point(252, 450);
            this.BotonLoginIngresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BotonLoginIngresar.Name = "BotonLoginIngresar";
            this.BotonLoginIngresar.Primary = true;
            this.BotonLoginIngresar.Size = new System.Drawing.Size(86, 36);
            this.BotonLoginIngresar.TabIndex = 4;
            this.BotonLoginIngresar.Text = "INGRESAR";
            this.BotonLoginIngresar.UseVisualStyleBackColor = true;
            this.BotonLoginIngresar.Click += new System.EventHandler(this.BotonLoginIngresar_Click);
            // 
            // ContenedorDelLogo
            // 
            this.ContenedorDelLogo.BackColor = System.Drawing.Color.Transparent;
            this.ContenedorDelLogo.Image = ((System.Drawing.Image)(resources.GetObject("ContenedorDelLogo.Image")));
            this.ContenedorDelLogo.Location = new System.Drawing.Point(114, 100);
            this.ContenedorDelLogo.Name = "ContenedorDelLogo";
            this.ContenedorDelLogo.Size = new System.Drawing.Size(154, 27);
            this.ContenedorDelLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ContenedorDelLogo.TabIndex = 1;
            this.ContenedorDelLogo.TabStop = false;
            // 
            // BotonSalir
            // 
            this.BotonSalir.AutoSize = true;
            this.BotonSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BotonSalir.Depth = 0;
            this.BotonSalir.Icon = null;
            this.BotonSalir.Location = new System.Drawing.Point(183, 450);
            this.BotonSalir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BotonSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BotonSalir.Name = "BotonSalir";
            this.BotonSalir.Primary = false;
            this.BotonSalir.Size = new System.Drawing.Size(58, 36);
            this.BotonSalir.TabIndex = 5;
            this.BotonSalir.Text = "SALIR";
            this.BotonSalir.UseVisualStyleBackColor = true;
            this.BotonSalir.Click += new System.EventHandler(this.BotonSalir_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Titulo.Location = new System.Drawing.Point(141, 37);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(97, 16);
            this.Titulo.TabIndex = 6;
            this.Titulo.Text = "INICIAR SESION";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(370, 540);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.BotonSalir);
            this.Controls.Add(this.BotonLoginIngresar);
            this.Controls.Add(this.SigInPanel);
            this.Controls.Add(this.PieDeVentana);
            this.Controls.Add(this.ContenedorDelLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(370, 540);
            this.MinimumSize = new System.Drawing.Size(370, 540);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.SigInPanel.ResumeLayout(false);
            this.SigInPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContenedorDelLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ContenedorDelLogo;
        private System.Windows.Forms.Panel PieDeVentana;
        private System.Windows.Forms.Panel SigInPanel;
        private MaterialSkin.Controls.MaterialRaisedButton BotonLoginIngresar;
        private MaterialSkin.Controls.MaterialLabel EtiquetaUsuario;
        private MaterialSkin.Controls.MaterialLabel EtiquetaContraceña;
        private MaterialSkin.Controls.MaterialSingleLineTextField CajaIngresarContraceña;
        private MaterialSkin.Controls.MaterialSingleLineTextField CajaIngresarUsuario;
        private MaterialSkin.Controls.MaterialFlatButton BotonSalir;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
        private System.Windows.Forms.Label WarningUser;
        private System.Windows.Forms.Label Warning;
        private System.Windows.Forms.Label WarningPassword;
        private System.Windows.Forms.Label Titulo;
    }
}

