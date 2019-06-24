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
        
        ProductoBLL productoBll = new ProductoBLL(); //instancias de producto en BLL  
        List<EDetalleOrdenCompra> ListaProductos = new List<EDetalleOrdenCompra>();//lista de  carrito donde se guardan los productos para laorden de compras
        DepositoBLL deposito = new DepositoBLL();
        UsuarioBLL usuario = new UsuarioBLL();

        public OrdenesDeCompras()
        {
            InitializeComponent();
        }

        private void OrdenesDeCompras_Load(object sender, System.EventArgs e)
        {
            cblistaproducto.DataSource = productoBll.ListarProductos();
            cblistaproducto.DisplayMember = "DESCRIPCION";
            cblistaproducto.ValueMember = "ID_PROD";
        }

        private void AgregarAlCarrito_Click(object sender, System.EventArgs e) //al tocar este boton hay que cargar a la lista lo seleccionado y mostrarlo en "listbCarrito"
        {

            EDetalleOrdenCompra eDetalleOrden = new EDetalleOrdenCompra();// instancia de entidad producto

            eDetalleOrden.Setidproducto(Convert.ToInt16(cblistaproducto.SelectedValue)); //guarda el producto que agrego al carrito
            eDetalleOrden.Setcatidad(Convert.ToInt16(numupdow_cantidad.Value));
            eDetalleOrden.Setprecio(Convert.ToDecimal((productoBll.VerunProducto(eDetalleOrden.get_idProducto())).Rows[0]["PRECIO"]));

            ListaProductos.Add(eDetalleOrden);

            dataGridView1.Rows.Add(cblistaproducto.Text, eDetalleOrden.getCantidad());

            //tb_vistacarrito.AppendText($"\n\n");
            //tb_vistacarrito.AppendText("\n" + cblistaproducto.Text+"     " + eDetalleOrden.getCantidad()+"\n");
            //tb_vistacarrito.AppendText("\n");

        }
        private void VaciarCarrito_Click(object sender, EventArgs e)
        {
            ListaProductos.Clear();
            dataGridView1.Rows.Clear();
        }

        private void BotonCrearOrdenCompra_Click(object sender, EventArgs e)
        {
            EordenCompra ordencompra = new EordenCompra();
            ordencompra.Setestado(1); //revisar si es int o bool en la  BD
            int dia = DateTime.Today.Day;
            int mes = DateTime.Today.Month;
            int año = DateTime.Today.Year;
            string fecha = $"{año}-{mes}-{dia}";
            ordencompra.Setfecha(fecha);//revisar que guarda esta funcion de fecha
            ordencompra.Setid_usuario((usuario.GetUsuarioName()).Trim('@')); //quita el arroba del nomre de usuario

            //orden de compra cargada 

            if (ListaProductos.Count == 0) //revisa si la lista tiene objetos
            {
                MessageBox.Show("Carrito vacio !!!");
            }
            else {
                if(deposito.CrearOrdenCompraBLL(ordencompra, ListaProductos)==0){

                    MessageBox.Show("Ocurrio un error en  La base de datos. Method:CrearOrdenCompraBLL ");

                }
                else
                {
                    MessageBox.Show("Orden generada correctamente");
                }
            }
               
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Cblistaproducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
