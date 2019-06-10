using System;
using System.Windows.Forms;

namespace Front.Forms.Users.Gerencia
{
    public partial class BotonesGerente : Form
    {
        public BotonesGerente()
        {
            InitializeComponent();
        }

        private void BotonReporteDeCompras_Click(object sender, EventArgs e)
        {
            Main.AtenderAccion<Acciones.ReporteDeCompras>(this);
        }

        private void BotonReporteDeVentas_Click(object sender, EventArgs e)
        {
            Main.AtenderAccion<Acciones.ReporteDeVentas>(this);
        }
    }
}
