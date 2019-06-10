using System.Windows.Forms;


namespace Front.Forms.Users.Admin
{
    public partial class BotonesAdmin : Form
    {
        public BotonesAdmin()
        {
            InitializeComponent();
        }

        private void RegUsuario_Click(object sender, System.EventArgs e)
        {
            Main.AtenderAccion<Acciones.NuevoUsuario>(this);

        }

        private void DelUsuario_Click(object sender, System.EventArgs e)
        {
            Main.AtenderAccion<Acciones.EliminarUsuario>(this);
        }

        private void ModUsuario_Click(object sender, System.EventArgs e)
        {
            Main.AtenderAccion<Acciones.ModificarUsuario>(this);
        }
    }
}
