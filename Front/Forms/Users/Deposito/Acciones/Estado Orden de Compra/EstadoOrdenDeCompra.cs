using BLL;
using Entidad;
using System;
using System.Windows.Forms;

namespace Front.Forms.Users.Deposito.Acciones
{
    public partial class EstadoOrdenDeCompra : Form
    {
        ComprasBLL compras = new ComprasBLL();
        public EstadoOrdenDeCompra()
        {
            InitializeComponent();
        }

        private void BotonGestionarProvedores_Click(object sender, System.EventArgs e)
        {
            dataGridView1.DataSource = compras.ConsultarEstadoOrdenDeCompraBLL(Convert.ToInt32(numericUpDown1.Value));

        }

        private void GestionarProvedores_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
