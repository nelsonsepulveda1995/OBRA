using System.Windows.Forms;

namespace Front.Forms.Users.Deposito.Acciones
{
    public partial class ProductosSinStock : Form
    {
        public ProductosSinStock()
        {
            InitializeComponent();
        }

        private void BotonMostrarStock_Click(object sender, System.EventArgs e)
        {
            dgProductosSinStock.DataSource =null;
        }
    }
}
