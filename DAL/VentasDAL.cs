using System.Data;
using Entidad;

namespace DAL
{
    public class VentasDAL
    {
        readonly Conexion nuevaC = new Conexion(); //llamar a esta instancia para la conexion
        public DataTable VerunCliente(Ecliente _cliente)
        {
            string coneccion = $"select * from CLIENTES WHERE ID_CLIENTE='{_cliente.getidcliente()}'";
            DataTable respuesta = new DataTable();
            respuesta=nuevaC.LeerPorComando(coneccion);
            return respuesta;
        }
        public DataTable ListarClientes()
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
        public DataTable ListarDetalleVenta()
        {
            DataTable respuesta = new DataTable();
            string consulta = "select* from DETALLEFACTURAVENTA";
            respuesta = nuevaC.LeerPorComando(consulta);
            return respuesta;
        }
        public int GuardarCliente(Ecliente cliente) //VERIFICA SI EXISTE Y SI NO LO CREA
        {
            if (!ExisteCliente(cliente.getidcliente()))
            {
                string consulta = $"INSERT INTO CLIENTE(DNI,NOMBRE,DIRECCION,CODIGOPOSTAL,TELEFONO,CORREOELECTRONICO)" +
                    $"VALUES({cliente.getidcliente()},'{cliente.getnombre()}'" +
                    $",'{cliente.getdireccion()}','{cliente.getcp()}','" +
                    $"{cliente.gettelefono()}','{cliente.getcorreo()}')";
                return nuevaC.EscribirPorComando(consulta);
            }
            return -1;
        }
        public bool ExisteCliente(int DNI) => nuevaC.LeerPorComando($"SELECT * FROM CLIENTE WHERE DNI = {DNI}").Rows.Count > 0;
    }
}
