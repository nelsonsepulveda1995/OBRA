using DAL;
using Entidad;
using System.Collections.Generic;
using System.Data;

namespace BLL
{
    public class DepositoBLL
    {
        readonly DepositoDAL deposito = new DepositoDAL();
        readonly ProductoDAL producto = new ProductoDAL();

        public DataTable ConsultarEstadoOrdenDeCompraBLL(int id_OCOMPRA= 0)
        {
            return deposito.ConsultarEstadoOrdenDeCompraDAL(id_OCOMPRA);
        }


        public int UpdateStockBLL(int ID, decimal dato) => deposito.ModficarStock(ID, dato);
		
		public DataTable ListarProductosconPocoStock(int cantidad) => deposito.GetProductosConPocoStock(cantidad);

        public DataTable ListarTodosLosProdutos() => producto.GetListaProductos();

        public DataTable ListarProductosConStockMenorAZero(int StockMenorA)
        {
            return deposito.GetProductosConPocoStock(StockMenorA);
        }

        public int CrearOrdenCompraBLL(EordenCompra Orden, List<EDetalleOrdenCompra> listadetalles)
        {
            int respuesta;
            decimal pTotal = 0;
            foreach (EDetalleOrdenCompra detalle in listadetalles)
            {
                decimal pParcial = (detalle.getPrecio() * detalle.getCantidad());
                pTotal = pTotal + pParcial;
            }
            Orden.SetPtotal(pTotal);
            respuesta = deposito.GuardarOrdenCompra(Orden);
            if (respuesta == 0)
            {
                return -1;    //error en crear la orden
            }
            int id = deposito.UltimoIdOrdeCompra();
            foreach (EDetalleOrdenCompra detalle in listadetalles)
            {
                detalle.Setid_Compras(id); //carga la fk de orden de compra  en el detalle
                if (CrearDetalleOrdenCompra(detalle) == 0)
                {
                    return -2;   //error  en crear el detalle de compra
                }
            }
            return respuesta;
        }

        public int CrearDetalleOrdenCompra(EDetalleOrdenCompra detalle)
        {
            int respuesta;
            respuesta = deposito.GuardarDetalleOrdenCompra(detalle);
            return respuesta;
        }
        public DataTable VerunproductoBLL(int ID) => producto.GetProducto(ID);
    }
}