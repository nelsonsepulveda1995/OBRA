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

            //  ED  -  2019 07 01
            dataGridView1.DataSource = compras.ConsultarEstadoOrdenDeCompraBLL();
            //  ED  -  2019 07 01 END
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
