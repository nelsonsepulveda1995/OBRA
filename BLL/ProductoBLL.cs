using DAL;
using Entidad;
using System.Data;

namespace BLL
{
    public class ProductoDominio
    {
        ProductoDal producto = new ProductoDal();
        public int CrearProducto()
        {
            return 1;
        }

        public DataTable listarproductosBLL()
        {
            DataTable respuesta = new DataTable();
            respuesta = producto.Listarproductos();
            return respuesta;
        }

        public int CargarStock()
        {
            return 1;
        }
        public bool VerificarStockunProductoBLL(Eproducto _producto)
        {
            bool respuesta = true;
            if (producto.VerificarStockunProductoDAL(_producto))
            {
                respuesta = false;
                return respuesta;
            }
            return respuesta;
        }
    }
}
