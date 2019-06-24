using System.Windows.Forms;
using BLL;

namespace Front.Forms.Users.Admin.Acciones
{
    public partial class EliminarUsuario : Form
    {
        readonly AdministracionBLL admin = new AdministracionBLL();
        public EliminarUsuario()
        {
            InitializeComponent();
        }
        // ED  -  2019 06 20
        private void Boton_Click(object sender, System.EventArgs e)
        {
            if (gvwListaUsuarios.SelectedRows.Count > 0)
            {
                string idUsuario = gvwListaUsuarios.CurrentRow.Cells["NOMBREUSUARIO"].Value.ToString();
                admin.DesabilitarUsuario(idUsuario);
                MessageBox.Show("Eliminado correctamente");
                MostrarUsuarioHabilitados();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
            
        }

        private void EliminarUsuario_Load(object sender, System.EventArgs e)
        {
            MostrarUsuarioHabilitados();
        }
        private void MostrarUsuarioHabilitados()
        {
            gvwListaUsuarios.DataSource = admin.MostrarUsuarioHabilitados();
        }
        // ED  -  2019 06 20 END
    }
}
