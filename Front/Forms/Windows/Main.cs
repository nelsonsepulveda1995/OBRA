using BLL;
using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Front.Forms
{
    public partial class Main : Form
    {
        private UsuarioBLL usuarioBLL = new UsuarioBLL();
        private Main()
        {
            InitializeComponent();
        }

        #region BarraDeVentana

        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.PanelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BotonCerrarVentana_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BotonMinimizarVentana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        int lx, ly;
        int sw, sh;
        private void BotonMaximizarVentana_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            BotonMaximizarVentana.Visible = false;
            BotonRestaurarVentana.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void BotonRestaurarVentana_Click(object sender, EventArgs e)
        {
            BotonMaximizarVentana.Visible = true;
            BotonRestaurarVentana.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void BarraVentanaLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        private static Main Instancia = null;
        public static Main CargarInicio()
        {
            if (Instancia == null)
            {
                Instancia = new Main();
                Instancia.MostrarPerfil();
                Instancia.MostrarComandos();
            }
            return Instancia;
        }

        private void MostrarComandos()
        {
            switch (this.usuarioBLL.GetUserCache().getIdTipo())
            {
                case 1: CargarComandos<Users.Admin.BotonesAdmin>(); break;
                case 2: CargarComandos<Users.Compras.BotonesCompras>(); break;
                case 3: CargarComandos<Users.Ventas.BotonesVentas>(); break;
                case 4: CargarComandos<Users.Deposito.BotonesDeposito>(); break;
                case 5: CargarComandos<Users.Gerencia.BotonesGerente>(); break;
            }
        }

        static public void AtenderAccion<Accion>(Form Control) where Accion : Form, new()
        {
            if (Instancia.PanelComandos.Controls.Contains(Control) ||
                Instancia.PanelFormularios.Controls.Contains(Control))
            {
                Instancia.AbrirFormulario<Accion>();
            }
        }

        private void MostrarPerfil()
        {
            Nombre.Text = usuarioBLL.GetNombreCompleto();
            Usuario.Text = usuarioBLL.GetUsuarioName();
            Tipo.Text = usuarioBLL.GetCargo();
        }

        private void BotonCerrarSesion_Click(object sender, EventArgs e)
        {
            Login.CerrarSesion(ref Instancia);
        }

        private void AbrirFormulario<Accion>() where Accion : Form, new()
        {
            Form formulario;
            formulario = PanelFormularios.Controls.OfType<Accion>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Accion
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
                PanelFormularios.Controls.Add(formulario);
                PanelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void Configuracion_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Users.Usuario.Acciones.ConfiguracionUsuario>();
        }

        private void CargarComandos<Comandos>() where Comandos : Form, new()
        {
            Form formulario;
            formulario = PanelComandos.Controls.OfType<Comandos>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new Comandos
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
                PanelComandos.Controls.Add(formulario);
                PanelComandos.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }
    }
}