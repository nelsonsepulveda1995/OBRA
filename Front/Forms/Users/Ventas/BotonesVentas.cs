using System.Windows.Forms;

namespace Front.Forms.Users.Ventas
{
    public partial class BotonesVentas : Form
    {
        public BotonesVentas()
        {
            InitializeComponent();
        }

        private void BotonFacturasDeVentas_Click(object sender, System.EventArgs e)
        {
            Main.AtenderAccion<Acciones.FacturasDeVentas>(this);
        }

        private void BotonProductosSinStock_Click(object sender, System.EventArgs e)
        {
            Main.AtenderAccion<Acciones.ProductosSinStock>(this);
        }

        private void BotonGestionarClientes_Click(object sender, System.EventArgs e)
        {
            Main.AtenderAccion<Acciones.GestionarClientes>(this);
        }

        private void BotonListaDeProductos_Click(object sender, System.EventArgs e)
        {
            Main.AtenderAccion<Acciones.ListaDeProductos>(this);
        }
    }
}
