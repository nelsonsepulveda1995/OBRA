using DAL;
using System.Data;

namespace BLL
{
    public class ProductoBLL
    {
        ProductoDAL productoDAL = new ProductoDAL();
        VentasDAL VentasDAL = new VentasDAL();
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
            // ED  -  2019 06 23
            DataTable respuesta = new DataTable();
            respuesta = VentasDAL.ListarMedioP();
            return respuesta;
            // ED  -  2019 06 23 END
        }
        public DataTable VerunProducto(int id)
        {
            return productoDAL.GetProducto(id);
        }
    }
}