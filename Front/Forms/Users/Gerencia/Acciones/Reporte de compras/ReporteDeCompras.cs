using BLL;
using System.Windows.Forms;

namespace Front.Forms.Users.Gerencia.Acciones
{
    public partial class ReporteDeCompras : Form
    {

        GerenteBLL G = new GerenteBLL();
        public ReporteDeCompras()
        {
            InitializeComponent();
        }

        private void BotonReporteDeCompras_Click(object sender, System.EventArgs e)
        {
            dataGridView1.DataSource = G.GetProductomasVedido();
        }
    }
}
