using BLL;
using Entidad;
using System;
using System.Windows.Forms;

namespace Front.Forms.Users.Compras.Acciones
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

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
