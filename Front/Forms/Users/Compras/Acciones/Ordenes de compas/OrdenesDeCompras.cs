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
        ComprasBLL compras = new ComprasBLL();
        DepositoBLL deposito = new DepositoBLL();
        DataTable proveedor = new DataTable();
        DataTable ordenes = new DataTable();
        DataTable detalles = new DataTable();
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
        }

        private void MaterialFlatButton1_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(cb_listordenes.SelectedValue.ToString());
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

            //REVISAR BIEN QUE DATOS REQUIERE UNA FACTURA DE COMPRA



            for(int x = 0; x < proveedor.Rows.Count;x++) //cargar el detalle de factura con el detalle de orden de compra
            {
                detalle.SetCantidad(Convert.ToInt32( detalles.Rows[x]["CANT"]));
                detalle.SetIdDProd(Convert.ToInt32(detalles.Rows[x]["ID_PROD"]));
                detalle.SetPrecio(Convert.ToDecimal(detalles.Rows[x]["PRECIO"]));

                listadetalle.Add(detalle); //Carga el detalle a la lista
                   //revisar coherencia con bd y completar COMPRASDAL    
            }

            compras.CrearFacturaCompra(factura,listadetalle,factura.GetidOrden(),2)

        }
    }
}
