using DAL;
using Entidad;
using System.Data;

namespace BLL
{
    public class ProductoBLL
    {
        ProductoDAL productoDAL = new ProductoDAL();

        public int CrearProductoBLL(Eproducto _producto) => productoDAL.SETProductoDAL(_producto);

        public DataTable ListarProductos() => productoDAL.GetListaProductos();

        public int CargarStock()
        {
            return 1;
        }
        public bool VerificarStockProducto(int ID) => productoDAL.GetStockProducto(ID) > 0;

        public DataTable ListarMediodePago() => productoDAL.GetMediosdePago();
        public DataTable VerunProducto(int id)
        {
            return productoDAL.GetProducto(id);
        }
    }
}