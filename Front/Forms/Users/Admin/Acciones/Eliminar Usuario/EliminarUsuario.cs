using BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace Front.Forms.Users.Admin.Acciones
{
    public partial class EliminarUsuario : Form
    {
        AdministracionBLL admin = new AdministracionBLL();
        public EliminarUsuario()
        {
            InitializeComponent();
        }

        private void EliminarUsuario_Load(object sender, System.EventArgs e)
        {
            DataTable tabla= admin.MostrarUsuarioHabilitados();
            dgw_listahabiltados.DataSource = tabla;
            cbdesabilitar.DataSource = tabla;
            cbdesabilitar.ValueMember = "NOMBREUSUARIO";
            cbdesabilitar.DisplayMember = "NOMBREUSUARIO";

        }

        private void Boton_Click(object sender, System.EventArgs e)
        {
            string id=Convert.ToString(cbdesabilitar.SelectedValue);
            admin.DesabilitarUsuario(id);
            dgw_listahabiltados.DataSource = admin.MostrarUsuarioHabilitados();
            mlrespuesta.Text = "Usuario desabilitado correctamente";
        }
    }
}
