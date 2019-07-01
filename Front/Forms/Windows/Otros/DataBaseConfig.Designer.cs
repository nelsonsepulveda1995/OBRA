namespace Front.Forms.Windows.Otros
{
    partial class DataBaseConfig
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
            this.LabelServer = new MaterialSkin.Controls.MaterialLabel();
            this.LabelDatabase = new MaterialSkin.Controls.MaterialLabel();
            this.LabelUserName = new MaterialSkin.Controls.MaterialLabel();
            this.LabelPassword = new MaterialSkin.Controls.MaterialLabel();
            this.CajaTextoUserName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CajaTextoPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CajaTextoDatabase = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SelectorInstancia = new System.Windows.Forms.ComboBox();
            this.BotonAceptar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.OpcionUsaCredenciales = new MaterialSkin.Controls.MaterialCheckBox();
            this.SuspendLayout();
            // 
            // LabelServer
            // 
            this.LabelServer.AutoSize = true;
            this.LabelServer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelServer.Depth = 0;
            this.LabelServer.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelServer.Location = new System.Drawing.Point(22, 127);
            this.LabelServer.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelServer.Name = "LabelServer";
            this.LabelServer.Size = new System.Drawing.Size(55, 19);
            this.LabelServer.TabIndex = 0;
            this.LabelServer.Text = "Server:";
            // 
            // LabelDatabase
            // 
            this.LabelDatabase.AutoSize = true;
            this.LabelDatabase.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelDatabase.Depth = 0;
            this.LabelDatabase.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelDatabase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelDatabase.Location = new System.Drawing.Point(22, 174);
            this.LabelDatabase.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelDatabase.Name = "LabelDatabase";
            this.LabelDatabase.Size = new System.Drawing.Size(76, 19);
            this.LabelDatabase.TabIndex = 1;
            this.LabelDatabase.Text = "Database:";
            // 
            // LabelUserName
            // 
            this.LabelUserName.AutoSize = true;
            this.LabelUserName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelUserName.Depth = 0;
            this.LabelUserName.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelUserName.Location = new System.Drawing.Point(22, 279);
            this.LabelUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(85, 19);
            this.LabelUserName.TabIndex = 2;
            this.LabelUserName.Text = "User name:";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelPassword.Depth = 0;
            this.LabelPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelPassword.Location = new System.Drawing.Point(22, 329);
            this.LabelPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(79, 19);
            this.LabelPassword.TabIndex = 3;
            this.LabelPassword.Text = "Password:";
            // 
            // CajaTextoUserName
            // 
            this.CajaTextoUserName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CajaTextoUserName.Depth = 0;
            this.CajaTextoUserName.Hint = "";
            this.CajaTextoUserName.Location = new System.Drawing.Point(114, 276);
            this.CajaTextoUserName.MaxLength = 32767;
            this.CajaTextoUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.CajaTextoUserName.Name = "CajaTextoUserName";
            this.CajaTextoUserName.PasswordChar = '\0';
            this.CajaTextoUserName.SelectedText = "";
            this.CajaTextoUserName.SelectionLength = 0;
            this.CajaTextoUserName.SelectionStart = 0;
            this.CajaTextoUserName.Size = new System.Drawing.Size(282, 23);
            this.CajaTextoUserName.TabIndex = 5;
            this.CajaTextoUserName.TabStop = false;
            this.CajaTextoUserName.UseSystemPasswordChar = false;
            // 
            // CajaTextoPassword
            // 
            this.CajaTextoPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CajaTextoPassword.Depth = 0;
            this.CajaTextoPassword.Hint = "";
            this.CajaTextoPassword.Location = new System.Drawing.Point(114, 326);
            this.CajaTextoPassword.MaxLength = 32767;
            this.CajaTextoPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.CajaTextoPassword.Name = "CajaTextoPassword";
            this.CajaTextoPassword.PasswordChar = '\0';
            this.CajaTextoPassword.SelectedText = "";
            this.CajaTextoPassword.SelectionLength = 0;
            this.CajaTextoPassword.SelectionStart = 0;
            this.CajaTextoPassword.Size = new System.Drawing.Size(282, 23);
            this.CajaTextoPassword.TabIndex = 6;
            this.CajaTextoPassword.TabStop = false;
            this.CajaTextoPassword.UseSystemPasswordChar = true;
            // 
            // CajaTextoDatabase
            // 
            this.CajaTextoDatabase.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CajaTextoDatabase.Depth = 0;
            this.CajaTextoDatabase.Hint = "";
            this.CajaTextoDatabase.Location = new System.Drawing.Point(114, 171);
            this.CajaTextoDatabase.MaxLength = 32767;
            this.CajaTextoDatabase.MouseState = MaterialSkin.MouseState.HOVER;
            this.CajaTextoDatabase.Name = "CajaTextoDatabase";
            this.CajaTextoDatabase.PasswordChar = '\0';
            this.CajaTextoDatabase.SelectedText = "";
            this.CajaTextoDatabase.SelectionLength = 0;
            this.CajaTextoDatabase.SelectionStart = 0;
            this.CajaTextoDatabase.Size = new System.Drawing.Size(282, 23);
            this.CajaTextoDatabase.TabIndex = 7;
            this.CajaTextoDatabase.TabStop = false;
            this.CajaTextoDatabase.UseSystemPasswordChar = false;
            // 
            // SelectorInstancia
            // 
            this.SelectorInstancia.FormattingEnabled = true;
            this.SelectorInstancia.Location = new System.Drawing.Point(114, 125);
            this.SelectorInstancia.Name = "SelectorInstancia";
            this.SelectorInstancia.Size = new System.Drawing.Size(282, 21);
            this.SelectorInstancia.TabIndex = 8;
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.AutoSize = true;
            this.BotonAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BotonAceptar.Depth = 0;
            this.BotonAceptar.Icon = null;
            this.BotonAceptar.Location = new System.Drawing.Point(314, 395);
            this.BotonAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Primary = true;
            this.BotonAceptar.Size = new System.Drawing.Size(82, 36);
            this.BotonAceptar.TabIndex = 9;
            this.BotonAceptar.Text = "ACEPTAR";
            this.BotonAceptar.UseVisualStyleBackColor = true;
            this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(216, 395);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(91, 36);
            this.materialFlatButton1.TabIndex = 10;
            this.materialFlatButton1.Text = "CANCELAR";
            this.materialFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.materialFlatButton1.UseVisualStyleBackColor = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(22, 80);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(345, 19);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.Text = "Ingrese los datos de coneccion a la base de datos";
            // 
            // OpcionUsaCredenciales
            // 
            this.OpcionUsaCredenciales.AutoSize = true;
            this.OpcionUsaCredenciales.BackColor = System.Drawing.Color.White;
            this.OpcionUsaCredenciales.Checked = true;
            this.OpcionUsaCredenciales.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OpcionUsaCredenciales.Depth = 0;
            this.OpcionUsaCredenciales.Font = new System.Drawing.Font("Roboto", 10F);
            this.OpcionUsaCredenciales.Location = new System.Drawing.Point(26, 214);
            this.OpcionUsaCredenciales.Margin = new System.Windows.Forms.Padding(0);
            this.OpcionUsaCredenciales.MouseLocation = new System.Drawing.Point(-1, -1);
            this.OpcionUsaCredenciales.MouseState = MaterialSkin.MouseState.HOVER;
            this.OpcionUsaCredenciales.Name = "OpcionUsaCredenciales";
            this.OpcionUsaCredenciales.Ripple = true;
            this.OpcionUsaCredenciales.Size = new System.Drawing.Size(337, 30);
            this.OpcionUsaCredenciales.TabIndex = 12;
            this.OpcionUsaCredenciales.Text = "El servidor usa la seguridad integrada de windows";
            this.OpcionUsaCredenciales.UseVisualStyleBackColor = false;
            this.OpcionUsaCredenciales.CheckStateChanged += new System.EventHandler(this.OpcionUsaCredenciales_CheckStateChanged);
            // 
            // DataBaseConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 462);
            this.Controls.Add(this.CajaTextoPassword);
            this.Controls.Add(this.OpcionUsaCredenciales);
            this.Controls.Add(this.LabelUserName);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.CajaTextoUserName);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.BotonAceptar);
            this.Controls.Add(this.SelectorInstancia);
            this.Controls.Add(this.CajaTextoDatabase);
            this.Controls.Add(this.LabelDatabase);
            this.Controls.Add(this.LabelServer);
            this.Name = "DataBaseConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DataBaseConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LabelServer;
        private MaterialSkin.Controls.MaterialLabel LabelDatabase;
        private MaterialSkin.Controls.MaterialLabel LabelUserName;
        private MaterialSkin.Controls.MaterialLabel LabelPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField CajaTextoUserName;
        private MaterialSkin.Controls.MaterialSingleLineTextField CajaTextoPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField CajaTextoDatabase;
        private System.Windows.Forms.ComboBox SelectorInstancia;
        private MaterialSkin.Controls.MaterialRaisedButton BotonAceptar;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCheckBox OpcionUsaCredenciales;
    }
}