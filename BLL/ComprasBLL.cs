using DAL;
using Entidad;
using System.Data;

namespace BLL
{
    public class ComprasDominio
    {
        ProductoDAL producto = new ProductoDAL();
        ComprasDAL compras = new ComprasDAL();
        public int CrearCompra()
        {

            return 1;
        }
        public DataTable VerCompras()
        {
            DataTable respuesta = new DataTable();
            respuesta = compras.VerFacturasCompras();
            return respuesta = null;
        }
        public DataTable VerDetalleComprasBLL()
        {
            DataTable respuesta = new DataTable();
            respuesta = compras.VerDetalleFacturaCompraDAL();
            return respuesta = null;
        }

        public int CrearProveedor(Eproveedor proveedor)
        {
            if (compras.VerificarProveedorDAL(proveedor))
            {
                int temp;
                temp = compras.CrearProveedor(proveedor); //si la consulta devuelve 0 es que no escribio en la base
                return temp;
            }
            return -1; //solo si el proveedor existe y tira un false en el if 
        }

        public DataTable ListarProveedoresbll()
        {
            DataTable respuesta = new DataTable();
            respuesta = compras.ListarProveedor();
            return respuesta;
        }
        public int DesabilitarProveedor()
        {
            return 1;
        }

        public int ModificarProveedor()
        {
            return 1;
        }
        public DataTable CrearRemitoBLL()           //COMPLETAR
        {
            DataTable respuesta = new DataTable();
            return respuesta;
        }
        public DataTable CrearDetalleRemitoBLL()    //COMPLETAR
        {
            DataTable respuesta = new DataTable();
            return respuesta;
        }

    }
}
