using BLL;
using System.Windows.Forms;

namespace Front.Forms.Users.Compras.Acciones
{
    public partial class FacturasDeCompras : Form
    {
        ComprasBLL Compra = new ComprasBLL();
        string idFacturaCompra;
        public FacturasDeCompras()
        {
            InitializeComponent();
        }

        private void BotonFacturasDeCompras_Click(object sender, System.EventArgs e)
        {
            dataGridView1.DataSource = Compra.VerCompras();
        }
        //  ED  -  2019 07 01 
        private void BtnDetalleFC_Click(object sender, System.EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idFacturaCompra = dataGridView1.CurrentRow.Cells["ID_FACTURACOMPRA"].Value.ToString();
                gvwDetalleFC.DataSource = Compra.ListarDetalleFC(idFacturaCompra);
            }
            else
            {
                MessageBox.Show("seleccione una fila por favor");
            }
        }
        //  ED  -  2019 07 01
    }
}
