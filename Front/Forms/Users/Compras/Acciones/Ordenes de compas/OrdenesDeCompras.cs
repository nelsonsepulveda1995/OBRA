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
        UsuarioBLL usuario = new UsuarioBLL();
        decimal totalOC;
        public OrdenesDeCompras()
        {
            InitializeComponent();
        }

        private void OrdenesDeCompras_Load(object sender, System.EventArgs e)
        {
            inicio();            
        }

        private void MaterialFlatButton1_Click(object sender, System.EventArgs e)
        {            
            detalles = compras.DetalledeUnaorden(Convert.ToInt32(cb_listordenes.SelectedValue));//corregir combo box
            dataGridView1.DataSource = detalles;
            //  ED  -  2019 07 01
            totalOC = compras.TotalOC(Convert.ToInt32(cb_listordenes.SelectedValue));
            

        }

        private void BotonOrdenarCompras_Click(object sender, EventArgs e)
        {            

            EFacturaCompra facturaFC = new EFacturaCompra();
            EdetalleFacturaCompra detalleFC = new EdetalleFacturaCompra();
            List<EdetalleFacturaCompra> listadetalleFC = new List<EdetalleFacturaCompra>(); //variables a utilizar

            int dia = DateTime.Today.Day; int mes = DateTime.Today.Month; int año = DateTime.Today.Year;
            string fecha = $"{año}-{mes}-{dia}";

            facturaFC.Setnombreusuario(usuario.GetUsuarioName().Trim('@'));
            facturaFC.setPtotal(totalOC);
            facturaFC.Setmodiop(1);
            facturaFC.SetIdOrden(Convert.ToInt32(cb_listordenes.SelectedValue));
            facturaFC.SetFecha(fecha);
            facturaFC.SetIdProv(Convert.ToInt32(cb_listprovee.SelectedValue));
            //falta total

            listadetalleFC = compras.ListDetalleOC(Convert.ToInt32(cb_listordenes.SelectedValue));            

            int ok = compras.CrearFacturaCompra(facturaFC, listadetalleFC);
            if (ok == 1)
            {
                MessageBox.Show("Factura creada");
                limpiar();
                inicio();
            }
            else
            {
                MessageBox.Show("Error al crear factura");
            }
            
        }

        private void inicio()
        {
            proveedor = compras.ListarProveedores();
            cb_listprovee.DataSource = proveedor;
            cb_listprovee.ValueMember = "CUIT_PROV";
            cb_listprovee.DisplayMember = "NOMBRE";

            ordenes = compras.ListarOrdenesdeCompraporEstado(1);
            cb_listordenes.DataSource = ordenes;
            cb_listordenes.ValueMember = "ID_OCOMPRA";
            cb_listordenes.DisplayMember = "ID_OCOMPRA";
        }
        private void limpiar()
        {
            dataGridView1.DataSource = null;
        }

        private void BtnRechazarOC_Click(object sender, EventArgs e)
        {
            int idOC = Convert.ToInt32(cb_listordenes.SelectedValue);
            int ok = compras.cambiarEstadoOrdenDecompraBLL(idOC, 3);
            if (ok == 1)
            {
                limpiar();
                inicio();
                MessageBox.Show("Orden rechazada");
            }
            else
            {
                MessageBox.Show("Erorr contacte a sistemas");
            }
        }
        //  ED  -  2019 07 01 END
    }
}
