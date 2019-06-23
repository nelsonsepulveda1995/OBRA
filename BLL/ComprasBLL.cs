using DAL;
using Entidad;
using System.Data;

namespace BLL
{
    public class ComprasBLL
    {
        ProductoDAL producto = new ProductoDAL();
        readonly ComprasDAL comprasDAL = new ComprasDAL();
        public int CrearCompra()
        {

            return 1;
        }
        public DataTable VerCompras() => comprasDAL.GetFacturasCompras();

        public DataTable VerDetalleCompras() => comprasDAL.GetDetalleFacturaCompra();

        public int CrearProveedor(Eproveedor proveedor)
        {
            if (comprasDAL.VerificarProveedor(proveedor))
            {
                int temp;
                temp = comprasDAL.GuardarProveedor(proveedor); //si la consulta devuelve 0 es que no escribio en la base
                return temp;
            }
            return -1; //solo si el proveedor existe y tira un false en el if 
        }

        public DataTable ListarProveedores() => comprasDAL.GetProveedores();

        public int DesabilitarProveedor()
        {
            return 1;
        }

        public int ModificarProveedor()
        {
            return 1;
        }
        public DataTable CrearRemito()           //COMPLETAR
        {
            DataTable respuesta = new DataTable();
            return respuesta;
        }
        public DataTable CrearDetalleRemito()    //COMPLETAR
        {
            DataTable respuesta = new DataTable();
            return respuesta;
        }
        public DataTable ListarOrdenesdeCompraporEstado(int estado) => comprasDAL.GetOrdenesporEstado(estado);

        public DataTable DetalledeUnaorden(int id) => comprasDAL.GetDetalledeUnaOrden(id);
    }
}
