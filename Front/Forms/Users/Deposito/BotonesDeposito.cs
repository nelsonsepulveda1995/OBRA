using System.Windows.Forms;

namespace Front.Forms.Users.Deposito
{
    public partial class BotonesDeposito : Form
    {
        public BotonesDeposito()
        {
            InitializeComponent();
        }

        private void BotonRecepcionDePedidos_Click(object sender, System.EventArgs e)
        {
            Main.AtenderAccion<Acciones.RecepcionDePedidos>(this);
        }

        private void BotonProductosSinStock_Click(object sender, System.EventArgs e)
        {
            Main.AtenderAccion<Acciones.ProductosSinStock>(this);
        }

        private void BotonOrdenesDeCompra_Click(object sender, System.EventArgs e)
        {
            Main.AtenderAccion<Acciones.OrdenesDeCompras>(this);
        }

        private void BotonListaDeProductos_Click(object sender, System.EventArgs e)
        {
            Main.AtenderAccion<Acciones.ListaDeProductos>(this);
        }

        private void BotonEstadoOrdenDeCompra_Click(object sender, System.EventArgs e)
        {
            Main.AtenderAccion<Acciones.EstadoOrdenDeCompra>(this);
        }
    }
}
