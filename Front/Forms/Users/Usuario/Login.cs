using BLL;
using Front.Forms.Windows.Otros;
using MaterialSkin;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Front.Forms
{
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        private readonly UsuarioBLL usuariodDAL = new UsuarioBLL();
        private MaterialSkinManager Diseño;
        private Login()
        {
            
            InitializeComponent();
            Diseño = MaterialSkinManager.Instance;
            Diseño.AddFormToManage(this);
            Diseño.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private static Login Instancia = null;

        public static Login IniciarSesion()
        {
            if (Instancia == null) Instancia = new Login();
            return Instancia;
        }
        
        private void BotonLoginIngresar_Click(object sender, EventArgs e)
        {
            if (!this.CajaIngresarContraceña.Text.Equals(""))
            {
                if (this.CajaIngresarUsuario.Equals(""))
                {
                    WarningUser.Text = "        Ingrese un usuario";
                    WarningUser.Visible = true;
                }
                else //verifica si hay datos ingresados en los campos
                {
                    if(this.CajaIngresarUsuario.Text.Equals("ConnectionManager") 
                    && this.CajaIngresarContraceña.Text.Equals("TDLPAPPCONFIG"))
                    {
                        using (DataBaseConfig FormularioDeConexion = new DataBaseConfig())
                        {
                            FormularioDeConexion.ShowDialog();
                        }
                        this.CajaIngresarContraceña.ResetText();
                        this.CajaIngresarUsuario.ResetText();
                        this.CajaIngresarUsuario.Focus();
                    }
                    else if (usuariodDAL.LoginUser(this.CajaIngresarUsuario.Text, this.CajaIngresarContraceña.Text))//CUENTA LAS FILAS PARA SABER SI ES NULL
                    {
                        Warning.Visible = WarningUser.Visible = WarningPassword.Visible = false;
                        Instancia.Hide();
                        Thread t = new Thread(new ThreadStart(PantallaDeCarga));
                        t.Start();
                        Thread.Sleep(200);
                        Main Inicio = Main.CargarInicio();
                        t.Abort();
                        Inicio.Show();
                    }
                    else
                    {
                        Warning.Text = "        Ingrese un usuario valido";
                        Warning.Visible = true;
                    }
                }
            }
            else
            {
                WarningPassword.Text = "        Ingrese una contraseña";
                WarningPassword.Visible = true;
            }
        }

        private void PantallaDeCarga()
        {
            Application.Run(new Loading());
        }

        public static void CerrarSesion(ref Main InstaciaMain)
        {
            InstaciaMain.Hide();
            InstaciaMain = null;
            Instancia.usuariodDAL.LogoutUser();
            Instancia.CajaIngresarContraceña.Text = null;
            Instancia.CajaIngresarUsuario.Text = null;
            Instancia.Show();
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CajaIngresarContraceña_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show($"PRESIONO {e.KeyChar}");
            if (e.KeyChar == 13)
            {
                Instancia.BotonLoginIngresar_Click(sender, e);
            }
        }
    }
}
