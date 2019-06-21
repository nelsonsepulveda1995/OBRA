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

        public int CrearVentaBLL(EFacturaVenta factura, List<EDetalleFacturaVenta> lista)
        {
            int respuesta;
            
            respuesta = venta.CrearventaDAL(factura); //crea la factura
            int id =venta.UltimoIdFacturaVentaDAL(); //busca el id de la ultima factura
            if (respuesta == 0)
            {
                return -1;
            }
            else
            {
                foreach(EDetalleFacturaVenta detalle in lista) //revisa la lista
                {
                    detalle.SetIdFacturaVenta(id); //carga el id en el detalle
                    venta.CrearDetalledeVenta(detalle); //crea el detalle de la factura anteriormente creada
                }
            }
            return respuesta;
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
        public int CrearCliente(Ecliente cliente)
        {
            int respuesta;
            respuesta= venta.CrearClienteDAL(cliente);
            return respuesta;
        }
    }
}
