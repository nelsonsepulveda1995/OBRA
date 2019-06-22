using DAL;
using Entidad;
using System.Collections.Generic;
using System.Data;

namespace BLL
{
    public class DepositoBLL
    {
        readonly DepositoDAL deposito = new DepositoDAL();
        ProductoDAL producto = new ProductoDAL();


        public int UpdateStockBLL(int ID, decimal dato){

            return deposito.ModficarStock(ID, dato);
            
        }

        public DataTable ListarProductosconPocoStockBLL(int _cantidad)
        {
            return deposito.ListarProductosconPocoStockDAL(_cantidad);
        }

        public DataTable listarTodosLosProdutos()
        {
            return deposito.listAllProducts();
        }

        public DataTable listarProductosConStockMenorAZero(int StockMenorA)
        {
            return deposito.ListarProductosconPocoStockDAL(StockMenorA);
        }


        public int CrearOrdenCompraBLL(EordenCompra Orden, List<EDetalleOrdenCompra> listadetalles)
        {

            int respuesta;
            respuesta = deposito.CrearOrdenCompraDAL(Orden);
            if (respuesta == 0)
            {
                return -1;    //error en crear la orden
            }
            int id = deposito.UltimoIdOrdeCompra();
            foreach (EDetalleOrdenCompra detalle in listadetalles)
            {
                detalle.Setid_Compras(id); //carga la fk de orden de compra  en el detalle
                if (CrearDetalleOrdenCompraBLL(detalle) == 0)
                {
                    return -2;   //error  en crear el detalle de compra
                }
            }
            return respuesta;
        }

        public int CrearDetalleOrdenCompraBLL(EDetalleOrdenCompra detalle)
        {
            int respuesta;
            respuesta = deposito.CrearDetalleOrdenCompraDAL(detalle);
            return respuesta;
        }
        public DataTable VerunproductoBLL(int ID_PRODUCTO)
        {
            DataTable respuesta = new DataTable();
            respuesta = producto.GetProducto(ID_PRODUCTO);
            return respuesta;
        }

    }
}