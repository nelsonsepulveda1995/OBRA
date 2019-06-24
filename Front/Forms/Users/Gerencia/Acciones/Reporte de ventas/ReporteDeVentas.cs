using BLL;
using System.Windows.Forms;

namespace Front.Forms.Users.Gerencia.Acciones
{
    public partial class VentasporUsuario : Form
    {
        GerenteBLL gerente = new GerenteBLL();
        public VentasporUsuario()
        {
            InitializeComponent();
        }

        private void BotonReporteDeVentas_Click(object sender, System.EventArgs e)
        {
            dataGridView1.DataSource = gerente.GetVentasporUsuarioBLL();
        }
    }
}
