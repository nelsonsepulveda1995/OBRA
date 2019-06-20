using BLL;
using System.Data;
using System.Windows.Forms;

namespace Front.Forms.Users.Ventas.Acciones
{
    public partial class FacturasDeVentas : Form
    {
        VentasBLL venta = new VentasBLL(); 
        public FacturasDeVentas()
        {
            InitializeComponent();
        }

        private void BotonFacturaDeVentas_Click(object sender, System.EventArgs e)
        {
            dataGridView1.DataSource = venta.ListarFacturaVentaBLL();
        }
    }
}
