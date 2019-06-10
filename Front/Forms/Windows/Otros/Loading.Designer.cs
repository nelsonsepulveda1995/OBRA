namespace Front.Forms
{
    partial class Loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.BarraLoading = new MaterialSkin.Controls.MaterialProgressBar();
            this.Titulo = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Image = global::Front.Properties.Resources.Logo;
            this.Logo.Location = new System.Drawing.Point(74, 48);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(126, 39);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // BarraLoading
            // 
            this.BarraLoading.Depth = 0;
            this.BarraLoading.Location = new System.Drawing.Point(76, 229);
            this.BarraLoading.MarqueeAnimationSpeed = 50;
            this.BarraLoading.MouseState = MaterialSkin.MouseState.HOVER;
            this.BarraLoading.Name = "BarraLoading";
            this.BarraLoading.Size = new System.Drawing.Size(124, 5);
            this.BarraLoading.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.BarraLoading.TabIndex = 1;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Depth = 0;
            this.Titulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Titulo.Location = new System.Drawing.Point(89, 106);
            this.Titulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(89, 19);
            this.Titulo.TabIndex = 2;
            this.Titulo.Text = "CARGANDO";
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 321);
            this.ControlBox = false;
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.BarraLoading);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private MaterialSkin.Controls.MaterialProgressBar BarraLoading;
        private MaterialSkin.Controls.MaterialLabel Titulo;
    }
}