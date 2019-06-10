namespace Front.Forms.Users.Admin
{
    partial class BotonesAdmin
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
            this.DelUsuario = new MaterialSkin.Controls.MaterialFlatButton();
            this.ModUsuario = new MaterialSkin.Controls.MaterialFlatButton();
            this.RegUsuario = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // DelUsuario
            // 
            this.DelUsuario.AutoSize = true;
            this.DelUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DelUsuario.Depth = 0;
            this.DelUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.DelUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DelUsuario.Icon = null;
            this.DelUsuario.Location = new System.Drawing.Point(0, 72);
            this.DelUsuario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DelUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.DelUsuario.Name = "DelUsuario";
            this.DelUsuario.Primary = false;
            this.DelUsuario.Size = new System.Drawing.Size(200, 36);
            this.DelUsuario.TabIndex = 5;
            this.DelUsuario.Text = "ELIMINAR USUARIO";
            this.DelUsuario.UseVisualStyleBackColor = true;
            this.DelUsuario.Click += new System.EventHandler(this.DelUsuario_Click);
            // 
            // ModUsuario
            // 
            this.ModUsuario.AutoSize = true;
            this.ModUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ModUsuario.Depth = 0;
            this.ModUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ModUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ModUsuario.Icon = null;
            this.ModUsuario.Location = new System.Drawing.Point(0, 36);
            this.ModUsuario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ModUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.ModUsuario.Name = "ModUsuario";
            this.ModUsuario.Primary = false;
            this.ModUsuario.Size = new System.Drawing.Size(200, 36);
            this.ModUsuario.TabIndex = 4;
            this.ModUsuario.Text = "MODIFICAR USUARIO";
            this.ModUsuario.UseVisualStyleBackColor = true;
            this.ModUsuario.Click += new System.EventHandler(this.ModUsuario_Click);
            // 
            // RegUsuario
            // 
            this.RegUsuario.AutoSize = true;
            this.RegUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RegUsuario.Depth = 0;
            this.RegUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.RegUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegUsuario.Icon = null;
            this.RegUsuario.Location = new System.Drawing.Point(0, 0);
            this.RegUsuario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RegUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.RegUsuario.Name = "RegUsuario";
            this.RegUsuario.Primary = false;
            this.RegUsuario.Size = new System.Drawing.Size(200, 36);
            this.RegUsuario.TabIndex = 3;
            this.RegUsuario.Text = "REGISTRAR USUARIO";
            this.RegUsuario.UseVisualStyleBackColor = true;
            this.RegUsuario.Click += new System.EventHandler(this.RegUsuario_Click);
            // 
            // BotonesAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(200, 539);
            this.Controls.Add(this.DelUsuario);
            this.Controls.Add(this.ModUsuario);
            this.Controls.Add(this.RegUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BotonesAdmin";
            this.Text = "Controles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton DelUsuario;
        private MaterialSkin.Controls.MaterialFlatButton ModUsuario;
        private MaterialSkin.Controls.MaterialFlatButton RegUsuario;
    }
}