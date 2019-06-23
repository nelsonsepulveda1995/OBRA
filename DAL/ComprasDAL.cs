using Entidad;
using System.Data;

namespace DAL
{
    public class ComprasDAL
    {
        Conexion nuevaC = new Conexion(); //llamar esta instancia para la coneccion
        public DataTable GetProveedores() => nuevaC.LeerPorStoreProcedure("spListarProvedores");
        public int CrearCompra()//Cambiar Variables para Crear Compras
        {
            int respuesta = 1;


            return respuesta;
        }
        public int GuardarProveedor(Eproveedor _proveedor)
        {
            string consulta = $"INSERT TO PROVEDOR(CUIT_PROV,NOMBRE,DIRECCION,TELEFONO,CORREOELECTRONICO)VALUE({_proveedor.getcuit()},'{_proveedor.getnoombre()}','{_proveedor.getdireccion()}','{_proveedor.gettelefono()}','{_proveedor.getcorreo()}')";
            return nuevaC.EscribirPorComando(consulta);
        }
        public DataTable GetFacturasCompras() //FUNCION  A COMPLETAR
        {
            DataTable respuesta = new DataTable();
            string consulta = "SELECT * FROM FACTURACOMPRA";
            respuesta = nuevaC.LeerPorComando(consulta);
            return respuesta;
        }
        public DataTable GetDetalleFacturaCompra()
        {
            DataTable respuesta = new DataTable();
            string consulta = "SELECT * FROM DETALLEFACTURACOMPRA";
            respuesta = nuevaC.LeerPorComando(consulta);
            return respuesta;
        }
        public bool ExisteProvedor(int cuit) 
        {
            string consulta = $"SELECT CUIT_PROV FROM PROVEDOR WHERE CUIT_PROV ={cuit}";
            return nuevaC.LeerPorComando(consulta).Rows.Count > 0;
        }
        public DataTable ListarOrdenesdeCompras() => nuevaC.LeerPorStoreProcedure("spListarOrdenCompra");

        public DataTable GetOrdenesporEstado(int estado)//1 sin aprobar 2 aprobado
        {
            DataTable respuesta = new DataTable();
            string consulta = $"Select * FROM ORDENDECOMPRA WHERE ESTADO='{estado}'";
            respuesta = nuevaC.LeerPorComando(consulta);
            return respuesta;
        }
        public DataTable GetDetalledeUnaOrden(int id)
        {
            DataTable respuesta = new DataTable();
            string consulta = $"Select * from DETALLEORDENCOMPRA WHERE ID_DETALLEOC='{id}'";
            respuesta = nuevaC.LeerPorComando(consulta);
            return respuesta;
        }
    }
}