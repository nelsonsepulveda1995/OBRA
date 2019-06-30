using BLL;
using System.Windows.Forms;

namespace Front.Forms.Users.Compras.Acciones
{
    public partial class FacturasDeCompras : Form
    {
        ComprasBLL Compra = new ComprasBLL();
        public FacturasDeCompras()
        {
            InitializeComponent();
        }

        private void BotonFacturasDeCompras_Click(object sender, System.EventArgs e)
        {
            dataGridView1.DataSource = Compra.VerCompras();
        }
    }
}
