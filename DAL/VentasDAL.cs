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
                string consulta = $"insert into cliente (DNI,NOMBRE,DIRECCION,CODIGOPOSTAL,TELEFONO,CORREOELECTRONICO)VALUES({cliente.getidcliente()},'{cliente.getnombre()}','{cliente.getdireccion()}','{cliente.getcp()}','{cliente.gettelefono()}','{cliente.getcorreo()}')"; // COMPLETAR
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
    }
}
