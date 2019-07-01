using DAL;
using Entidad;
using System;
using System.Collections.Generic;
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
            decimal Ptotal = 0;
            decimal Pparcial = 0;

            foreach (EDetalleFacturaVenta detalle in lista) //revisa la lista
            {
                Pparcial += (detalle.GetPrecio() * detalle.GetCant());
                Ptotal = Ptotal + Pparcial;
            }
            factura.setPtotal(Ptotal);

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
        //  ED  -  2019 07 01
        public DataTable ListarDetalleFV(string idFacturaVenta)
        {            
            return venta.ListarDetalleFV(idFacturaVenta);
        }
        //  ED  -  2019 07 01 END

        public DataTable BuscarCliente()
        {
            DataTable x = new DataTable();
            x = venta.ListarClientes();
            return x;

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
