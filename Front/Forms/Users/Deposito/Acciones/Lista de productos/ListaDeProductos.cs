using System.Windows.Forms;
using BLL;

namespace Front.Forms.Users.Deposito.Acciones
{
    public partial class ListaDeProductos : Form
    {
        public ListaDeProductos()
        {
            InitializeComponent();
        }

       

        private void BotonListaDeProductos_Click(object sender, System.EventArgs e)
        {
            DepositoBLL a = new DepositoBLL();
            
            

           dataGridView1.DataSource = a.listarTodosLosProdutos();
            


        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
