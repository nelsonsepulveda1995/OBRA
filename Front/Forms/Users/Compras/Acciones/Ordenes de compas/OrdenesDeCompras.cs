using BLL;
using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Front.Forms.Users.Compras.Acciones
{
    public partial class OrdenesDeCompras : Form
    {
        ProductoBLL producto = new ProductoBLL();
        ComprasBLL compras = new ComprasBLL();
        DepositoBLL deposito = new DepositoBLL();
        UsuarioBLL usuario = new UsuarioBLL();

        DataTable proveedor = new DataTable();
        DataTable ordenes = new DataTable();
        DataTable detalles = new DataTable();
        DataTable mediodepago = new DataTable();
        public OrdenesDeCompras()
        {
            InitializeComponent();
        }

        private void OrdenesDeCompras_Load(object sender, System.EventArgs e)
        {
            proveedor = compras.ListarProveedores();
            cb_listprovee.DataSource = proveedor;
            cb_listprovee.ValueMember = "CUIT_PROV";
            cb_listprovee.DisplayMember ="NOMBRE";

            ordenes = compras.ListarOrdenesdeCompraporEstado(1);
            cb_listordenes.DataSource = ordenes;
            cb_listordenes.ValueMember = "ID_OCOMPRA";
            cb_listordenes.DisplayMember = "ID_OCOMPRA";

            mediodepago = producto.ListarMediodePagoBLL();
            cb_mediodepago.DataSource = mediodepago;
            cb_mediodepago.DisplayMember = "DESCRIPCION";
             cb_mediodepago.ValueMember = "ID_MEDIOP";
        }

        private void MaterialFlatButton1_Click(object sender, System.EventArgs e)
        {
            //MessageBox.Show(cb_listordenes.SelectedValue.ToString());
            detalles = compras.DetalledeUnaorden(Convert.ToInt32(cb_listordenes.SelectedValue)); //corregir combo box
            dataGridView1.DataSource = detalles;
        }

        private void BotonOrdenarCompras_Click(object sender, EventArgs e)
        {
            //Se borro cambiar estado xq lo hace automaticamente al realizar la compra
           
            EFacturaCompra factura = new EFacturaCompra();
            EdetalleFacturaCompra detalle = new EdetalleFacturaCompra();
            List<EdetalleFacturaCompra> listadetalle = new List<EdetalleFacturaCompra>(); //variables a utilizar

            int dia = DateTime.Today.Day; int mes = DateTime.Today.Month; int año = DateTime.Today.Year;
            string fecha = $"{año}-{mes}-{dia}";

            factura.SetIdOrden(Convert.ToInt32(cb_listordenes.SelectedValue));
            factura.SetFecha(fecha);
            factura.SetIdProv(Convert.ToInt32(cb_listprovee.SelectedValue));
            factura.Setmediodepago(Convert.ToInt32(cb_mediodepago.ValueMember));
            factura.SetnombreUsuario(usuario.GetUsuarioName().Trim('@'));

            decimal total=0;
            for(int x = 0; x < detalles.Rows.Count; x++)
            {
                total =total + Convert.ToDecimal(detalles.Rows[x]["PRECIOXUNIDAD"]);
            }

            factura.Settotal(total); //Factura cargada, faltan realizar pruebas


            for(int x = 0; x < proveedor.Rows.Count;x++) //cargar el detalle de factura con el detalle de orden de compra
            {
                detalle.SetCantidad(Convert.ToInt32(detalles.Rows[x]["CANT"]));
                detalle.SetIdDProd(Convert.ToInt32(detalles.Rows[x]["ID_PROD"]));
                detalle.SetPrecio(Convert.ToDecimal(detalles.Rows[x]["PRECIOXUNIDAD"]));
                

                listadetalle.Add(detalle); //Carga el detalle a la lista
                   //revisar coherencia con bd y completar COMPRASDAL    
            }

            compras.CrearFacturaCompra(factura, listadetalle, factura.GetidOrden(), 2);

        }

        private void MaterialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
