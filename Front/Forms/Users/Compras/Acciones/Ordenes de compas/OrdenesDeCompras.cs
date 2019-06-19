using BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace Front.Forms.Users.Compras.Acciones
{
    public partial class OrdenesDeCompras : Form
    {
        ComprasDominio compras = new ComprasDominio();
        DepositoBLL deposito = new DepositoBLL();
        public OrdenesDeCompras()
        {
            InitializeComponent();
        }

        private void OrdenesDeCompras_Load(object sender, System.EventArgs e)
        {
            DataTable proveedor = new DataTable();
            DataTable ordenes = new DataTable();
            proveedor = compras.ListarProveedoresbll();
            cb_listprovee.DataSource = proveedor;
            cb_listprovee.ValueMember = "CUIT_PROV";
            cb_listprovee.DisplayMember ="NOMBRE";

            ordenes = compras.ListarOrdenesdeCompraporEstado(1);
            cb_listordenes.DataSource = ordenes;
            cb_listordenes.ValueMember = "ID_OCOMPRA";
            cb_listordenes.DisplayMember = "FECHA";
        }

        private void MaterialFlatButton1_Click(object sender, System.EventArgs e)
        {
            DataTable detalles = new DataTable();
            detalles = compras.DetalledeUnaordenBLL(Convert.ToInt32(cb_listordenes.SelectedItem.ToString())); //corregir combo box
            dataGridView1.DataSource = detalles;
        }
    }
}
