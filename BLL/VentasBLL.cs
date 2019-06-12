using DAL;
using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class VentasBLL
    {
        VentasDAL venta = new VentasDAL();
        public DataTable ListarFacturaVentaBLL()
        {
            DataTable respuesta = new DataTable();
            respuesta = venta.ListarFacturasVentas();
            return respuesta;
        }

        public int CrearVentaBLL(Eproducto _producto,Ecliente _cliente,Eusuario _vendedor)//cambiar parametros
        {
            int x=0;
            return x;
        }
        public DataTable BuscarClienteBLL()
        {
            DataTable x = new DataTable();
            return x = null;

        }
        public int ModificarClienteBLL()
        {
            return 1;
        }
        public int CrearCliente()
        {

            return 1;

        }
    }
}
