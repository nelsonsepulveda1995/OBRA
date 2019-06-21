using System;
using System.Data;
using Entidad;

namespace DAL
{
    public class VentasDAL
    {
        Conexion nuevaC = new Conexion(); //llamar a esta instancia para la conexion
        public DataTable VerunClienteDAL(Ecliente _cliente)
        {
            string coneccion = $"select * from CLIENTES WHERE ID_CLIENTE='{_cliente.getidcliente()}'";
            DataTable respuesta = new DataTable();
            respuesta=nuevaC.LeerPorComando(coneccion);
            return respuesta;
        }
        public DataTable ListarClientesDAL()
        {
            
            string coneccion = "select * from CLIENTE";
            DataTable respuesta = new DataTable();
            respuesta = nuevaC.LeerPorComando(coneccion);
            return respuesta;
        }
        public DataTable ListarFacturasVentas()
        {
            DataTable respuesta = new DataTable();
            string consulta = "select* from FACTURAVENTA";
            respuesta=nuevaC.LeerPorComando(consulta);
            return respuesta;
        }
        public DataTable ListarDetalleVentaBLL()
        {
            DataTable respuesta = new DataTable();
            string consulta = "select* from DETALLEFACTURAVENTA";
            respuesta = nuevaC.LeerPorComando(consulta);
            return respuesta;
        }
        public int CrearClienteDAL(Ecliente cliente) //VERIFICA SI EXISTE Y SI NO LO CREA
        {
            if (VerificarClienteDAL(cliente))
            {
                string consulta = $"insert into cliente (DNI,NOMBRE,DIRECCION,CODIGOPOSTAL,TELEFONO,CORREOELECTRONICO)VALUES({cliente.getidcliente()},'{cliente.getnombre()}','{cliente.getdireccion()}','{cliente.getcp()}','{cliente.gettelefono()}','{cliente.getcorreo()}')"; 
                return 1;
            }
            return -1;
        }
        public bool VerificarClienteDAL(Ecliente cliente)
        {
            DataTable temp = new DataTable();
            string consulta = $"select * from CLIENTE WHERE DNI={cliente.getidcliente()}";
            temp = nuevaC.LeerPorComando(consulta);
            if (temp.Rows.Count > 0)
            {
                return false;   //si ya existe un cliente igual
            }
            return true;
        }
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
