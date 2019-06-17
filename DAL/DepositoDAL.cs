using Entidades;
using System.Data;

namespace DAL
{
    public class DepositoDAL
    {
        Conexion nuevaC = new Conexion(); //llamar a esta instancia para la coneccion

        public DataTable ListarProductosconPocoStockDAL(int cantidad)//SE puede usar para filtrar (normalmente se usa con: 0)
        {
            DataTable respuesta = new DataTable();
            string consulta = $"SELECT * FROM PRODUCTOS WHERE CANTIDAD<={cantidad}";
            respuesta = nuevaC.LeerPorComando(consulta);
            return respuesta;
        }
        public int CrearOrdenCompraDAL(EordenCompra Orden)
        {
            int respuesta = 0;
            string consulta = $"INSERT TO ORDENDECOMPRA(ID_OCOMPRA,ID_PROV,ID_USUARIO,FECHA,APROBADA_GERENTE,APROBADA_COMPRAS,ESTADO)VALUE('{Orden.GetIdOrdenCompra()}','{Orden.Getid_proveedor()}','{Orden.Getid_usuario()}','{Orden.GetFecha()}','{Orden.Getestado()}')";
            respuesta = nuevaC.EscribirPorComando(consulta);
            return respuesta;
        }
        public int CrearDetalleOrdenCompraDAL(EDetalleOrdenCompra detalle)
        {
            int respuesta = 0;
            string consulta = $"INSERT TO DETALLEORDENCOMPRA (id_detalleoc,id_ocompra,id_prod,cant,precioxunidad)VALUE('{detalle.get_idDetalleOrden()}','{detalle.get_idOCompras()}','{detalle.get_idProducto()}','{detalle.getCantidad()}','{detalle.getPrecio()}')";
            respuesta = nuevaC.EscribirPorComando(consulta);
            return respuesta;
        }

    }
}
