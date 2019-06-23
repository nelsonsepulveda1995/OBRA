using DAL;
using Entidad;
using System.Data;
namespace BLL
{
    public class VentasBLL
    {
        VentasDAL venta = new VentasDAL();
        public DataTable ListarFacturaVenta()
        {
            DataTable respuesta = new DataTable();
            respuesta = venta.ListarFacturasVentas();
            return respuesta;
        }

        public int CrearVenta(Eproducto _producto,Ecliente _cliente,Eusuario _vendedor)//cambiar parametros
        {
            int x=0;
            return x;
        }
        public DataTable BuscarCliente()
        {
            DataTable x = new DataTable();
            return x = null;

        }
        public int ModificarCliente()
        {
            return 1;
        }
        public string CrearCliente(Ecliente cliente)
        {
            switch (venta.GuardarCliente(cliente))
            {
                case -1: return "Ya existe un cliente con ese DNI";
                default: return "Cliente creado correctamente";
            }
        }
    }
}
