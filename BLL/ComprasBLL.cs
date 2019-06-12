using DAL;
using System.Data;

namespace BLL
{
    public class ComprasDominio
    {
        ProductoDAL producto = new ProductoDAL();
        public int CrearCompra()
        {

            return 1;
        }
        public DataTable VerCompras()
        {
            DataTable x = new DataTable();
            return x = null;
        }
        public int CrearProveedor()
        {

            return 1;
        }

        public int DesabilitarProveedor()
        {
            return 1;
        }

        public DataTable BuscarProveedor()
        {
            DataTable x = new DataTable();
            return x = null;

        }
        public int ModificarProveedor()
        {
            return 1;
        }

    }
}
