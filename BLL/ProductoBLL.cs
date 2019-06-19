using DAL;
using System.Data;

namespace BLL
{
    public class ProductoBLL
    {
        ProductoDAL productoDAL = new ProductoDAL();
        public int CrearProducto()
        {
            return 1;
        }

        public DataTable ListarProductos() => productoDAL.GetListaProductos();

        public int CargarStock()
        {
            return 1;
        }
        public bool VerificarStockProducto(int ID) => productoDAL.GetStockProducto(ID) > 0;

        public DataTable ListarMediodePagoBLL()
        {
            DataTable respuesta = new DataTable();
            return respuesta;
        }
        public DataTable VerunProducto(int id)
        {
            return productoDAL.GetProducto(id);
        }
    }
}