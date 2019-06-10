using System;
using System.Windows.Forms;

namespace Front.Forms.Users.Compras
{
    public partial class BotonesCompras : Form
    {
        public BotonesCompras()
        {
            InitializeComponent();
        }

        private void BotonProvedores_Click(object sender, EventArgs e)
        {
            Main.AtenderAccion<Acciones.GestionarProvedores>(this);
        }

        private void BotonOrdenCompra_Click(object sender, EventArgs e)
        {
            Main.AtenderAccion<Acciones.OrdenesDeCompras>(this);
        }

        private void BotonFacturasDeCompras_Click(object sender, EventArgs e)
        {
            Main.AtenderAccion<Acciones.FacturasDeCompras>(this);
        }

        private void BotonRemitos_Click(object sender, EventArgs e)
        {
            Main.AtenderAccion<Compras.Acciones.GestionarRemitos>(this);
        }

        private void BotonListaDeProductos_Click(object sender, EventArgs e)
        {
            Main.AtenderAccion<Compras.Acciones.ListaDeProductos>(this);
        }
    }
}
