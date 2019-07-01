using BLL;
using System.Data;
using System.Windows.Forms;

namespace Front.Forms.Users.Ventas.Acciones
{
    public partial class FacturasDeVentas : Form
    {
        VentasBLL venta = new VentasBLL();
        string idFacturaVenta;
        public FacturasDeVentas()
        {
            InitializeComponent();
        }

        private void BotonFacturaDeVentas_Click(object sender, System.EventArgs e)
        {
            dataGridView1.DataSource = venta.ListarFacturaVenta();
        }
        // ED  -  2019 07 01
        private void BtnVerDetalleFV_Click(object sender, System.EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idFacturaVenta = dataGridView1.CurrentRow.Cells["ID_FACTURAVENTA"].Value.ToString();
                gvwDetalleFV.DataSource = venta.ListarDetalleFV(idFacturaVenta);
            }
            else
            {
                MessageBox.Show("seleccione una fila por favor");
            }
        }
        // ED  -  2019 07 01 END;
    }
}
