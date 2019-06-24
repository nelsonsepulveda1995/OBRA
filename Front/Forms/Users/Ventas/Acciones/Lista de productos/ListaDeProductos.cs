using BLL;
using System.Windows.Forms;

namespace Front.Forms.Users.Ventas.Acciones
{
    public partial class ListaDeProductos : Form
    {
        ProductoBLL producto = new ProductoBLL();
        public ListaDeProductos()
        {
            InitializeComponent();
        }

        private void BotonListaDeProductos_Click(object sender, System.EventArgs e)
        {
            dataGridView1.DataSource = producto.ListarProductos();
        }

        private void ListaDeProductos_Load(object sender, System.EventArgs e)
        {

        }
    }
}
