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
		
        public int CrearVenta(EFacturaVenta factura, List<EDetalleFacturaVenta> lista)
	
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
