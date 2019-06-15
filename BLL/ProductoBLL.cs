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
    }
}