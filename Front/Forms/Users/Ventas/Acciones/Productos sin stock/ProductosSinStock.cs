using BLL;
using System.Windows.Forms;

namespace Front.Forms.Users.Ventas.Acciones
{
    public partial class ProductosSinStock : Form
    {
        DepositoBLL deposito = new DepositoBLL();
        public ProductosSinStock()
        {
            InitializeComponent();
        }

        private void BotonMostrarStock_Click(object sender, System.EventArgs e)
        {
            dataGridView1.DataSource = deposito.ListarProductosconPocoStock(0);
        }
    }
}
