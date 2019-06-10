namespace Front.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.PanelFormularios = new System.Windows.Forms.Panel();
            this.Titulo = new System.Windows.Forms.Label();
            this.LogoGray = new System.Windows.Forms.PictureBox();
            this.PanelLateral = new System.Windows.Forms.Panel();
            this.PanelComandos = new System.Windows.Forms.Panel();
            this.PanelInferior = new System.Windows.Forms.Panel();
            this.Configuracion = new MaterialSkin.Controls.MaterialFlatButton();
            this.BotonCerrarSesion = new MaterialSkin.Controls.MaterialFlatButton();
            this.PanelUsuario = new System.Windows.Forms.Panel();
            this.Perfil = new System.Windows.Forms.Label();
            this.Tipo = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.FotoPerfil = new System.Windows.Forms.PictureBox();
            this.BarraVentanaMain = new System.Windows.Forms.Panel();
            this.BotonRestaurarVentana = new System.Windows.Forms.PictureBox();
            this.BotonMaximizarVentana = new System.Windows.Forms.PictureBox();
            this.BotonMinimizarVentana = new System.Windows.Forms.PictureBox();
            this.BotonCerrarVentana = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.PanelContenedor.SuspendLayout();
            this.PanelFormularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoGray)).BeginInit();
            this.PanelLateral.SuspendLayout();
            this.PanelComandos.SuspendLayout();
            this.PanelInferior.SuspendLayout();
            this.PanelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPerfil)).BeginInit();
            this.BarraVentanaMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BotonRestaurarVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonMaximizarVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonMinimizarVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonCerrarVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Controls.Add(this.PanelFormularios);
            this.PanelContenedor.Controls.Add(this.PanelLateral);
            this.PanelContenedor.Controls.Add(this.BarraVentanaMain);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(0, 0);
            this.PanelContenedor.Margin = new System.Windows.Forms.Padding(2);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1200, 700);
            this.PanelContenedor.TabIndex = 0;
            // 
            // PanelFormularios
            // 
            this.PanelFormularios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelFormularios.BackColor = System.Drawing.SystemColors.Control;
            this.PanelFormularios.Controls.Add(this.Titulo);
            this.PanelFormularios.Controls.Add(this.LogoGray);
            this.PanelFormularios.Location = new System.Drawing.Point(205, 28);
            this.PanelFormularios.Name = "PanelFormularios";
            this.PanelFormularios.Size = new System.Drawing.Size(1182, 672);
            this.PanelFormularios.TabIndex = 2;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Titulo.Location = new System.Drawing.Point(408, 440);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(214, 37);
            this.Titulo.TabIndex = 1;
            this.Titulo.Text = "BIENVENIDO";
            // 
            // LogoGray
            // 
            this.LogoGray.Image = ((System.Drawing.Image)(resources.GetObject("LogoGray.Image")));
            this.LogoGray.Location = new System.Drawing.Point(391, 130);
            this.LogoGray.Name = "LogoGray";
            this.LogoGray.Size = new System.Drawing.Size(278, 285);
            this.LogoGray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoGray.TabIndex = 0;
            this.LogoGray.TabStop = false;
            this.LogoGray.WaitOnLoad = true;
            // 
            // PanelLateral
            // 
            this.PanelLateral.Controls.Add(this.PanelComandos);
            this.PanelLateral.Controls.Add(this.PanelUsuario);
            this.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLateral.Location = new System.Drawing.Point(0, 28);
            this.PanelLateral.Name = "PanelLateral";
            this.PanelLateral.Size = new System.Drawing.Size(205, 672);
            this.PanelLateral.TabIndex = 3;
            // 
            // PanelComandos
            // 
            this.PanelComandos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelComandos.Controls.Add(this.PanelInferior);
            this.PanelComandos.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelComandos.Location = new System.Drawing.Point(0, 146);
            this.PanelComandos.Name = "PanelComandos";
            this.PanelComandos.Size = new System.Drawing.Size(205, 526);
            this.PanelComandos.TabIndex = 0;
            // 
            // PanelInferior
            // 
            this.PanelInferior.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PanelInferior.Controls.Add(this.Configuracion);
            this.PanelInferior.Controls.Add(this.BotonCerrarSesion);
            this.PanelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelInferior.Location = new System.Drawing.Point(0, 453);
            this.PanelInferior.Name = "PanelInferior";
            this.PanelInferior.Size = new System.Drawing.Size(205, 73);
            this.PanelInferior.TabIndex = 0;
            // 
            // Configuracion
            // 
            this.Configuracion.AutoSize = true;
            this.Configuracion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Configuracion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Configuracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Configuracion.Depth = 0;
            this.Configuracion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Configuracion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Configuracion.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Configuracion.Icon = global::Front.Properties.Resources.Settings;
            this.Configuracion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Configuracion.Location = new System.Drawing.Point(0, 1);
            this.Configuracion.Margin = new System.Windows.Forms.Padding(0);
            this.Configuracion.MouseState = MaterialSkin.MouseState.HOVER;
            this.Configuracion.Name = "Configuracion";
            this.Configuracion.Padding = new System.Windows.Forms.Padding(2);
            this.Configuracion.Primary = false;
            this.Configuracion.Size = new System.Drawing.Size(205, 36);
            this.Configuracion.TabIndex = 1;
            this.Configuracion.Text = "Configuracion";
            this.Configuracion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Configuracion.UseVisualStyleBackColor = false;
            this.Configuracion.Click += new System.EventHandler(this.Configuracion_Click);
            // 
            // BotonCerrarSesion
            // 
            this.BotonCerrarSesion.AutoSize = true;
            this.BotonCerrarSesion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BotonCerrarSesion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BotonCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonCerrarSesion.Depth = 0;
            this.BotonCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BotonCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonCerrarSesion.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.BotonCerrarSesion.Icon = global::Front.Properties.Resources.Logout;
            this.BotonCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BotonCerrarSesion.Location = new System.Drawing.Point(0, 37);
            this.BotonCerrarSesion.Margin = new System.Windows.Forms.Padding(0);
            this.BotonCerrarSesion.MouseState = MaterialSkin.MouseState.HOVER;
            this.BotonCerrarSesion.Name = "BotonCerrarSesion";
            this.BotonCerrarSesion.Padding = new System.Windows.Forms.Padding(2);
            this.BotonCerrarSesion.Primary = false;
            this.BotonCerrarSesion.Size = new System.Drawing.Size(205, 36);
            this.BotonCerrarSesion.TabIndex = 0;
            this.BotonCerrarSesion.Text = "Cerrar Sesion";
            this.BotonCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BotonCerrarSesion.UseVisualStyleBackColor = false;
            this.BotonCerrarSesion.Click += new System.EventHandler(this.BotonCerrarSesion_Click);
            // 
            // PanelUsuario
            // 
            this.PanelUsuario.BackColor = System.Drawing.Color.GhostWhite;
            this.PanelUsuario.Controls.Add(this.Perfil);
            this.PanelUsuario.Controls.Add(this.Tipo);
            this.PanelUsuario.Controls.Add(this.Usuario);
            this.PanelUsuario.Controls.Add(this.Nombre);
            this.PanelUsuario.Controls.Add(this.FotoPerfil);
            this.PanelUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelUsuario.Location = new System.Drawing.Point(0, 0);
            this.PanelUsuario.Name = "PanelUsuario";
            this.PanelUsuario.Size = new System.Drawing.Size(205, 146);
            this.PanelUsuario.TabIndex = 1;
            // 
            // Perfil
            // 
            this.Perfil.AutoSize = true;
            this.Perfil.BackColor = System.Drawing.Color.Transparent;
            this.Perfil.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Perfil.Location = new System.Drawing.Point(27, 15);
            this.Perfil.Name = "Perfil";
            this.Perfil.Size = new System.Drawing.Size(114, 13);
            this.Perfil.TabIndex = 10;
            this.Perfil.Text = "PERFIL DE USUARIO";
            // 
            // Tipo
            // 
            this.Tipo.AutoSize = true;
            this.Tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tipo.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Tipo.Location = new System.Drawing.Point(29, 113);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(131, 13);
            this.Tipo.TabIndex = 8;
            this.Tipo.Text = "CARGO DE USUARIO";
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Usuario.Location = new System.Drawing.Point(79, 72);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(83, 13);
            this.Usuario.TabIndex = 7;
            this.Usuario.Text = "Nombre Usuario";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Nombre.Location = new System.Drawing.Point(78, 53);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(83, 13);
            this.Nombre.TabIndex = 6;
            this.Nombre.Text = "Nombre apellido";
            // 
            // FotoPerfil
            // 
            this.FotoPerfil.Image = global::Front.Properties.Resources.MaleUser;
            this.FotoPerfil.Location = new System.Drawing.Point(17, 42);
            this.FotoPerfil.Name = "FotoPerfil";
            this.FotoPerfil.Size = new System.Drawing.Size(60, 53);
            this.FotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FotoPerfil.TabIndex = 3;
            this.FotoPerfil.TabStop = false;
            // 
            // BarraVentanaMain
            // 
            this.BarraVentanaMain.BackColor = System.Drawing.SystemColors.Highlight;
            this.BarraVentanaMain.Controls.Add(this.BotonRestaurarVentana);
            this.BarraVentanaMain.Controls.Add(this.BotonMaximizarVentana);
            this.BarraVentanaMain.Controls.Add(this.BotonMinimizarVentana);
            this.BarraVentanaMain.Controls.Add(this.BotonCerrarVentana);
            this.BarraVentanaMain.Controls.Add(this.Logo);
            this.BarraVentanaMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraVentanaMain.Location = new System.Drawing.Point(0, 0);
            this.BarraVentanaMain.Margin = new System.Windows.Forms.Padding(2);
            this.BarraVentanaMain.Name = "BarraVentanaMain";
            this.BarraVentanaMain.Size = new System.Drawing.Size(1200, 28);
            this.BarraVentanaMain.TabIndex = 1;
            this.BarraVentanaMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraVentanaLogin_MouseDown);
            // 
            // BotonRestaurarVentana
            // 
            this.BotonRestaurarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonRestaurarVentana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonRestaurarVentana.Image = global::Front.Properties.Resources.Restaurar;
            this.BotonRestaurarVentana.Location = new System.Drawing.Point(1152, 3);
            this.BotonRestaurarVentana.Margin = new System.Windows.Forms.Padding(2);
            this.BotonRestaurarVentana.Name = "BotonRestaurarVentana";
            this.BotonRestaurarVentana.Size = new System.Drawing.Size(20, 20);
            this.BotonRestaurarVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BotonRestaurarVentana.TabIndex = 3;
            this.BotonRestaurarVentana.TabStop = false;
            this.BotonRestaurarVentana.Visible = false;
            this.BotonRestaurarVentana.Click += new System.EventHandler(this.BotonRestaurarVentana_Click);
            // 
            // BotonMaximizarVentana
            // 
            this.BotonMaximizarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonMaximizarVentana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonMaximizarVentana.Image = ((System.Drawing.Image)(resources.GetObject("BotonMaximizarVentana.Image")));
            this.BotonMaximizarVentana.Location = new System.Drawing.Point(1152, 3);
            this.BotonMaximizarVentana.Margin = new System.Windows.Forms.Padding(2);
            this.BotonMaximizarVentana.Name = "BotonMaximizarVentana";
            this.BotonMaximizarVentana.Size = new System.Drawing.Size(20, 20);
            this.BotonMaximizarVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BotonMaximizarVentana.TabIndex = 2;
            this.BotonMaximizarVentana.TabStop = false;
            this.BotonMaximizarVentana.Click += new System.EventHandler(this.BotonMaximizarVentana_Click);
            // 
            // BotonMinimizarVentana
            // 
            this.BotonMinimizarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonMinimizarVentana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonMinimizarVentana.Image = ((System.Drawing.Image)(resources.GetObject("BotonMinimizarVentana.Image")));
            this.BotonMinimizarVentana.Location = new System.Drawing.Point(1128, 3);
            this.BotonMinimizarVentana.Margin = new System.Windows.Forms.Padding(2);
            this.BotonMinimizarVentana.Name = "BotonMinimizarVentana";
            this.BotonMinimizarVentana.Size = new System.Drawing.Size(20, 20);
            this.BotonMinimizarVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BotonMinimizarVentana.TabIndex = 1;
            this.BotonMinimizarVentana.TabStop = false;
            this.BotonMinimizarVentana.Click += new System.EventHandler(this.BotonMinimizarVentana_Click);
            // 
            // BotonCerrarVentana
            // 
            this.BotonCerrarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonCerrarVentana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonCerrarVentana.Image = ((System.Drawing.Image)(resources.GetObject("BotonCerrarVentana.Image")));
            this.BotonCerrarVentana.Location = new System.Drawing.Point(1177, 3);
            this.BotonCerrarVentana.Name = "BotonCerrarVentana";
            this.BotonCerrarVentana.Size = new System.Drawing.Size(20, 20);
            this.BotonCerrarVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BotonCerrarVentana.TabIndex = 0;
            this.BotonCerrarVentana.TabStop = false;
            this.BotonCerrarVentana.Click += new System.EventHandler(this.BotonCerrarVentana_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::Front.Properties.Resources.Logo;
            this.Logo.Location = new System.Drawing.Point(17, 8);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(46, 13);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 9;
            this.Logo.TabStop = false;
            this.Logo.WaitOnLoad = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.PanelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1022, 537);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.BotonMaximizarVentana_Click);
            this.PanelContenedor.ResumeLayout(false);
            this.PanelFormularios.ResumeLayout(false);
            this.PanelFormularios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoGray)).EndInit();
            this.PanelLateral.ResumeLayout(false);
            this.PanelComandos.ResumeLayout(false);
            this.PanelInferior.ResumeLayout(false);
            this.PanelInferior.PerformLayout();
            this.PanelUsuario.ResumeLayout(false);
            this.PanelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPerfil)).EndInit();
            this.BarraVentanaMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BotonRestaurarVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonMaximizarVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonMinimizarVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonCerrarVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Panel PanelComandos;
        private System.Windows.Forms.Panel BarraVentanaMain;
        private System.Windows.Forms.PictureBox BotonMinimizarVentana;
        private System.Windows.Forms.PictureBox BotonCerrarVentana;
        private System.Windows.Forms.Panel PanelFormularios;
        private System.Windows.Forms.Panel PanelUsuario;
        private System.Windows.Forms.PictureBox BotonMaximizarVentana;
        private System.Windows.Forms.PictureBox BotonRestaurarVentana;
        private System.Windows.Forms.Panel PanelLateral;
        private System.Windows.Forms.PictureBox FotoPerfil;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label Tipo;
        private System.Windows.Forms.Panel PanelInferior;
        private MaterialSkin.Controls.MaterialFlatButton BotonCerrarSesion;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.PictureBox LogoGray;
        private System.Windows.Forms.Label Titulo;
        private MaterialSkin.Controls.MaterialFlatButton Configuracion;
        private System.Windows.Forms.Label Perfil;
    }
}