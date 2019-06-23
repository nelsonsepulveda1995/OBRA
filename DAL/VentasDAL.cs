using System;
using System.Data;
using System.Data.SqlClient;
using Entidad;

namespace DAL
{
    public class VentasDAL
    {
        readonly Conexion nuevaC = new Conexion(); //llamar a esta instancia para la conexion

        public DataTable ListarClientes() => nuevaC.LeerPorComando("select * from CLIENTE");
        public DataTable ListarFacturasVentas() => nuevaC.LeerPorComando("select* from FACTURAVENTA");
        public DataTable ListarDetalleVenta() => nuevaC.LeerPorComando("select* from DETALLEFACTURAVENTA");

        public int GuardarCliente(Ecliente cliente) //VERIFICA SI EXISTE Y SI NO LO CREA
        {
            if (!ExisteCliente(cliente.getidcliente()))
			{
                SqlParameter[] ParametrosCliente = new SqlParameter[]{

                    nuevaC.CrearParametro("@DNI", cliente.getidcliente()),
                    nuevaC.CrearParametro("@Nombre", cliente.getnombre()),
                    nuevaC.CrearParametro("@Direccion", cliente.getdireccion()),
                    nuevaC.CrearParametro("@CP", cliente.getcp()),
                    nuevaC.CrearParametro("@Telefono", cliente.gettelefono()),
                    nuevaC.CrearParametro("@Correo", cliente.getcorreo()),
                };

                return nuevaC.EscribirPorStoreProcedure("uspAgregarCliente", ParametrosCliente);
            }
            else return -1;
        }
        public bool ExisteCliente(int DNI) => nuevaC.LeerPorComando($"SELECT * FROM CLIENTE WHERE DNI = {DNI}").Rows.Count > 0;
	
	    public int CrearventaDAL(EFacturaVenta factura)
        {
            int respuesta;
            string consulta = $"insert into FACTURAVENTA (ID_MEDIOP,DNI,NOMBREUSUARIO,FECHA)VALUES({factura.Getmediop()},{factura.Getdni()},'{factura.Getnombreusuario()}',CONVERT(date,'{factura.GetFecha()}'))";
            respuesta = nuevaC.EscribirPorComando(consulta);
            return respuesta;
        }
        public int CrearDetalledeVenta(EDetalleFacturaVenta detalle)
        {
            int respuesta;
            string consulta = $"INSERT INTO DETALLEFACTURAVENTA (ID_FACTURAVENTA,ID_PROD,CANT,PRECIOXUNIDAD)VALUES({detalle.GetIdFacturaCompra()},{detalle.GetIdProd()},{detalle.GetCant()},CONVERT(decimal,{detalle.GetPrecio()}))";
            respuesta = nuevaC.EscribirPorComando(consulta);
            return respuesta;
        }
        public int UltimoIdFacturaVentaDAL()
        {
            int respuesta;
            DataTable temp = new DataTable();
            string consulta = "SELECT ID_FACTURAVENTA TOP(1) FROM FACTURA VENTA ORDER BY DESC";
            temp = nuevaC.LeerPorComando(consulta);
            if (temp.Rows.Count<0) {
                respuesta =Convert.ToInt32(temp.Rows[0]["ID_FACTURAVENTA"]);
                return respuesta;
            }
            else { return 1; }
        }
	}
}
