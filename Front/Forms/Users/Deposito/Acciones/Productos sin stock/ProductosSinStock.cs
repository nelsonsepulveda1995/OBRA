using BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace Front.Forms.Users.Deposito.Acciones
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
            DataTable productos = new DataTable();
            productos = deposito.ListarProductosconPocoStock(0);
            dgProductosSinStock.DataSource =productos;
        }

        private void MaterialRaisedButton1_Click(object sender, System.EventArgs e)
        {
            DataTable productos = new DataTable();
            productos = deposito.ListarProductosconPocoStock(Convert.ToInt32(numericUpDown1.Value));
            dataGridView1.DataSource = productos;
        }
    }
}
