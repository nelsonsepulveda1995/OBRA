using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BLL;
using DAL;
using Entidad;

namespace Front.Forms.Users.Deposito.Acciones
{
    public partial class OrdenesDeCompras : Form
    {
        
        EDetalleOrdenCompra eDetalleOrden = new EDetalleOrdenCompra();// instancia de entidad producto
        ProductoBLL productoBll = new ProductoBLL(); //instancias de producto en BLL  
        List<EDetalleOrdenCompra> ListaProductos = new List<EDetalleOrdenCompra>();//lista de  carrito donde se guardan los productos para laorden de compras
        DepositoDAL deposito = new DepositoDAL();
        UsuarioBLL usuario = new UsuarioBLL();

        public OrdenesDeCompras()
        {
            InitializeComponent();
        }

        private void OrdenesDeCompras_Load(object sender, System.EventArgs e)
        {
            cblistaproducto.DataSource = productoBll.ListarProductos();;
            cblistaproducto.DisplayMember = "DESCRIPCION";
            cblistaproducto.ValueMember = "ID_PROD";
            tb_vistacarrito.Text = "  ";
        }

        private void AgregarAlCarrito_Click(object sender, System.EventArgs e) //al tocar este boton hay que cargar a la lista lo seleccionado y mostrarlo en "listbCarrito"
        {
            eDetalleOrden.Setidproducto(Convert.ToInt16(cblistaproducto.SelectedValue)); //guarda el producto que agrego al carrito
            eDetalleOrden.Setcatidad(Convert.ToInt16(numupdow_cantidad.Value));
            eDetalleOrden.Setprecio(Convert.ToDecimal((productoBll.VerunProducto(eDetalleOrden.get_idProducto())).Rows[0]["PRECIO"]));

            ListaProductos.Add(eDetalleOrden);
            tb_vistacarrito.AppendText("\n"+cblistaproducto.DisplayMember+"     " + eDetalleOrden.getCantidad());
            tb_vistacarrito.AppendText("\n");
        }
        private void VaciarCarrito_Click(object sender, EventArgs e)
        {
            ListaProductos.Clear();
            tb_vistacarrito.Clear();
        }

        private void BotonCrearOrdenCompra_Click(object sender, EventArgs e)
        {
            EordenCompra ordencompra = new EordenCompra();
            ordencompra.Setestado(false); //revisar si es int o bool en la  BD
            DateTime fec = new DateTime();
            ordencompra.Setfecha(fec.ToUniversalTime());//revisar que guarda esta funcion de fecha
            ordencompra.Setid_usuario(usuario.GetUsuarioName());
            //orden de compra cargada 

            deposito.CrearOrdenCompraDAL(ordencompra);   //seguir mañana !!!!!  conectar orden con detalle eso es mucho muy importate
        }
    }
}
